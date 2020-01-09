using System;
using System.Collections.Generic;
using System.Drawing;

namespace SlidePuzzle
{
    /// <summary>
    /// パズル全体を制御するクラス
    /// </summary>
    public class Puzzle
    {
        /// <summary>
        /// パズルの元画像
        /// </summary>
        public Image OriginalImage { get; }
        
        /// <summary>
        /// パズルのレベル
        /// </summary>
        public int Level { get; }
        
        /// <summary>
        /// 盤面の状態
        /// </summary>
        public int[] Board { get; private set; }
        
        /// <summary>
        /// 空マスのインデックス
        /// </summary>
        public int SpaceIndex { get; private set; }
        
        /// <summary>
        /// 分割した画像の配列
        /// </summary>
        public Image[] MassImage { get; }
        
        /// <summary>
        /// 分割した列の数(レベル + 2)
        /// </summary>
        public int SplitCount { get; }
        
        /// <summary>
        /// 盤面を構成するマスの数
        /// </summary>
        public int MassCount { get; }
        
        /// <summary>
        /// 1つのマスの幅
        /// </summary>
        public int MassWidth { get; }

        /// <summary>
        /// スライドした回数
        /// </summary>
        public int SlideCount { get; private set; }
        
        /// <summary>
        /// 1つ前にランダムで移動した方向を格納する変数
        /// </summary>
        private Direction PrevRandomDirection { get; set; } = Direction.None;
        
        /// <summary>
        /// 乱数生成用
        /// </summary>
        private Random Rand = new Random();

        /// <summary>
        /// パズルの初期化
        /// </summary>
        /// <param name="image">パズルの画像</param>
        /// <param name="level">パズルのレベル</param>
        public Puzzle(Image image, int level)
        {
            this.OriginalImage = image;
            this.Level = level;

            // 引数を元に基本データを計算
            this.SplitCount = level + 2;
            this.MassCount = this.SplitCount * this.SplitCount;
            this.MassWidth = this.OriginalImage.Width / this.SplitCount;

            // 盤面を初期化
            this.Board = new int[this.MassCount];
            this.MassImage = new Image[this.MassCount];
            for (int i = 0; i < this.MassCount; i++)
            {
                this.Board[i] = i;
                this.MassImage[i] = this.OriginalImage.Trim(this.MassWidth, i % this.SplitCount * this.MassWidth, i / this.SplitCount * this.MassWidth);
            }
            this.Board[this.MassCount - 1] = -1;
            this.SpaceIndex = this.MassCount - 1;
        }
        
        /// <summary>
        /// 指定マスを空マスと入れ替える
        /// </summary>
        /// <param name="index">移動する指定マスのインデックス</param>
        /// <param name="countRecord">スライド回数をカウントするかどうか</param>
        /// <returns>指定マスが移動したログを返す</returns>
        public MoveLog Move(int index, bool countRecord = true)
        {
            Direction direction = this.MovableDirection(index);
            MoveLog moveLog = new MoveLog(this.Board[index], direction);
            if (direction != Direction.None)
            {
                this.Board[this.SpaceIndex] = this.Board[index];
                this.Board[index] = -1;
                this.SpaceIndex = index;

                if (countRecord) this.SlideCount++;
            }
            return moveLog;
        }

        /// <summary>
        /// ランダムなマスを空マスと入れ替える
        /// </summary>
        /// <returns>マスが移動したログを返す</returns>
        public MoveLog RandomMove()
        {
            List<Direction> directionList = this.MovableDirectionList();

            // リストから前のパズルに戻る方角を削除
            switch (this.PrevRandomDirection)
            {
                case Direction.W:
                    directionList.Remove(Direction.S);
                    break;
                case Direction.S:
                    directionList.Remove(Direction.W);
                    break;
                case Direction.A:
                    directionList.Remove(Direction.D);
                    break;
                case Direction.D:
                    directionList.Remove(Direction.A);
                    break;
            }

            int index = -1;
            this.PrevRandomDirection = directionList[Rand.Next(directionList.Count)];
            switch (this.PrevRandomDirection)
            {
                case Direction.W:
                    index = this.SpaceIndex - this.SplitCount;
                    break;
                case Direction.S:
                    index = this.SpaceIndex + this.SplitCount;
                    break;
                case Direction.A:
                    index = this.SpaceIndex - 1;
                    break;
                case Direction.D:
                    index = this.SpaceIndex + 1;
                    break;
            }
            return this.Move(index, false);
        }

        /// <summary>
        /// 盤面が完成しているか調べる
        /// </summary>
        /// <returns>盤面が完成していれば真を返す</returns>
        public bool ClearCheck()
        {
            if (this.Board[this.MassCount - 1] != -1) return false;
            for (int i = 0; i < this.MassCount - 1; i++)
            {
                if (this.Board[i] != i) return false;
            }
            return true;
        }

        /// <summary>
        /// 指定マスの移動可能方角を調べる
        /// </summary>
        /// <param name="index">調べるマスのインデックス</param>
        /// <returns>移動可能方角を返す</returns>
        private Direction MovableDirection(int index)
        {
            // 上に移動可能かどうか
            if (index - this.SplitCount == this.SpaceIndex)
                return Direction.W;

            // 下に移動可能かどうか
            if (index + this.SplitCount == this.SpaceIndex)
                return Direction.S;

            // 左に移動可能かどうか
            if (index - 1 == this.SpaceIndex && index % this.SplitCount != 0)
                return Direction.A;

            // 右に移動可能かどうか
            if (index + 1 == this.SpaceIndex && index % this.SplitCount != this.SplitCount - 1)
                return Direction.D;

            // 移動不可
            return Direction.None;
        }

        /// <summary>
        /// 空マスを基準とした移動可能方角を調べる
        /// </summary>
        /// <returns>移動可能方角のリストを返す</returns>
        private List<Direction> MovableDirectionList()
        {
            List<Direction> directionList = new List<Direction>();

            // 上に移動可能かどうか
            if (this.SpaceIndex - this.SplitCount >= 0)
                directionList.Add(Direction.W);

            // 下に移動可能かどうか
            if (this.SpaceIndex + this.SplitCount < this.MassCount)
                directionList.Add(Direction.S);

            // 左に移動可能かどうか
            if (this.SpaceIndex - 1 >= 0 && this.SpaceIndex % this.SplitCount != 0)
                directionList.Add(Direction.A);

            // 右に移動可能かどうか
            if (this.SpaceIndex + 1 < this.MassCount && this.SpaceIndex % this.SplitCount != this.SplitCount - 1)
                directionList.Add(Direction.D);

            return directionList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidePuzzle
{
    /// <summary>
    /// メインのフォーム
    /// </summary>
    public partial class PlayForm : Form
    {
        /// <summary>
        /// ゲームを制御するパズル情報
        /// </summary>
        private Puzzle MainPuzzle { get; set; }

        /// <summary>
        /// 盤面に対応した画像UIの配列
        /// </summary>
        private PictureBox[] BoardPictures { get; set; }

        /// <summary>
        /// ゲームの状態を表す
        /// </summary>
        private PuzzleState State { get; set; } = PuzzleState.WAIT;

        /// <summary>
        /// ゲーム状態に対応した色のリスト
        /// </summary>
        private Dictionary<PuzzleState, Color[]> StateColors { get; set; }

        /// <summary>
        /// ゲームの経過時間
        /// </summary>
        private int ProgressTime { get; set; }

        /// <summary>
        /// 移動判定フラグ用の変数
        /// </summary>
        private bool PictureMoving { get; set; }
        
        /// <summary>
        /// キー判定フラグ用の変数
        /// </summary>
        private bool KeyTyping { get; set; }

        /// <summary>
        /// フォームのコンストラクタ
        /// </summary>
        public PlayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームのロードイベント
        /// </summary>
        private void PlayForm_Load(object sender, EventArgs e)
        {
            // 色情報を格納する
            this.StateColors = new Dictionary<PuzzleState, Color[]>();
            this.StateColors.Add(PuzzleState.WAIT, new Color[] {
                ColorTranslator.FromHtml("0x696969"),
                ColorTranslator.FromHtml("0xdcdcdc")});
            this.StateColors.Add(PuzzleState.PLAYING, new Color[] {
                ColorTranslator.FromHtml("0x804000"),
                ColorTranslator.FromHtml("0xffc080")});
            this.StateColors.Add(PuzzleState.STOP, new Color[] {
                ColorTranslator.FromHtml("0x808000"),
                ColorTranslator.FromHtml("0xffff80")});
            this.StateColors.Add(PuzzleState.CLEAR, new Color[] {
                ColorTranslator.FromHtml("0x008000"),
                ColorTranslator.FromHtml("0x80ff80")});
            this.StateColors.Add(PuzzleState.SHUFFLE, new Color[] {
                ColorTranslator.FromHtml("0x800080"),
                ColorTranslator.FromHtml("0xff80ff")});

            // メニューバーのアイテム用の塗りつぶしアイコンを作成して反映
            Bitmap colorImage = new Bitmap(16, 16);
            Graphics g = Graphics.FromImage(colorImage);
            g.FillRectangle(new SolidBrush(BoardPanel.BackColor), 1, 1, 14, 14);
            g.DrawLine(Pens.LightGray, 1, 1, 1, 15);
            g.DrawLine(Pens.LightGray, 1, 1, 15, 1);
            g.DrawLine(Pens.LightGray, 1, 15, 15, 15);
            g.DrawLine(Pens.LightGray, 15, 1, 15, 15);
            g.Dispose();
            this.ChangeBackgroundColorToolStripMenuItem.Image = colorImage;
        }

        /// <summary>
        /// ゲームの状態を更新する
        /// </summary>
        /// <param name="state">新しく更新する状態</param>
        private void SetState(PuzzleState state)
        {
            switch (state)
            {
                case PuzzleState.WAIT:
                    this.GameTimer.Stop();
                    this.StateLabel.Text = "待機中";
                    break;
                case PuzzleState.PLAYING:
                    this.GameTimer.Start();
                    this.StateLabel.Text = "ゲームプレイ中";
                    break;
                case PuzzleState.STOP:
                    this.GameTimer.Stop();
                    this.StateLabel.Text = "一時停止中";
                    break;
                case PuzzleState.CLEAR:
                    this.GameTimer.Stop();
                    this.StateLabel.Text = "ゲームクリア";
                    break;
                case PuzzleState.SHUFFLE:
                    this.StateLabel.Text = "シャッフル中";
                    break;
            }
            this.StateLabel.ForeColor = this.StateColors[state][0];
            this.StateLabel.BackColor = this.StateColors[state][1];
            this.State = state;
        }

        /// <summary>
        /// パズル新規生成ボタンのクリックイベント
        /// </summary>
        private void GenerateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // シャッフル中の場合はそのままリターンする
            if (this.State == PuzzleState.SHUFFLE) return;

            // ゲームプレイ中の場合は一時停止にする
            if (this.State == PuzzleState.PLAYING)
            {
                this.SetState(PuzzleState.STOP);
            }

            // パズルの生成画面を表示
            GenerateForm f = new GenerateForm();
            f.Left = this.Left + (this.Width - f.Width) / 2;
            f.Top = this.Top + (this.Height - f.Height) / 2;
            f.ShowDialog();

            // パズル未作成の場合はそのまま終了
            if (f.MyPuzzle == null)
            {
                // 一時停止の場合はゲームプレイ中に戻す
                if (this.State == PuzzleState.STOP)
                {
                    this.SetState(PuzzleState.PLAYING);
                }
                return;
            }

            // 初期化
            this.SetState(PuzzleState.WAIT);
            this.MainPuzzle = f.MyPuzzle;
            this.LevelLabel.Text = "Lv" + this.MainPuzzle.Level;
            this.ProgressTime = 0;
            this.TimeLabel.Text = "0秒";
            this.SlideCountLabel.Text = "0回";

            // パズルを画面に生成
            this.BoardPictures = new PictureBox[this.MainPuzzle.MassCount];
            for (int i = 0; i < this.MainPuzzle.MassCount; i++)
            {
                this.BoardPictures[i] = new PictureBox
                {
                    Size = new Size(this.MainPuzzle.MassWidth, this.MainPuzzle.MassWidth),
                    Location = new Point(i % this.MainPuzzle.SplitCount * this.MainPuzzle.MassWidth, i / this.MainPuzzle.SplitCount * this.MainPuzzle.MassWidth),
                    Image = this.MainPuzzle.MassImage[i],
                    BackColor = Color.White,
                    BorderStyle = this.ViewLineToolStripMenuItem.Checked ? BorderStyle.Fixed3D : BorderStyle.None
                };

                // 項番がチェックされている場合は振り分ける
                if (this.ViewNumberToolStripMenuItem.Checked)
                {
                    this.BoardPictures[i].Image = this.BoardPictures[i].Image.DrawNumber(i + 1);
                }

                this.BoardPictures[i].Click += new EventHandler(BoardPictureBox_Click);
            }
            this.BoardPictures[this.MainPuzzle.MassCount - 1].Visible = false;
            this.BoardPanel.Controls.Clear();
            this.BoardPanel.Controls.AddRange(this.BoardPictures);

            // 盤面のシャッフルを行う
            this.Shuffle(new Random().Next(45, 55) * this.MainPuzzle.Level);
        }

        /// <summary>
        /// 仕切り線ボタンのクリックイベント
        /// </summary>
        private void ViewLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // パズルが未定義の場合はそのまま終了
            if (this.BoardPictures == null) return;

            BorderStyle newBorderStyle = this.ViewLineToolStripMenuItem.Checked ? BorderStyle.Fixed3D : BorderStyle.None;
            for (int i = 0; i < this.BoardPictures.Length; i++)
            {
                this.BoardPictures[i].BorderStyle = newBorderStyle;
            }
        }

        /// <summary>
        /// 項番ボタンのクリックイベント
        /// </summary>
        private void ViewNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // パズルが未定義の場合はそのまま終了
            if (this.BoardPictures == null) return;

            if (this.ViewNumberToolStripMenuItem.Checked)
            {
                // 項番を振り分ける
                for (int i = 0; i < this.MainPuzzle.MassCount; i++)
                {
                    this.BoardPictures[i].Image = this.BoardPictures[i].Image.DrawNumber(i + 1);
                }
            }
            else
            {
                // 項番を振り分ける前の画像に戻す
                for (int i = 0; i < this.MainPuzzle.MassCount; i++)
                {
                    this.BoardPictures[i].Image = this.MainPuzzle.OriginalImage.Trim(this.MainPuzzle.MassWidth, i % this.MainPuzzle.SplitCount * this.MainPuzzle.MassWidth, i / this.MainPuzzle.SplitCount * this.MainPuzzle.MassWidth);
                }
            }
        }

        /// <summary>
        /// 背景色の変更ボタンのクリックイベント
        /// </summary>
        private void ChangeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // シャッフル中の場合はそのままリターンする
            if (this.State == PuzzleState.SHUFFLE) return;

            // ゲームプレイ中の場合は一時停止にする
            if (this.State == PuzzleState.PLAYING)
            {
                this.SetState(PuzzleState.STOP);
            }

            ColorDialog cd = new ColorDialog();
            cd.Color = BoardPanel.BackColor;
            cd.AllowFullOpen = true;
            cd.SolidColorOnly = true;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                Graphics g = Graphics.FromImage(this.ChangeBackgroundColorToolStripMenuItem.Image);
                g.FillRectangle(new SolidBrush(cd.Color), 1, 1, 14, 14);
                g.Dispose();
                this.BoardPanel.BackColor = cd.Color;
            }

            // 一時停止の場合はゲームプレイ中に戻す
            if (this.State == PuzzleState.STOP)
            {
                this.SetState(PuzzleState.PLAYING);
            }

            cd.Dispose();
        }

        /// <summary>
        /// ボード上のピクチャボックスのクリックイベント
        /// </summary>
        private void BoardPictureBox_Click(object sender, EventArgs e)
        {
            // クリックしたピクチャボックスの座標から番号を特定
            PictureBox picture = (PictureBox)sender;
            int index = (picture.Location.X / this.MainPuzzle.MassWidth) +
                (picture.Location.Y / this.MainPuzzle.MassWidth) * this.MainPuzzle.SplitCount;
            this.MovePicture(index);
        }
        
        /// <summary>
        /// 経過時間を計測する用のタイマイベント
        /// </summary>
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            this.TimeLabel.Text = ++this.ProgressTime + "秒";
        }

        /// <summary>
        /// 指定した回数分パズルをシャッフルする
        /// </summary>
        /// <param name="count">シャッフルする回数</param>
        private async void Shuffle(int count)
        {
            this.SetState(PuzzleState.SHUFFLE);
            for (int i = 0; i < count; i++)
            {
                this.RandomMovePicture();
                await Task.Delay(30);
            }
            this.SetState(PuzzleState.PLAYING);
        }
        
        /// <summary>
        /// ランダムなマスを移動(移動モーション無し)
        /// </summary>
        /// <param name="index">移動するマスのインデックス</param>
        private void RandomMovePicture()
        {
            // 移動判定フラグが真なら終了
            if (this.PictureMoving) return;
            this.PictureMoving = true;
            
            // パズルを回転
            MoveLog moveLog = this.MainPuzzle.RandomMove();

            // 移動に成功したら画面の画像を同期
            if (moveLog.MoveDirection != Direction.None)
            {
                // 方角を計算して画像を動かす
                int topLocation = this.BoardPictures[moveLog.MoveIndex].Location.Y;
                int leftLocation = this.BoardPictures[moveLog.MoveIndex].Location.X;

                if (moveLog.MoveDirection == Direction.W)
                    topLocation -= this.MainPuzzle.MassWidth;
                else if (moveLog.MoveDirection == Direction.S)
                    topLocation += this.MainPuzzle.MassWidth;

                if (moveLog.MoveDirection == Direction.A)
                    leftLocation -= this.MainPuzzle.MassWidth;
                else if (moveLog.MoveDirection == Direction.D)
                    leftLocation += this.MainPuzzle.MassWidth;

                this.BoardPictures[moveLog.MoveIndex].Location = new Point(leftLocation, topLocation);
            }

            // 移動判定フラグを偽にする
            this.PictureMoving = false;
        }

        /// <summary>
        /// 指定したマスのインデックスが移動可能なら移動(移動モーション有り)
        /// </summary>
        /// <param name="index">移動するマスのインデックス</param>
        private async void MovePicture(int index)
        {
            // 移動判定フラグが真なら終了
            if (this.PictureMoving || this.State != PuzzleState.PLAYING) return;
            this.PictureMoving = true;
            
            // パズルを回転
            MoveLog moveLog = this.MainPuzzle.Move(index);

            // 移動に成功したら画面の画像を同期
            if (moveLog.MoveDirection != Direction.None)
            {
                // 方角を計算
                int topDirection = 0, leftDirection = 0;

                if (moveLog.MoveDirection == Direction.W)
                    topDirection = -1;
                else if (moveLog.MoveDirection == Direction.S)
                    topDirection = 1;

                if (moveLog.MoveDirection == Direction.A)
                    leftDirection = -1;
                else if (moveLog.MoveDirection == Direction.D)
                    leftDirection = 1;

                // 滑らかに移動
                for (int i = 0; i < this.MainPuzzle.MassWidth / 2; i++)
                {
                    this.BoardPictures[moveLog.MoveIndex].Top += 2 * topDirection;
                    this.BoardPictures[moveLog.MoveIndex].Left += 2 * leftDirection;
                    await Task.Run(() => System.Threading.Thread.Sleep(1));
                }

                // 余りが出た場合の調整
                if (this.MainPuzzle.MassWidth % 2 == 1)
                {
                    this.BoardPictures[moveLog.MoveIndex].Top += 1 * topDirection;
                    this.BoardPictures[moveLog.MoveIndex].Left += 1 * leftDirection;
                }

                // スライド回数をラベルに反映
                this.SlideCountLabel.Text = this.MainPuzzle.SlideCount + "回";

                // ゲームクリア判定
                if (this.MainPuzzle.ClearCheck())
                {
                    this.SetState(PuzzleState.CLEAR);
                    this.BoardPictures[this.MainPuzzle.MassCount - 1].Visible = true;
                    MessageBox.Show("経過時間：" + this.ProgressTime +
                        "秒\r\n回転回数：" + this.MainPuzzle.SlideCount + "回",
                        "ゲームクリア", MessageBoxButtons.OK);
                }
            }

            // 移動判定フラグを偽にする
            this.PictureMoving = false;
        }

        /// <summary>
        /// キー入力を検出時のイベント
        /// </summary>
        private void PlayForm_KeyDown(object sender, KeyEventArgs e)
        {
            // 移動判定フラグが真なら終了
            if (this.KeyTyping || this.State != PuzzleState.PLAYING)
                return;
            this.KeyTyping = true;

            // 移動方角を確定する
            int index = -1;
            switch (e.KeyCode)
            {
                case Keys.W:
                    index = this.MainPuzzle.SpaceIndex + this.MainPuzzle.SplitCount;
                    break;
                case Keys.Up:
                    index = this.MainPuzzle.SpaceIndex + this.MainPuzzle.SplitCount;
                    break;
                case Keys.S:
                    index = this.MainPuzzle.SpaceIndex - this.MainPuzzle.SplitCount;
                    break;
                case Keys.Down:
                    index = this.MainPuzzle.SpaceIndex - this.MainPuzzle.SplitCount;
                    break;
                case Keys.A:
                    index = this.MainPuzzle.SpaceIndex + 1;
                    break;
                case Keys.Left:
                    index = this.MainPuzzle.SpaceIndex + 1;
                    break;
                case Keys.D:
                    index = this.MainPuzzle.SpaceIndex - 1;
                    break;
                case Keys.Right:
                    index = this.MainPuzzle.SpaceIndex - 1;
                    break;
            }

            if (index >= 0 && index < this.MainPuzzle.MassCount)
                this.MovePicture(index);

            // 移動判定フラグを偽にする
            this.KeyTyping = false;
        }
    }
}

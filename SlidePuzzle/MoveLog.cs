
namespace SlidePuzzle
{
    /// <summary>
    /// マスの移動ログ保持用のクラス
    /// </summary>
    public class MoveLog
    {
        /// <summary>
        /// 動かしたマスのインデックス
        /// </summary>
        public int MoveIndex { get; }

        /// <summary>
        /// 動かした方角
        /// </summary>
        public Direction MoveDirection { get; }

        /// <summary>
        /// マスの移動ログの初期化
        /// </summary>
        /// <param name="moveIndex">動かしたマスのインデックス</param>
        /// <param name="moveDirection">動かした方角</param>
        public MoveLog(int moveIndex, Direction moveDirection)
        {
            this.MoveIndex = moveIndex;
            this.MoveDirection = moveDirection;
        }
    }
}

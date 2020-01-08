
namespace SlidePuzzle
{
    /// <summary>
    /// ゲームの状態を表す列挙体
    /// </summary>
    public enum PuzzleState
    {
        WAIT, // 待機中
        PLAYING, // ゲームプレイ中
        STOP, // 一時停止中
        CLEAR, // ゲームクリア
        SHUFFLE // シャッフル中
    }
}

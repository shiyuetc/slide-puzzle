
namespace SlidePuzzle
{
    /// <summary>
    /// ゲームの状態を表す列挙体
    /// </summary>
    public enum PuzzleState
    {
        WAIT, // 待機中
        PLAYING, // プレイ中
        STOP, // 中止
        CLEAR, // クリア
        SHUFFLE // シャッフル中
    }
}


namespace SlidePuzzle
{
    public class MoveLog
    {
        public int MoveIndex { get; set; }

        public Direction MoveDirection { get; set; }

        public MoveLog(int moveIndex, Direction moveDirection)
        {
            this.MoveIndex = moveIndex;
            this.MoveDirection = moveDirection;
        }
    }
}

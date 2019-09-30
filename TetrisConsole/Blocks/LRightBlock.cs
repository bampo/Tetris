namespace TetrisConsole.Blocks
{
    public class LRightBlock : BlockBase
    {
        private static readonly int[,] _bricks =
        {
            {0, 0, 0, 1},
            {1, 1, 1, 1},
        };

        public LRightBlock() : base(_bricks, BrickColor.Blue)
        {
        }
    }
}
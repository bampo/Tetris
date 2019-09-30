namespace TetrisConsole.Blocks
{
    public class LineBlock : BlockBase
    {
        private static readonly int[,] _bricks =
        {
            {1, 1, 1, 1}
        };

        public LineBlock() : base(_bricks, BrickColor.Violet)
        {
        }
    }
}
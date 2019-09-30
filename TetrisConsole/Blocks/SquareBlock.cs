namespace TetrisConsole.Blocks
{
    public class SquareBlock : BlockBase
    {
        private static readonly int[,] _bricks =
        {
            {1, 1},
            {1, 1},
        };

        public SquareBlock() : base(_bricks, BrickColor.Yellow)
        {
        }
    }
}
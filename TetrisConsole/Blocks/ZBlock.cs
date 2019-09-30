namespace TetrisConsole.Blocks
{
    public class ZBlock : BlockBase
    {
        private static readonly int[,] _bricks =
        {
            {1, 1, 0},
            {0, 1, 1},
        };

        public ZBlock() : base(_bricks, BrickColor.Red)
        {
        }
    }
}
namespace TetrisConsole.Blocks
{
    public class ZRevrsBlock : BlockBase
    {
        private static readonly int[,] _bricks =
        {
            {0, 1, 1},
            {1, 1, 0},
        };

        public ZRevrsBlock() : base(_bricks, BrickColor.Green)
        {
        }
    }
}
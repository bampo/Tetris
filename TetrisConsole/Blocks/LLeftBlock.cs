namespace TetrisConsole.Blocks
{
    public class LLeftBlock : BlockBase
    {
        private static readonly int[,] bricks = new[,]
        {
            {1, 1, 1, 1},
            {0, 0, 0, 1},
        };

        public LLeftBlock() : base(bricks, BrickColor.Orange)
        {
        }
    }
}
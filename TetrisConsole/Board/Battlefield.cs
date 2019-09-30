using TetrisConsole.Blocks;

namespace TetrisConsole.Board
{
    public class Battlefield
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        private Field[,] board;
        public Battlefield(int height, int width)
        {
            Height = height;
            Width = width;
            CreateBoard();
        }

        private void ClearBoard()
        {
            foreach (var field in board)
            {
                field.Clear();
            }
        }

        private void CreateBoard()
        {
            board = new Field[Height,Width];
        }
    }
}
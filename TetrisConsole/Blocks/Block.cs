using System;

namespace TetrisConsole.Blocks
{
    public abstract class BlockBase
    {
        private int[,] _bricks;
        public int[,] Bricks => _bricks;
        

        public int Height => Bricks.GetLength(1);
        public int Width => Bricks.GetLength(0);

        public BlockBase(int[,] bricks, BrickColor color)
        {
            _bricks = bricks;
            Color = color;
        }

        public BrickColor Color { get; private set; }

        public void RotateClockwise()
        {
            _bricks = RotateMatrixClockwise(_bricks);
        }

        public void RotateAntiClockwise()
        {
            _bricks = RotateMatrixAntiClockwise(_bricks);
        }

        
        T[,] RotateMatrixAntiClockwise<T>(T[,] oldMatrix)
        {
            var newMatrix = new T[oldMatrix.GetLength(1), oldMatrix.GetLength(0)];
            int newColumn, newRow = 0;
            for (int oldColumn = oldMatrix.GetLength(1)-1 ; oldColumn >= 0; oldColumn--)
            {
                newColumn = 0;
                for (int oldRow = 0; oldRow < oldMatrix.GetLength(0); oldRow++)
                {
                    newMatrix[newRow, newColumn] = oldMatrix[oldRow, oldColumn];
                    newColumn++;
                }
                newRow++;
            }
            return newMatrix;
        }
        T[,] RotateMatrixClockwise<T>(T[,] oldMatrix)
        {
            var newMatrix = new T[oldMatrix.GetLength(1), oldMatrix.GetLength(0)];
            int newColumn, newRow = 0;
            for (int oldColumn = 0; oldColumn < oldMatrix.GetLength(1) ; oldColumn++)
            {
                newColumn = 0;
                for (int oldRow = oldMatrix.GetLength(0)-1; oldRow >= 0; oldRow--)
                {
                    newMatrix[newRow, newColumn] = oldMatrix[oldRow, oldColumn];
                    newColumn++;
                }
                newRow++;
            }
            return newMatrix;
        }

    }
}
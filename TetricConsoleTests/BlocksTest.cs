using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using TetrisConsole.Blocks;
using Xunit;
using Xunit.Abstractions;

namespace TetricConsoleTests
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _out;

        public UnitTest1(ITestOutputHelper @out)
        {
            _out = @out;
        }

        #region line

        [Fact]
        public void LineBlock_RotateClockws()
        {
            var lineBlock = new LineBlock();
            Print(lineBlock.Bricks);
            int[,] a = {{1, 1, 1, 1}};
            Assert.Equal(a, lineBlock.Bricks);

            lineBlock.RotateClockwise();
            Print(lineBlock.Bricks);
            a = new[,] {{1}, {1}, {1}, {1}};
            Assert.Equal(a, lineBlock.Bricks);

            lineBlock.RotateClockwise();
            Print(lineBlock.Bricks);
            a = new[,] {{1, 1, 1, 1}};
            Assert.Equal(a, lineBlock.Bricks);

            lineBlock.RotateClockwise();
            Print(lineBlock.Bricks);
            a = new[,] {{1}, {1}, {1}, {1}};
            Assert.Equal(a, lineBlock.Bricks);
        }

        [Fact]
        public void LineBlock_RotateAntiClockws()
        {
            var lineBlock = new LineBlock();
            Print(lineBlock.Bricks);
            int[,] a = {{1, 1, 1, 1}};
            Assert.Equal(a, lineBlock.Bricks);

            lineBlock.RotateAntiClockwise();
            Print(lineBlock.Bricks);
            a = new[,] {{1}, {1}, {1}, {1}};
            Assert.Equal(a, lineBlock.Bricks);

            lineBlock.RotateAntiClockwise();
            Print(lineBlock.Bricks);
            a = new[,] {{1, 1, 1, 1}};
            Assert.Equal(a, lineBlock.Bricks);

            lineBlock.RotateAntiClockwise();
            Print(lineBlock.Bricks);
            a = new[,] {{1}, {1}, {1}, {1}};
            Assert.Equal(a, lineBlock.Bricks);
        }

        #endregion

        #region LLeft

        [Fact]
        public void LLeftBlock_RotateClockws()
        {
            var block = new LLeftBlock();
            Print(block.Bricks);
            int[,] a =
            {
                {1, 1, 1, 1},
                {0, 0, 0, 1}
            };
            Assert.Equal(a, block.Bricks);

            block.RotateClockwise();
            Print(block.Bricks);
            a = new[,]
            {
                {0, 1},
                {0, 1},
                {0, 1},
                {1, 1},
            };
            Assert.Equal(a, block.Bricks);

            block.RotateClockwise();
            Print(block.Bricks);
            a = new[,]
            {
                {1, 0, 0, 0},
                {1, 1, 1, 1},
            };
            Assert.Equal(a, block.Bricks);

            block.RotateClockwise();
            Print(block.Bricks);
            a = new[,]
            {
                {1, 1},
                {1, 0},
                {1, 0},
                {1, 0},
            };
            Assert.Equal(a, block.Bricks);
        }

        [Fact]
        public void LLeftBlock_RotateAntiClockws()
        {
            var block = new LLeftBlock();
            Print(block.Bricks);
            int[,] a =
            {
                {1, 1, 1, 1},
                {0, 0, 0, 1}
            };
            Assert.Equal(a, block.Bricks);

            block.RotateAntiClockwise();
            Print(block.Bricks);
            a = new[,]
            {
                {1, 1},
                {1, 0},
                {1, 0},
                {1, 0},
            };
            Assert.Equal(a, block.Bricks);

            block.RotateAntiClockwise();
            Print(block.Bricks);
            a = new[,]
            {
                {1, 0, 0, 0},
                {1, 1, 1, 1},
            };
            Assert.Equal(a, block.Bricks);

            block.RotateAntiClockwise();
            Print(block.Bricks);
            a = new[,]
            {
                {0, 1},
                {0, 1},
                {0, 1},
                {1, 1},
            };
            Assert.Equal(a, block.Bricks);
        }

        #endregion

        #region LRight

        [Fact]
        public void LRightBlock_RotateClockws()
        {
            var block = new LRightBlock();
            Print(block.Bricks);
            int[,] a =
            {
                {0, 0, 0, 1},
                {1, 1, 1, 1},
            };
            Assert.Equal(a, block.Bricks);

            block.RotateClockwise();
            Print(block.Bricks);
            a = new[,]
            {
                {1, 0,},
                {1, 0,},
                {1, 0,},
                {1, 1,},
            };
            Assert.Equal(a, block.Bricks);

            block.RotateClockwise();
            Print(block.Bricks);
            a = new[,]
            {
                {1, 1, 1, 1},
                {1, 0, 0, 0},
            };
            Assert.Equal(a, block.Bricks);

            block.RotateClockwise();
            Print(block.Bricks);
            a = new[,]
            {
                {1, 1},
                {0, 1},
                {0, 1},
                {0, 1},
            };
            Assert.Equal(a, block.Bricks);
        }

        [Fact]
        public void LRightBlock_RotateAntiClockws()
        {
            var block = new LRightBlock();
            Print(block.Bricks);
            int[,] a =
            {
                {0, 0, 0, 1},
                {1, 1, 1, 1},
            };
            Assert.Equal(a, block.Bricks);

            block.RotateAntiClockwise();
            Print(block.Bricks);
            a = new[,]
            {
                {1, 1},
                {0, 1},
                {0, 1},
                {0, 1},
            };
            Assert.Equal(a, block.Bricks);

            block.RotateAntiClockwise();
            Print(block.Bricks);
            a = new[,]
            {
                {1, 1, 1, 1},
                {1, 0, 0, 0},
            };
            Assert.Equal(a, block.Bricks);

            block.RotateAntiClockwise();
            Print(block.Bricks);
            a = new[,]
            {
                {1, 0,},
                {1, 0,},
                {1, 0,},
                {1, 1,},
            };
            Assert.Equal(a, block.Bricks);
        }

        #endregion

        private void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                var line = "";
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    line += array[i, k] + " ";
                }

                _out.WriteLine(line);
            }

            _out.WriteLine("");
        }
    }
}
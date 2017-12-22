using System;

namespace GameOfLife.Core.DomainObjects
{
    public class Cell
    {
        private int _x;
        private int _y;

        public Cell(int x, int y)
        {
            if (x < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(x)} should be positive");
            }

            if (y < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(y)} should be positive");
            }

            _x = x;
            _y = y;
        }
    }
}

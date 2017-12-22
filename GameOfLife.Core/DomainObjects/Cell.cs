using System;
using System.Windows;

namespace GameOfLife.Core.DomainObjects
{
    public class Cell
    {
        private readonly int _x;
        private readonly int _y;

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

        public int X => _x;

        public int Y => _y;

        public bool IsAlive()
        {
            return (_x + _y ) % 3 == 0;
        }
    }
}

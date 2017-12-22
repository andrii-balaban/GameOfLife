using System;

namespace GameOfLife.Core.DomainObjects
{
    public class World
    {
        private readonly int _size;

        private Cell[,] _field;

        public World(int size)
        {
            if (size < 100)
            {
                throw new ArgumentOutOfRangeException($"{nameof(size)} should be greater then 100 units");
            }

            _size = size;
        }

        public void Initialize()
        {
            _field = new Cell[_size, _size];

            for (int xIndex = 0; xIndex < _size; xIndex++)
            {
                for (int yIndex = 0; yIndex < _size; yIndex++)
                {
                    _field[xIndex, yIndex] = new Cell(xIndex, yIndex);
                }
            }
        }

        public Cell[,] GetFiled() => _field;

        public int GetHeight()
        {
            return _size;
        }

        public int GetWidth()
        {
            return GetHeight();
        }
    }
}
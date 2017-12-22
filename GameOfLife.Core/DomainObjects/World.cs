using System;

namespace GameOfLife.Core.DomainObjects
{
    public class World
    {
        private readonly int _heightInUnits;
        private readonly int _widthInUnits;

        public World(int heightInUnits, int widthInUnits)
        {
            if (heightInUnits < 100)
            {
                throw new ArgumentOutOfRangeException($"{nameof(heightInUnits)} should be greater then 100 units");
            }

            if (_widthInUnits < 100)
            {
                throw new ArgumentOutOfRangeException($"{nameof(widthInUnits)} should be greater then 100 units");
            }

            _heightInUnits = heightInUnits;
            _widthInUnits = widthInUnits;
        }
    }
}
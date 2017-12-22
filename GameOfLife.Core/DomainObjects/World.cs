using System;

namespace GameOfLife.Core.DomainObjects
{
    public class World
    {
        private readonly int _heightInUnits;

        public World(int heightInUnits)
        {
            if (heightInUnits < 100)
            {
                throw new ArgumentOutOfRangeException($"{nameof(heightInUnits)} should be greater then 100 units");
            }
            _heightInUnits = heightInUnits;
        }

        public int GetHeight()
        {
            return _heightInUnits;
        }

        public int GetWidth()
        {
            return GetHeight();
        }
    }
}
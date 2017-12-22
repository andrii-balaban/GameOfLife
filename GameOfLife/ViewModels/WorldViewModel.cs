using System;
using GameOfLife.Core.DomainObjects;

namespace GameOfLife.ViewModels
{
    public class WorldViewModel
    {
        private const int DefaultCellSize = 2;
        private readonly World _world;

        public WorldViewModel(World world)
        {
            _world = world ?? throw new ArgumentNullException(nameof(world));
        }

        public int Height => _world.GetHeight() * DefaultCellSize;

        public int Width => _world.GetWidth() * DefaultCellSize;
    }
}

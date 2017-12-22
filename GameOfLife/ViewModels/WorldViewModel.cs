using System;
using GameOfLife.Core.DomainObjects;

namespace GameOfLife.ViewModels
{
    public class WorldViewModel
    {
        private World _world;

        public WorldViewModel(World world)
        {
            _world = world ?? throw new ArgumentNullException(nameof(world));
        }

        public int Height => _world.GetHeight();

        public int Width => _world.GetWidth();
    }
}

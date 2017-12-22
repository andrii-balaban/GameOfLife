using System;
using GameOfLife.Core.DomainObjects;

namespace GameOfLife.ViewModels
{
    public class WorldViewModel
    {
        private const int DefaultCellSize = 3;
        private readonly World _world;
        private readonly IWorldView _worldView;

        public WorldViewModel(World world, IWorldView view)
        {
            _worldView = view;
            _world = world ?? throw new ArgumentNullException(nameof(world));

            _worldView.Draw(_world);
        }

        public int Height => _world.GetHeight() * DefaultCellSize;

        public int Width => _world.GetWidth() * DefaultCellSize;

        public World GetWorld()
        {
            return _world;
        }
    }
}

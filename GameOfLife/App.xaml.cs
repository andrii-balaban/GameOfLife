using System.Windows;
using GameOfLife.Core.DomainObjects;
using Unity;

namespace GameOfLife
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IUnityContainer _container;

        public App()
        {
            _container = new Bootstrapper().Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var worldView = _container.Resolve<IWorldView>();

            World world = new World(300);
            world.Initialize();

            worldView.SetupWorld(world);

            worldView.Run();

            base.OnStartup(e);
        }
    }
}

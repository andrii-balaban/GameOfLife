using Unity;

namespace GameOfLife
{
    public class Bootstrapper
    {
        public IUnityContainer Run()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IWorldView, MainWindow>();

            return container;
        }
    }
}

using GameOfLife.Core.DomainObjects;

namespace GameOfLife
{
    public interface IWorldView
    {
        void SetupWorld(World world);

        void Run();

        void Draw(World world);
    }
}
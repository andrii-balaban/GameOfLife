using System;
using FluentAssertions;
using GameOfLife.Core.DomainObjects;
using GameOfLife.ViewModels;
using NUnit.Framework;

namespace GameOfLife.UnitTests
{
    [TestFixture]
    public class WorldViewModelTests
    {
        [Test]
        public void Ctor_ShouldNotThrowException()
        {
            // Arrange
            World world = CreateWorld();

            // Act
            Action act = () => CreateWorldViewModel(world);

            // Assert
            act.ShouldNotThrow();
        }

        [Test]
        public void Ctor_WhenWorldArgumentUsNull_ShouldThrowArgumentNullException()
        {
            // Arrange
            World world = null;

            // Act
            Action act = () => CreateWorldViewModel(world);

            // Assert
            act.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void Height_ShouldReturnWorldHeight()
        {
            // Arrange
            World world = CreateWorld();
            WorldViewModel viewModel = CreateWorldViewModel(world);

            // Act
            int height = viewModel.Height;

            // Assert
            height.Should().Be(300);
        }

        [Test]
        public void Width_ShouldReturnWorldWidth()
        {
            // Arrange
            World world = CreateWorld();
            WorldViewModel viewModel = CreateWorldViewModel(world);

            // Act
            int width = viewModel.Width;

            // Assert
            width.Should().Be(300);
        }

        private static World CreateWorld()
        {
            return new World(100);
        }


        private static WorldViewModel CreateWorldViewModel(World world)
        {
            return new WorldViewModel(world, new TestView());
        }

        private class TestView : IWorldView
        {
            public void SetupWorld(World world)
            {
                
            }

            public void Run()
            {
               
            }

            public void Draw(World world)
            {
                
            }
        }
    }
}

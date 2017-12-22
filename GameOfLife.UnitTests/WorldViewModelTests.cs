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
            Action act = () => new WorldViewModel(world);

            // Assert
            act.ShouldNotThrow();
        }

        [Test]
        public void Ctor_WhenWorldArgumentUsNull_ShouldThrowArgumentNullException()
        {
            // Arrange
            World world = null;

            // Act
            Action act = () => new WorldViewModel(world);

            // Assert
            act.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void Height_ShouldReturnWorldHeight()
        {
            // Arrange
            World world = CreateWorld();
            WorldViewModel viewModel = new WorldViewModel(world);

            // Act
            int height = viewModel.Height;

            // Assert
            height.Should().Be(200);
        }

        [Test]
        public void Width_ShouldReturnWorldWidth()
        {
            // Arrange
            World world = CreateWorld();
            WorldViewModel viewModel = new WorldViewModel(world);

            // Act
            int width = viewModel.Width;

            // Assert
            width.Should().Be(200);
        }

        private static World CreateWorld()
        {
            return new World(100);
        }
    }
}

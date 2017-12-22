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
            World world = new World(100, 100);

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
            World world = new World(100, 200);
            WorldViewModel viewModel = new WorldViewModel(world);

            // Act
            int height = viewModel.Height;

            // Assert
            height.Should().Be(100);
        }

        [Test]
        public void Width_ShouldReturnWorldWidth()
        {
            // Arrange
            World world = new World(100, 200);
            WorldViewModel viewModel = new WorldViewModel(world);

            // Act
            int width = viewModel.Width;

            // Assert
            width.Should().Be(200);
        }
    }
}

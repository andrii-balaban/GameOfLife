using System;
using FluentAssertions;
using GameOfLife.Core.DomainObjects;
using NUnit.Framework;

namespace GameOfLife.UnitTests
{
    [TestFixture]
    public class CellTests
    {
        [Test]
        public void Ctor_ShouldNotThrowException()
        {
            // Arrange

            // Act
            Action act = () => new Cell(0, 0);

            // Assert
            act.ShouldNotThrow();
        }

        [Test]
        public void Ctor_WhenXLessThenZero_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            
            // Act
            Action act = () => new Cell(-1, 5);

            // Assert
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Ctor_WhenYLessThenZero_ShouldthrowArgumentOutOfRangeException()
        {
            // Arrange
            
            // Act
            Action act = () => new Cell(5, -1);

            // Assert
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }
    }
}

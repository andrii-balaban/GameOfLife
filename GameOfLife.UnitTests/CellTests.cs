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
            Action act = () => new Cell();

            // Assert
            act.ShouldNotThrow();
        }
    }
}

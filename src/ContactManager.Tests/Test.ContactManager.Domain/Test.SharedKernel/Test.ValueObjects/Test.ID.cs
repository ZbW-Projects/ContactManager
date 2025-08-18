using ContactManager.Domain.SharedKernel.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContactManager.Tests.Domain.SharedKernel.ValueObjects
{
    [TestClass]
    public class TestID
    {
        [TestMethod]
        public void Constructor_ValidPositiveInt_ShouldSetValue()
        {
            // Act
            var id = new ID(1);

            // Assert
            Assert.AreEqual(1, id.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_Zero_ShouldThrowException()
        {
            // Act
            var id = new ID(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_Negative_ShouldThrowException()
        {
            // Act
            var id = new ID(-5);
        }

        [TestMethod]
        public void Create_ShouldReturnEquivalentID()
        {
            // Act
            var id1 = ID.Create(10);
            var id2 = new ID(10);

            // Assert
            Assert.AreEqual(id1, id2);
            Assert.AreEqual(10, id1.Value);
        }

        [TestMethod]
        public void Equals_SameValue_ShouldBeEqual()
        {
            // Arrange
            var id1 = new ID(42);
            var id2 = new ID(42);

            // Assert
            Assert.AreEqual(id1, id2);
            Assert.AreEqual(id1.Value, id2.Value);
        }
    }
}

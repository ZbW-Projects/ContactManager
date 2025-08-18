using ContactManager.Domain.Contact.BoundedContext.Person;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContactManager.Tests.Domain.Contact.BoundedContext.Person
{
    [TestClass]
    public class DegreeOfEmploymentTests
    {
        [TestMethod]
        public void Create_ValidValue_ShouldSetValue()
        {
            // Arrange
            int value = 80;

            // Act
            var degree = DegreeOfEmployment.Create(value);

            // Assert
            Assert.AreEqual(value, degree.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_LessThan10_ShouldThrow()
        {
            _ = DegreeOfEmployment.Create(5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_GreaterThan100_ShouldThrow()
        {
            _ = DegreeOfEmployment.Create(120);
        }

        [TestMethod]
        public void ToString_Returns_PercentString()
        {
            var degree = DegreeOfEmployment.Create(60);
            Assert.AreEqual("60%", degree.ToString());
        }

        [TestMethod]
        public void Equality_TwoSameValues_ShouldBeEqual()
        {
            var d1 = DegreeOfEmployment.Create(100);
            var d2 = DegreeOfEmployment.Create(100);

            Assert.AreEqual(d1, d2);
            Assert.IsTrue(d1.Equals(d2));
            Assert.AreEqual(d1.GetHashCode(), d2.GetHashCode());
        }

        [TestMethod]
        public void Equality_DifferentValues_ShouldNotBeEqual()
        {
            var d1 = DegreeOfEmployment.Create(50);
            var d2 = DegreeOfEmployment.Create(90);

            Assert.AreNotEqual(d1, d2);
            Assert.IsFalse(d1.Equals(d2));
        }
    }
}

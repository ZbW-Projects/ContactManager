using ContactManager.Domain.SharedKernel.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContactManager.Tests.Domain.SharedKernel.ValueObjects
{
    [TestClass]
    public class TestAddress
    {
        [TestMethod]
        public void Constructor_ValidData_ShouldSetProperties()
        {
            // Arrange
            string street = "Beispielstrasse";
            string houseNumber = "4";
            string zipCode = "8543";
            string city = "Dietikon";
            string state = "Zürich";
            string country = "Schweiz";

            // Act
            var address = new Address(street, houseNumber, zipCode, city, state, country);

            // Assert
            Assert.AreEqual(street, address.Street);
            Assert.AreEqual(houseNumber, address.HouseNumber);
            Assert.AreEqual(zipCode, address.ZipCode);
            Assert.AreEqual("Dietikon", address.City);  // capitalized
            Assert.AreEqual("Zürich", address.State);   // capitalized
            Assert.AreEqual("Schweiz", address.Country); // capitalized
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_EmptyStreet_ShouldThrowException()
        {
            new Address("", "4", "8543", "Dietikon", "Zürich", "Schweiz");
        }

        [TestMethod]
        public void ToString_ShouldReturnFormattedAddress()
        {
            // Arrange
            var address = new Address("Beispielstrasse", "4", "8543", "Dietikon", "Zürich", "Schweiz");

            // Act
            var result = address.ToString();

            // Assert
            Assert.AreEqual("Beispielstrasse 4, 8543 Dietikon, Zürich", result);
        }

        [TestMethod]
        public void Equals_SameValues_ShouldBeEqual()
        {
            // Arrange
            var addr1 = new Address("Beispielstrasse", "4", "8543", "Dietikon", "Zürich", "Schweiz");
            var addr2 = new Address("Beispielstrasse", "4", "8543", "Dietikon", "Zürich", "Schweiz");

            // Act & Assert
            Assert.AreEqual(addr1, addr2);
            Assert.IsTrue(addr1.Equals(addr2));
        }

        [TestMethod]
        public void Equals_DifferentValues_ShouldNotBeEqual()
        {
            // Arrange
            var addr1 = new Address("Beispielstrasse", "4", "8543", "Dietikon", "Zürich", "Schweiz");
            var addr2 = new Address("AndereStrasse", "5", "8000", "Zürich", "Zürich", "Schweiz");

            // Act & Assert
            Assert.AreNotEqual(addr1, addr2);
        }
    }
}

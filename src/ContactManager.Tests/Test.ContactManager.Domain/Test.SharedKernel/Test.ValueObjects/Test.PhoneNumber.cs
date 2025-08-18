using ContactManager.Domain.SharedKernel.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContactManager.Tests.Domain.SharedKernel.ValueObjects
{
    [TestClass]
    public class TestPhoneNumber
    {
        [TestMethod]
        public void Constructor_ValidSwissNumber_ShouldNormalizeToE164()
        {
            // Arrange
            var input = "078 123 45 67";    // CH-Mobile format

            // Act
            var phone = new PhoneNumber(input, "CH");

            // Assert
            Assert.AreEqual("+41781234567", phone.Value);
        }

        [TestMethod]
        public void Constructor_InternationalFormat_ShouldIgnoreRegionAndKeepE164()
        {
            // Arrange
            var input = "+41 78 123 45 67";

            // Act
            var phone = new PhoneNumber(input, "US"); // Region egal, da schon international

            // Assert
            Assert.AreEqual("+41781234567", phone.Value);
        }

        [TestMethod]
        public void Constructor_ValidGermanNumber_ShouldNormalizeToE164()
        {
            // Arrange
            var input = "0151 12345678";

            // Act
            var phone = new PhoneNumber(input, "DE");

            // Assert
            Assert.AreEqual("+4915112345678", phone.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_InvalidNumber_ShouldThrowArgumentException()
        {
            // Act
            _ = new PhoneNumber("12345", "CH"); // zu kurz/ungültig
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_MalformedNumber_ShouldThrowArgumentException()
        {
            // Act
            _ = new PhoneNumber("abc-def-gh", "CH");
        }

        [TestMethod]
        public void Equals_SameNumberDifferentFormats_ShouldBeEqual()
        {
            // Arrange
            var p1 = new PhoneNumber("+41791234567");     // E.164
            var p2 = new PhoneNumber("079 123 45 67", "CH"); // nationale Schreibweise

            // Assert
            Assert.AreEqual(p1, p2);
            Assert.AreEqual(p1.Value, p2.Value);
        }

        [TestMethod]
        public void Factory_Create_ShouldReturnEquivalentInstance()
        {
            // Act
            var p1 = PhoneNumber.Create("079 123 45 67", "CH");
            var p2 = new PhoneNumber("0791234567", "CH");

            // Assert
            Assert.AreEqual(p1, p2);
            Assert.AreEqual("+41791234567", p1.Value);
        }
    }
}

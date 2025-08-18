using System;
using ContactManager.Domain.Contact.BoundedContext.Person.PersonalData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactManager.Tests.Domain.ValueObjects
{
    [TestClass]
    public class AHVNumberTests
    {
        // Gültiges, von dir genanntes Beispiel mit korrekter Prüfsumme
        private const string ValidFormatted = "756.9217.0769.85";

        [TestMethod]
        public void Create_ValidFormattedString_ShouldReturnSameFormattedValue()
        {
            // Act
            var ahv = AHVNumber.Create(ValidFormatted);

            // Assert
            Assert.AreEqual(ValidFormatted, ahv.Value);
        }

        [TestMethod]
        public void Create_ValidWithSpaces_ShouldNormalizeAndReturnFormatted()
        {
            // Arrange
            var raw = "756 9217 0769 85";

            // Act
            var ahv = AHVNumber.Create(raw);

            // Assert
            Assert.AreEqual(ValidFormatted, ahv.Value);
        }

        [TestMethod]
        public void Create_ValidWithDashes_ShouldNormalizeAndReturnFormatted()
        {
            // Arrange
            var raw = "756-9217-0769-85";

            // Act
            var ahv = AHVNumber.Create(raw);

            // Assert
            Assert.AreEqual(ValidFormatted, ahv.Value);
        }

        [TestMethod]
        public void Create_ValidDigitsOnly_ShouldFormatCorrectly()
        {
            // Arrange
            var raw = "7569217076985";

            // Act
            var ahv = AHVNumber.Create(raw);

            // Assert
            Assert.AreEqual(ValidFormatted, ahv.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_WrongPrefix_ShouldThrow()
        {
            // 123… statt 756…
            AHVNumber.Create("123.9217.0769.85");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_WrongLength_ShouldThrow()
        {
            // eine Ziffer zu wenig
            AHVNumber.Create("756.9217.0769.8");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_ContainsNonDigits_ShouldThrow()
        {
            AHVNumber.Create("756.9217.076X.85");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_InvalidChecksum_ShouldThrow()
        {
            // letzte Ziffer manipuliert → Prüfsumme passt nicht mehr
            AHVNumber.Create("756.9217.0769.84");
        }

        [TestMethod]
        public void Equals_SameNumberDifferentFormatting_ShouldBeEqualByValue()
        {
            var a = AHVNumber.Create("7569217076985");
            var b = AHVNumber.Create("756.9217.0769.85");

            // Falls SingleValueObject Equals() implementiert: Assert.AreEqual(a, b);
            // sicher ist immer: Value vergleichen
            Assert.AreEqual(a.Value, b.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Create_Null_ShouldThrowArgumentNullException()
        {
            // HINWEIS:
            // Damit dieser Test grün wird, sollte in Normalize()
            // vor value.Replace(...) ein Null-Check ergänzt werden:
            // if (value is null) throw new ArgumentNullException(nameof(value));
            AHVNumber.Create(null);
        }
    }
}

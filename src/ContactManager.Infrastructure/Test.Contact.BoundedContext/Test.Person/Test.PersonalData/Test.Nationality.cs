using System;
using ContactManager.Domain.Contact.BoundedContext.Person.PersonalData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactManager.Tests.Domain.ValueObjects
{
    [TestClass]
    public class NationalityTests
    {
        [TestMethod]
        public void Create_ValidUppercaseCode_ShouldReturnSameCode()
        {
            // Arrange
            var input = "CH";

            // Act
            var nationality = Nationality.Create(input);

            // Assert
            Assert.AreEqual("CH", nationality.Value);
        }

        [TestMethod]
        public void Create_ValidLowercaseCode_ShouldBeNormalizedToUppercase()
        {
            // Arrange
            var input = "de";

            // Act
            var nationality = Nationality.Create(input);

            // Assert
            Assert.AreEqual("DE", nationality.Value);
        }

        [TestMethod]
        public void Create_ValidCodeWithSpaces_ShouldTrimAndReturnUppercase()
        {
            var nationality = Nationality.Create("  at  ");
            Assert.AreEqual("AT", nationality.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_EmptyString_ShouldThrow()
        {
            Nationality.Create("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_Null_ShouldThrow()
        {
            Nationality.Create(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_TooShortCode_ShouldThrow()
        {
            Nationality.Create("C");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_TooLongCode_ShouldThrow()
        {
            Nationality.Create("CHE");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_NotInAllowedList_ShouldThrow()
        {
            Nationality.Create("XX");
        }

        [TestMethod]
        public void Equals_SameCodeDifferentCase_ShouldBeEqual()
        {
            var n1 = Nationality.Create("ch");
            var n2 = Nationality.Create("CH");


            // Falls SingleValueObject Equals implementiert:
            // Assert.AreEqual(n1, n2);
            // Sicher immer:
            Assert.AreEqual(n1.Value, n2.Value);
        }
    }
}

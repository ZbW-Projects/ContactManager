using ContactManager.Domain.Contact.BoundedContext.Person;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContactManager.Tests.Domain.Contact.BoundedContext.Person
{
    [TestClass]
    public class NameTests
    {
        [TestMethod]
        public void Create_ValidValues_ShouldSetProperties()
        {
            var name = Name.Create("Max", "Mustermann");

            Assert.AreEqual("Max", name.SurName);
            Assert.AreEqual("Mustermann", name.LastName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_EmptySurname_ShouldThrow()
        {
            Name.Create("", "Mustermann");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_EmptyLastname_ShouldThrow()
        {
            Name.Create("Max", "");
        }

        [TestMethod]
        public void Create_WithSpaces_ShouldTrimValues()
        {
            var name = Name.Create("  Max  ", "  Mustermann  ");

            Assert.AreEqual("Max", name.SurName);
            Assert.AreEqual("Mustermann", name.LastName);
        }

        [TestMethod]
        public void Equality_SameNamesDifferentCase_ShouldBeEqual()
        {
            var a = Name.Create("max", "mustermann");
            var b = Name.Create("MAX", "MUSTERmann");

            Assert.AreEqual(a, b);
            Assert.IsTrue(a.Equals(b));
            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }

        [TestMethod]
        public void Equality_DifferentNames_ShouldNotBeEqual()
        {
            var a = Name.Create("Max", "Mustermann");
            var b = Name.Create("Moritz", "Mustermann");

            Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        public void ToString_ShouldFormatCorrectly()
        {
            var name = Name.Create("Max", "Mustermann");
            Assert.AreEqual("Max Mustermann", name.ToString());
        }
    }
}

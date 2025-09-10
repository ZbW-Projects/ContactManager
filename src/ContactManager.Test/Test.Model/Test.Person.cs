using System;
using ContactManager.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactManager.Test.Core.Model
{
    [TestClass]
    public class TestPerson
    {
        private class TestablePerson : Person { } // Hilfsklasse für Tests

        [TestMethod]
        public void Salutation_ShouldBeNormalized()
        {
            var p = new TestablePerson();
            p.Salutation = "herr";
            Assert.AreEqual("Herr", p.Salutation);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FirstName_WhenEmpty_ShouldThrowException()
        {
            var p = new TestablePerson();
            p.FirstName = "";
        }

        [TestMethod]
        public void LastName_ShouldBeNormalized()
        {
            var p = new TestablePerson();
            p.LastName = "muster";
            Assert.AreEqual("Muster", p.LastName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DateOfBirth_InFuture_ShouldThrowException()
        {
            var p = new TestablePerson();
            p.DateOfBirth = DateTime.Now.AddDays(1);
        }

        [TestMethod]
        public void EmailPrivat_ValidEmail_ShouldBeAccepted()
        {
            var p = new TestablePerson();
            p.EmailPrivat = "test@example.com";
            Assert.AreEqual("test@example.com", p.EmailPrivat);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmailPrivat_Invalid_ShouldThrowException()
        {
            var p = new TestablePerson();
            p.EmailPrivat = "not-an-email";
        }

        [TestMethod]
        public void SocialSecurityNumber_ShouldNormalize()
        {
            var p = new TestablePerson();
            p.SocialSecurityNumber = "756.9217.0769.85"; // gültige AHV
            Assert.IsTrue(p.SocialSecurityNumber.StartsWith("756."));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SocialSecurityNumber_Invalid_ShouldThrowException()
        {
            var p = new TestablePerson();
            p.SocialSecurityNumber = "123.4567.8901.23"; // ungültige AHV
        }

        [TestMethod]
        public void PhoneNumberPrivate_Valid_ShouldBeNormalized()
        {
            var p = new TestablePerson();
            p.PhoneNumberPrivate = "+41791234567";
            Assert.IsTrue(p.PhoneNumberPrivate.StartsWith("+41"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PhoneNumberPrivate_Invalid_ShouldThrowException()
        {
            var p = new TestablePerson();
            p.PhoneNumberPrivate = "12345";
        }

        [TestMethod]
        public void Type_ShouldNormalize()
        {
            var p = new TestablePerson();
            p.Type = "kunde";
            Assert.AreEqual("Kunde", p.Type);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Type_WhenEmpty_ShouldThrowException()
        {
            var p = new TestablePerson();
            p.Type = "";
        }
    }
}

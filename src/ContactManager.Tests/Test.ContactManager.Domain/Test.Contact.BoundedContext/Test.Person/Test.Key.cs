using ContactManager.Domain.Contact.BoundedContext.Person;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactManager.Tests.Domain.Contact.BoundedContext.Person
{
    [TestClass]
    public class KeyTests
    {
        [TestMethod]
        public void ForWorkerOrTrainee_ShouldSetAhvNumber()
        {
            var key = Key.ForWorkerOrTrainee("756.1234.5678.90");

            Assert.AreEqual("756.1234.5678.90", key.AhvNumber);
            Assert.IsNull(key.FirstName);
            Assert.IsNull(key.LastName);
            Assert.IsNull(key.Email);
            Assert.AreEqual("AHV:756.1234.5678.90", key.ToString());
        }

        [TestMethod]
        public void ForCustomer_ShouldSetAllValues()
        {
            var key = Key.ForCustomer("John", "Doe", "John.Doe@example.com");

            Assert.IsNull(key.AhvNumber);
            Assert.AreEqual("John", key.FirstName);
            Assert.AreEqual("Doe", key.LastName);
            Assert.AreEqual("john.doe@example.com", key.Email); // Lowercased
            Assert.AreEqual("John Doe <john.doe@example.com>", key.ToString());
        }

        [TestMethod]
        public void Normalize_ShouldTrimAndLowerCaseEmail()
        {
            var key = Key.ForCustomer("  John  ", "  Doe  ", "   TEST@MAIL.COM   ");

            Assert.AreEqual("John", key.FirstName);
            Assert.AreEqual("Doe", key.LastName);
            Assert.AreEqual("test@mail.com", key.Email);
        }

        [TestMethod]
        public void Equality_SameCustomerData_ShouldBeEqual()
        {
            var k1 = Key.ForCustomer("Alice", "Smith", "alice@example.com");
            var k2 = Key.ForCustomer("Alice", "Smith", "Alice@Example.com");

            Assert.AreEqual(k1, k2);
            Assert.IsTrue(k1.Equals(k2));
        }

        [TestMethod]
        public void Equality_DifferentData_ShouldNotBeEqual()
        {
            var k1 = Key.ForWorkerOrTrainee("756.1111.2222.33");
            var k2 = Key.ForWorkerOrTrainee("756.9999.8888.77");

            Assert.AreNotEqual(k1, k2);
        }

        [TestMethod]
        public void ToString_ForCustomer_ShouldReturnFormattedString()
        {
            var key = Key.ForCustomer("Jane", "Doe", "jane.doe@example.com");
            Assert.AreEqual("Jane Doe <jane.doe@example.com>", key.ToString());
        }
    }
}

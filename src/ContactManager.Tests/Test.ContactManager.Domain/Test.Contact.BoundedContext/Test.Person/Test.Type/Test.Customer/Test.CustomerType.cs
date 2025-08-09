using ContactManager.Domain.Contact.BoundedContext.Person.Type.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Tests.Test.ContactManager.Domain.Test.Contact.BoundedContext.Test.Person.Test.Type.Test.Customer
{
    [TestClass]
    public class CustomerTypeTests
    {
        [TestMethod]
        public void List_ShouldReturnAllCustomerTypes()
        {
            // Act
            var all = CustomerType.List().ToList();

            // Assert
            Assert.AreEqual(5, all.Count);
            CollectionAssert.Contains(all, CustomerType.A);
            CollectionAssert.Contains(all, CustomerType.B);
            CollectionAssert.Contains(all, CustomerType.C);
            CollectionAssert.Contains(all, CustomerType.D);
            CollectionAssert.Contains(all, CustomerType.E);
        }

        [TestMethod]
        public void FromName_ShouldBeCaseInsensitive()
        {
            var c1 = CustomerType.FromName("a");
            var c2 = CustomerType.FromName("A");
            var c3 = CustomerType.FromName("a ");

            Assert.AreSame(CustomerType.A, c1);
            Assert.AreSame(CustomerType.A, c2);
            Assert.AreSame(CustomerType.A, c3);
        }

        [TestMethod]
        public void FromId_ShouldReturnCorrectInstance()
        {
            var typeB = CustomerType.FromId(CustomerType.B.Id);
            Assert.AreSame(CustomerType.B, typeB);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromName_Invalid_ShouldThrow()
        {
            _ = CustomerType.FromName("InvalidType");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromId_Invalid_ShouldThrow()
        {
            _ = CustomerType.FromId(999);
        }

        [TestMethod]
        public void Equals_ShouldCompareByTypeAndId()
        {
            Assert.IsTrue(CustomerType.C.Equals(CustomerType.C));
            Assert.IsFalse(CustomerType.C.Equals(CustomerType.D));
        }

        [TestMethod]
        public void CompareTo_ShouldOrderById()
        {
            Assert.IsTrue(CustomerType.A.CompareTo(CustomerType.B) < 0);
            Assert.IsTrue(CustomerType.E.CompareTo(CustomerType.D) > 0);
            Assert.AreEqual(0, CustomerType.A.CompareTo(CustomerType.A));
        }

        [TestMethod]
        public void ToString_ShouldReturnName()
        {
            Assert.AreEqual("A", CustomerType.A.ToString());
            Assert.AreEqual("B", CustomerType.B.ToString());
            Assert.AreEqual("C", CustomerType.C.ToString());
            Assert.AreEqual("D", CustomerType.D.ToString());
            Assert.AreEqual("E", CustomerType.E.ToString());
        }

        [TestMethod]
        public void HelperMethods_ShouldWork()
        {
            Assert.IsTrue(CustomerType.A.IsCustomerTypeA());
            Assert.IsTrue(CustomerType.B.IsCustomerTypeB());
            Assert.IsTrue(CustomerType.C.IsCustomerTypeC());
            Assert.IsTrue(CustomerType.D.IsCustomerTypeD());
            Assert.IsTrue(CustomerType.E.IsCustomerTypeE());
        }
    }
}

using ContactManager.Domain.Contact.BoundedContext.Person;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContactManager.Tests.Domain.Contact.BoundedContext.Person
{
    [TestClass]
    public class DepartmentTests
    {
        [TestMethod]
        public void FromId_ValidId_ShouldReturnCorrectDepartment()
        {
            var department = Department.FromId(3);
            Assert.AreEqual(Department.IT, department);
            Assert.AreEqual("IT", department.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromId_InvalidId_ShouldThrow()
        {
            _ = Department.FromId(99);
        }

        [TestMethod]
        public void FromName_ValidName_ShouldReturnCorrectDepartment()
        {
            var department = Department.FromName("Finance");
            Assert.AreEqual(Department.Finance, department);
            Assert.AreEqual(2, department.Id);
        }

        [TestMethod]
        public void FromName_ValidNameIgnoreCase_ShouldReturnCorrectDepartment()
        {
            var department = Department.FromName("sales");
            Assert.AreEqual(Department.Sales, department);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromName_InvalidName_ShouldThrow()
        {
            _ = Department.FromName("Unknown");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromName_Empty_ShouldThrow()
        {
            _ = Department.FromName("   ");
        }

        [TestMethod]
        public void IsMethods_ShouldReturnTrueForCorrectDepartment()
        {
            Assert.IsTrue(Department.HumanResources.IsHumanResources());
            Assert.IsTrue(Department.Finance.IsFinance());
            Assert.IsTrue(Department.IT.IsIT());
            Assert.IsTrue(Department.Sales.IsSales());
            Assert.IsTrue(Department.Marketing.IsMarketing());
            Assert.IsTrue(Department.Logistic.IsLogistic());
        }

        [TestMethod]
        public void Equality_SameDepartment_ShouldBeEqual()
        {
            var d1 = Department.FromId(1);
            var d2 = Department.FromName("Human Resources");

            Assert.AreEqual(d1, d2);
            Assert.IsTrue(d1.Equals(d2));
        }

        [TestMethod]
        public void Equality_DifferentDepartments_ShouldNotBeEqual()
        {
            var d1 = Department.HumanResources;
            var d2 = Department.IT;

            Assert.AreNotEqual(d1, d2);
        }
    }
}

using System;
using ContactManager.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactManager.Test.Core.Model
{
    [TestClass]
    public class TestEmployee
    {
        [TestMethod]
        public void Constructor_WithPrefixAndNumber_ShouldFormatEmployeeNumber()
        {
            // Act
            var employee = new Employee("E", 42);

            // Assert
            Assert.AreEqual("E-00042", employee.EmployeeNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Department_WhenEmpty_ShouldThrowException()
        {
            var employee = new Employee();
            employee.Department = "";
        }

        [TestMethod]
        public void Department_ShouldBeNormalized()
        {
            var employee = new Employee();
            employee.Department = "it";
            Assert.AreEqual("It", employee.Department);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StartDate_WhenDefault_ShouldThrowException()
        {
            var employee = new Employee();
            employee.StartDate = default;
        }

        [TestMethod]
        public void Employment_ValidValue_ShouldBeSet()
        {
            var employee = new Employee();
            employee.Employment = 80;
            Assert.AreEqual(80, employee.Employment);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Employment_InvalidValue_ShouldThrowException()
        {
            var employee = new Employee();
            employee.Employment = 85; // nicht durch 20 teilbar
        }

        [TestMethod]
        public void Role_ShouldBeNormalized()
        {
            var employee = new Employee();
            employee.Role = "developer";
            Assert.AreEqual("Developer", employee.Role);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Role_WhenEmpty_ShouldThrowException()
        {
            var employee = new Employee();
            employee.Role = "";
        }

        [TestMethod]
        public void CadreLevel_ValidValue_ShouldBeSet()
        {
            var employee = new Employee();
            employee.CadreLevel = 3;
            Assert.AreEqual(3, employee.CadreLevel);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CadreLevel_InvalidValue_ShouldThrowException()
        {
            var employee = new Employee();
            employee.CadreLevel = 10; // nur 0-5 erlaubt
        }
    }
}

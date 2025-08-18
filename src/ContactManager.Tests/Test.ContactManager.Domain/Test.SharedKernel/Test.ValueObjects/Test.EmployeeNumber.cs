using ContactManager.Domain.SharedKernel.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactManager.Tests.Domain.SharedKernel.ValueObjects
{
    [TestClass]
    public class TestEmployeeNumber
    {
        [TestMethod]
        public void Create_WithValidInputs_ShouldFormatCorrectly()
        {
            // Act
            var empNo = EmployeeNumber.Create("W", 1, 3);

            // Assert
            Assert.AreEqual("W-0001-0003", empNo.Value);
            Assert.AreEqual("W-0001-0003", empNo.ToString());
        }

        [TestMethod]
        public void Create_PrefixLowercase_ShouldBeUppercased()
        {
            // Act
            var empNo = EmployeeNumber.Create("hr", 123, 456);

            // Assert
            Assert.AreEqual("HR-0123-0456", empNo.Value);
        }

        [TestMethod]
        public void Create_SameInputs_ShouldCreateEqualValues()
        {
            // Arrange
            var a = EmployeeNumber.Create("a", 42, 7);
            var b = EmployeeNumber.Create("A", 42, 7);

            // Assert (Equal über Value – oder Equals, falls SingleValueObject das implementiert)
            Assert.AreEqual(a.Value, b.Value);
            Assert.AreEqual(a.ToString(), b.ToString());
        }
    }
}

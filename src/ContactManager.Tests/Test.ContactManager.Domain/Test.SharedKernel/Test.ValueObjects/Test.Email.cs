using ContactManager.Domain.SharedKernel.ValueObjects;

namespace ContactManager.Tests.Test.ContactManager.Domain.Test.SharedKernel.Test.ValueObjects
{
    [TestClass]
    public class TestEmail
    {
        [TestMethod]
        public void Constructor_ValidEmail_ShouldSetValue()
        {
            // Arrange
            string emailValue = "john.doe@example.com";

            // Act
            var email = new Email(emailValue);

            // Assert
            Assert.AreEqual(emailValue, email.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_InvalidEmail_ShouldThrowException()
        {
            // Act
            var email = new Email("invalid-email");
        }


        [TestMethod]
        public void Equals_SameEmailDifferentCase_ShouldBeEqual()
        {
            // Act
            var email1 = new Email("test@example.com");
            var email2 = new Email("TEST@example.com");

            // Assert
            Assert.AreEqual(email1, email2);
        }

        [TestMethod]
        public void Equals_SameEmailOneWithSpace_ShouldBeEqual()
        {
            // Act
            var email1 = new Email("test@example.com ");
            var email2 = new Email("test@example.com");

            // Assert
            Assert.AreEqual(email1, email2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_Null_ShouldThrowException()
        {
            // Act
            var email = new Email(null);
        }
    }
}

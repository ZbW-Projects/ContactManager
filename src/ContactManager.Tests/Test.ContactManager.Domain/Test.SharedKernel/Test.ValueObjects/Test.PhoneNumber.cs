using ContactManager.Domain.SharedKernel.ValueObjects;

namespace ContactManager.Tests.Test.ContactManager.Domain.Test.SharedKernel.Test.ValueObjects
{
    [TestClass]
    public class TestPhoneNumber
    {
        [TestMethod]
        public void ValidSwissMobileNumber_ShouldNormalize()
        {
            // Arange
            string number = "078 123 45 67";

            // Act
            var phone = new PhoneNumber(number);

            // Assert
            Assert.AreEqual("+41781234567", phone.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidPhoneNumber_ShouldThrow()
        {
            _ = new PhoneNumber("12345");
        }
    }
}

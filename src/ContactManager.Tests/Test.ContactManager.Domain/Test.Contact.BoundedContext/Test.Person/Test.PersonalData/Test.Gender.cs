using ContactManager.Domain.Contact.BoundedContext.Person.PersonalData;
using ContactManager.Domain.Common;

namespace ContactManager.Tests.Test.ContactManager.Domain.Test.Contact.BoundedContext.Test.Person.Test.PersonalData
{
    [TestClass]
    public class TestGender
    {
        [TestMethod]
        public void GetAll_ShouldReturnAllGenders()
        {
            // Arange
            // Act
            var all = Enumeration.GetAll<Gender>().ToList();

            // Assert
            Assert.AreEqual(3, all.Count);
            CollectionAssert.Contains(all, Gender.Female);
            CollectionAssert.Contains(all, Gender.Male);
            CollectionAssert.Contains(all, Gender.Divers);
        }

        [TestMethod]
        public void FromName_ShouldBeCaseInsensitive()
        {
            // Arrange
            // Act
            var g1 = Gender.FromName("female");
            var g2 = Gender.FromName("FeMale");

            // Assert
            Assert.AreSame(Gender.Female, g1);
            Assert.AreSame(Gender.Female, g2);
        }

        [TestMethod]
        public void FromId_ShouldReturnCorrectInstance()
        {
            var male = Gender.FromId(Gender.Male.Id);
            Assert.AreSame(Gender.Male, male);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromName_Invalid_ShouldThrow()
        {
            _ = Gender.FromName("unknown");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromId_Invalid_ShouldThrow()
        {
            _ = Gender.FromId(999);
        }

        [TestMethod]
        public void Equals_ShouldCompareByTypeAndId()
        {
            Assert.IsTrue(Gender.Male.Equals(Gender.Male));
            Assert.IsFalse(Gender.Male.Equals(Gender.Female));
        }

        [TestMethod]
        public void CompareTo_ShouldOrderById()
        {
            // Ensure your IDs are Female=1, Male=2, Divers=3 (as you defined)
            Assert.IsTrue(Gender.Female.CompareTo(Gender.Male) < 0);
            Assert.IsTrue(Gender.Divers.CompareTo(Gender.Male) > 0);
            Assert.AreEqual(0, Gender.Female.CompareTo(Gender.Female));
        }

        [TestMethod]
        public void ToString_ShouldReturnName()
        {
            Assert.AreEqual("Female", Gender.Female.ToString());
            Assert.AreEqual("Male", Gender.Male.ToString());
            Assert.AreEqual("Divers", Gender.Divers.ToString());
        }

        [TestMethod]
        public void Helpers_ShouldWork()
        {
            Assert.IsTrue(Gender.Male.IsMale());
            Assert.IsTrue(Gender.Female.IsFemale());
            Assert.IsTrue(Gender.Divers.IsDivers());
        }
    }
}

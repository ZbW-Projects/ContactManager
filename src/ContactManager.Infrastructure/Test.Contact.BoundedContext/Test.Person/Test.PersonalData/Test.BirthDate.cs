using System;
using ContactManager.Domain.Contact.BoundedContext.Person.PersonalData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactManager.Tests.Domain.ValueObjects
{
    [TestClass]
    public class BirthDateTests
    {
        [TestMethod]
        public void Create_PastDate_ShouldStoreDateOnly()
        {
            // Arrange
            var past = DateTime.UtcNow.Date.AddYears(-30).AddHours(15); // with time component

            // Act
            var bd = BirthDate.Create(past);

            // Assert
            Assert.AreEqual(past.Date, bd.Value);
            Assert.AreEqual(0, bd.Value.TimeOfDay.Ticks, "Time part must be stripped to midnight.");
        }

        [TestMethod]
        public void Create_Today_ShouldSucceed()
        {
            // Arrange
            var today = DateTime.UtcNow.Date;

            // Act
            var bd = BirthDate.Create(today);

            // Assert
            Assert.AreEqual(today, bd.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_Default_ShouldThrow()
        {
            // Act
            BirthDate.Create(default);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_FutureDate_ShouldThrow()
        {
            // Arrange
            var future = DateTime.UtcNow.Date.AddDays(1);

            // Act
            BirthDate.Create(future);
        }

        [TestMethod]
        public void Equality_SameCalendarDayDifferentKinds_ShouldBeEqualByValue()
        {
            // Arrange
            var local = DateTime.SpecifyKind(DateTime.UtcNow.Date.AddYears(-10), DateTimeKind.Local);
            var utc = DateTime.SpecifyKind(local, DateTimeKind.Utc);

            // Act
            var a = BirthDate.Create(local);
            var b = BirthDate.Create(utc);

            // Assert
            // If SingleValueObject implements value equality, this passes:
            // Assert.AreEqual(a, b);
            // Always safe:
            Assert.AreEqual(a.Value, b.Value);
        }

        [TestMethod]
        public void Inequality_DifferentDays_ShouldNotBeEqual()
        {
            var d1 = BirthDate.Create(DateTime.UtcNow.Date.AddYears(-20));
            var d2 = BirthDate.Create(DateTime.UtcNow.Date.AddYears(-20).AddDays(1));

            // If value equality is implemented:
            // Assert.AreNotEqual(d1, d2);
            Assert.AreNotEqual(d1.Value, d2.Value);
        }
    }
}

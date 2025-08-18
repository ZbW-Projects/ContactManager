using ContactManager.Domain.Contact.BoundedContext.Person;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContactManager.Tests.Domain.Contact.BoundedContext.Person
{
    [TestClass]
    public class LabourDateTests
    {
        [TestMethod]
        public void Create_WithEntryOnly_ShouldStoreEntry_AndNullLeave()
        {
            // Arrange
            var entry = new DateTime(2022, 5, 10, 15, 30, 0); // mit Zeit

            // Act
            var ld = LabourDate.Create(entry);

            // Assert (Zeitanteile werden entfernt)
            Assert.AreEqual(entry.Date, ld.EntryDate);
            Assert.IsNull(ld.LeaveDate);
        }

        [TestMethod]
        public void Create_WithEntryAndLeave_SameDay_ShouldSucceed()
        {
            var entry = new DateTime(2023, 1, 1, 23, 59, 59);
            var leave = new DateTime(2023, 1, 1, 0, 0, 1);

            var ld = LabourDate.Create(entry, leave);

            Assert.AreEqual(entry.Date, ld.EntryDate);
            Assert.AreEqual(leave.Date, ld.LeaveDate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_WithDefaultEntry_ShouldThrow()
        {
            LabourDate.Create(default);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_WithLeaveBeforeEntry_ShouldThrow()
        {
            var entry = new DateTime(2024, 6, 1);
            var leave = new DateTime(2024, 5, 31);
            LabourDate.Create(entry, leave);
        }

        [TestMethod]
        public void Equality_SameValues_ShouldBeEqual()
        {
            var e = new DateTime(2021, 9, 1);
            var l = new DateTime(2022, 9, 1);

            var a = LabourDate.Create(e, l);
            var b = LabourDate.Create(e.AddHours(12), l.AddHours(8)); // Zeitanteile egal

            Assert.AreEqual(a, b);
            Assert.IsTrue(a.Equals(b));
            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }

        [TestMethod]
        public void Equality_DifferentValues_ShouldNotBeEqual()
        {
            var a = LabourDate.Create(new DateTime(2020, 1, 1), new DateTime(2021, 1, 1));
            var b = LabourDate.Create(new DateTime(2020, 1, 2), new DateTime(2021, 1, 1));

            Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        public void ToString_Formats_As_Range()
        {
            var ld = LabourDate.Create(new DateTime(2020, 2, 3), new DateTime(2022, 12, 31));
            Assert.AreEqual("2020-02-03 => 2022-12-31", ld.ToString());
        }

        [TestMethod]
        public void ToString_Formats_Present_If_NoLeave()
        {
            var ld = LabourDate.Create(new DateTime(2019, 7, 15));
            Assert.AreEqual("2019-07-15 => Present", ld.ToString());
        }
    }
}

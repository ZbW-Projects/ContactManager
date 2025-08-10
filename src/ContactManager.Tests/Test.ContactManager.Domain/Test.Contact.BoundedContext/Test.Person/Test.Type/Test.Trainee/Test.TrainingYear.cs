using ContactManager.Domain.Contact.BoundedContext.Person.Type.Trainee;

namespace ContactManager.Tests.Test.ContactManager.Domain.Test.Contact.BoundedContext.Test.Person.Test.Type.Test.Trainee
{
    [TestClass]
    public class TestTrainingYear
    {
        // Helper fixed "now" so tests are deterministic
        private static readonly DateTime FixedNow = new DateTime(2025, 08, 10, 12, 0, 0);

        [TestMethod]
        public void Create_LessThanOneYear_ReturnsFirstYear()
        {
            // Entry is 4 months ago
            var entry = new DateTime(2025, 04, 10);
            var ty = TrainingYear.Create(entry, nowOverride: FixedNow);

            Assert.AreEqual(1, ty.Value);
        }

        [TestMethod]
        public void Create_ExactlyOneYearMinusOneDay_ReturnsFirstYear()
        {
            var entry = new DateTime(2024, 08, 11);
            var ty = TrainingYear.Create(entry, nowOverride: FixedNow); // 2025-08-10

            Assert.AreEqual(1, ty.Value);
        }

        [TestMethod]
        public void Create_ExactlyOneYear_ReturnsSecondYear()
        {
            var entry = new DateTime(2024, 08, 10);
            var ty = TrainingYear.Create(entry, nowOverride: FixedNow);

            Assert.AreEqual(2, ty.Value);
        }

        [TestMethod]
        public void Create_TwoYearsAndSomeDays_ReturnsThirdYear()
        {
            var entry = new DateTime(2023, 08, 05);
            var ty = TrainingYear.Create(entry, nowOverride: FixedNow); // ~2 years + 5 days

            Assert.AreEqual(3, ty.Value);
        }

        [TestMethod]
        public void Create_BeforeAnniversaryInCurrentYear_ReturnsSecondYear()
        {
            var entry = new DateTime(2023, 08, 11);   // anniversary is tomorrow
            var ty = TrainingYear.Create(entry, nowOverride: FixedNow); // 2025-08-10

            // Full years = 1, "year-in" = 2
            Assert.AreEqual(2, ty.Value);
        }

        [TestMethod]
        public void Create_WithLastLabourDate_UsesThatAsEndDate()
        {
            var entry = new DateTime(2022, 05, 15);
            var lastLabour = new DateTime(2024, 05, 14); // one day before 2nd anniversary → full years = 1 → in 2nd year
            var ty = TrainingYear.Create(entry, lastLabourDate: lastLabour, nowOverride: FixedNow);

            Assert.AreEqual(2, ty.Value);
        }

        [TestMethod]
        public void Create_EndBeforeEntry_ReturnsFirstYear()
        {
            var entry = new DateTime(2025, 12, 01);
            var ty = TrainingYear.Create(entry, nowOverride: FixedNow); // end < entry → 1

            Assert.AreEqual(1, ty.Value);
        }

        [TestMethod]
        public void Create_DefaultEntryDate_Throws()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                _ = TrainingYear.Create(default(DateTime), nowOverride: FixedNow);
            });
        }
    }
}

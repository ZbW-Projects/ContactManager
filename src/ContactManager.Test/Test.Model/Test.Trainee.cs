using ContactManager.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContactManager.Test.Core.Model
{
    [TestClass]
    public class TraineeTests
    {
        [TestMethod]
        public void EndDate_ValidDate_IsSet()
        {
            var t = new Trainee();
            var end = new DateTime(2025, 6, 30);

            t.EndDate = end;

            Assert.AreEqual(end, t.EndDate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EndDate_Default_Throws()
        {
            var t = new Trainee();
            t.EndDate = default;
        }

        [TestMethod]
        public void CadreLevel_IsAlwaysZero()
        {
            var t = new Trainee();
            t.CadreLevel = 3; // egal was gesetzt wird
            Assert.AreEqual(0, t.CadreLevel);
        }

        [TestMethod]
        public void TraineeYears_ValidBetween0And4_IsSet()
        {
            var t = new Trainee();
            t.TraineeYears = 3;

            Assert.AreEqual(3, t.TraineeYears);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TraineeYears_LessThanZero_Throws()
        {
            var t = new Trainee();
            t.TraineeYears = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TraineeYears_GreaterThan4_Throws()
        {
            var t = new Trainee();
            t.TraineeYears = 5;
        }

        [TestMethod]
        public void ActualTraineeYear_UsesDatesDiff()
        {
            var start = new DateTime(DateTime.Today.Year - 2, 1, 1);
            var end = DateTime.Today.AddYears(1); // noch nicht beendet
            var t = new Trainee();
            // Zugriff auf protected Felder _startDate/_endDate geht nur über Basisklasse Employee
            // hier simulieren wir über Properties
            t.StartDate = start;
            t.EndDate = end;
            var actual = DatesDiff.Year(start, end, 1);

            Assert.AreEqual(actual, t.ActualTraineeYear);
        }
    }

    [TestClass]
    public class DatesDiffTests
    {
        [TestMethod]
        public void Year_TodayBeforeStart_Returns0()
        {
            var start = DateTime.Today.AddDays(1);
            var result = DatesDiff.Year(start, offSet: 1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Year_TodayAfterEnd_ReturnsDifference()
        {
            var start = new DateTime(2020, 1, 1);
            var end = new DateTime(2022, 1, 1);
            var result = DatesDiff.Year(start, end, 1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Year_SameYear_Returns1()
        {
            var start = DateTime.Today.AddMonths(-2);
            var result = DatesDiff.Year(start, offSet: 1);
            Assert.AreEqual(1, result);
        }


        //Beobachtung:
        // Dieser Test wurde ein wenig angepasst.
        // Es ist ein Counter für die geleisteten Jahre, 
        // der im Fall eines fehlenden Enddatums wie eine Art
        // unbefristeter Vertrag funktioniert. 
        // In der Trainee-Umgebung ist das nicht üblich.

        [TestMethod]
        public void Year_EndDateDefault_CountsYears()
        {
            var start = new DateTime(DateTime.Today.Year - 5, 1, 1);
            var result = DatesDiff.Year(start, offSet: 1);
            Assert.AreEqual(6, result);
        }
    }
}

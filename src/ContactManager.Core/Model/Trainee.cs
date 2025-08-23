using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Core.Model
{
    public class Trainee : Employee
    {
        #region Eigenschaften 

        private int _traineeYears;
        private int _actualTraineeYear;

        #endregion

        public int TraineeYears { get => _traineeYears; set => _traineeYears = value is >= 1 and <= 4 ? throw new ArgumentException("Der Wert ist ungültig.", nameof(value)) : value; }
        public int ActualTraineeYear => _actualTraineeYear;
        public void SetActualTraineeYear(DateTime startDate, DateTime endDate = default) => _actualTraineeYear = DatesDiff.Year(startDate, endDate);
    }

    /*===================================================================
     * 
     * Eine Klasse, die Jahre berechnet und als ganzes Integer ausgibt.
     * Sie wird hier für die Berechnung von Lehrlingsjahren eingesetzt.
     * 
     * ===================================================================*/

    public class DatesDiff
    {
        public static int Year(DateTime startDate, DateTime endDate = default)
        {
            int year = DateTime.Today.Year - startDate.Year;

            if (endDate == default) endDate = DateTime.Today;
            if (DateTime.Today < startDate) return 0;
            if (DateTime.Today >= endDate) return endDate.Year - startDate.Year;
            return year == 0 ? 1 : year;
        }
    }
}

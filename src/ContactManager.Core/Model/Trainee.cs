using ContactManager.Core.Services.features;
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

        #endregion

        public Trainee() { }
        public Trainee(string prefix, int employeeNumber) : base(prefix, employeeNumber) { }

        public override DateTime EndDate { get => _endDate; set => _endDate = value == default ? throw new ArgumentException("Das EndDatum muss einen Wert enthalten.", nameof(value)) : value; }
        public override int CadreLevel { get => _cadreLevel; set => _cadreLevel = 0; }
        public int TraineeYears { get => _traineeYears; set => _traineeYears = value < 0 || value > 4 ? throw new ArgumentException("Die Lehrjahre sind ungültig.", nameof(value)) : value; }
        public int ActualTraineeYear => DatesDiff.Year(_startDate, _endDate);

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

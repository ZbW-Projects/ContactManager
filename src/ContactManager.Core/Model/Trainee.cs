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

        public override DateTime EndDate { get => _endDate; set => _endDate = value == default ? throw new ArgumentException("Das EndDatum muss einen Wert enthalten.") : value; }
        public override int CadreLevel { get => _cadreLevel; set => _cadreLevel = 0; }
        public int TraineeYears { get => _traineeYears; set => _traineeYears = value < 0 || value > 4 ? throw new ArgumentException("Die Lehrjahre sind ungültig.") : value; }
        public int ActualTraineeYear => DatesDiff.Year(_startDate, _endDate, 1);

    }


    /*===================================================================
     * 
     * Eine Klasse, die Jahre berechnet und als ganzes Integer ausgibt.
     * Sie wird hier für die Berechnung von Lehrlingsjahren eingesetzt.
     * 
     * ===================================================================*/

    public class DatesDiff
    {
        public static int Year(DateTime startDate, DateTime endDate = default, int offSet = 0)
        {
            int tenure = DateTime.Today.Year - startDate.Year + offSet;
            DateTime today = DateTime.Today;

            if (endDate == default)
            {
                if (startDate > today) return 0;
            }
            else
            {
                if (endDate < today) return endDate.Year - startDate.Year;
            }

            return tenure;
        }
    }
}
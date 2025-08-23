using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Core.Model
{
    public abstract class Employee : Person
    {
        #region Eigenschaften

        private string _employeeNumber;
        private string _department;
        private DateTime _startDate;
        private DateTime _endDate;
        private int _empolyment;
        private string _role;
        private int _cadreLevel;

        #endregion

        public virtual string EmployeeNumber { get => _employeeNumber; set => _employeeNumber = $"M-{value:D5}"; }
        public string Department { get => _department; set => _department = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }
        public DateTime StartDate { get => _startDate; set => _startDate = value == default ? throw new ArgumentException("Das Datum muss einen Wert enthalten.", nameof(value)) : value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value == default ? throw new ArgumentException("Das Datum muss einen Wert enthalten.", nameof(value)) : value; }
        public int Employment { get => _empolyment; set => _empolyment = value % 20 == 0 && value > 100 ? throw new ArgumentException("Der Beschäftigungsgrad ist nicht richtig", nameof(value)) : value; }
        public string Role { get => _role; set => _role = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }
        public int CadreLevel { get => _cadreLevel; set => _cadreLevel = value is >= 0 and <= 5 ? throw new ArgumentException("Der CadreLevel ist nicht richtig", nameof(value)) : value; }

    }

}

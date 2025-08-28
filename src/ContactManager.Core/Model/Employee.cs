using ContactManager.Core.Services.features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ContactManager.Core.Model
{
    public class Employee : Person
    {
        #region Eigenschaften

        protected string _employeeNumber;
        private string _department = "";
        protected DateTime _startDate;
        protected DateTime _endDate;
        private int _empolyment;
        private string _role = "";
        protected int _cadreLevel;

        #endregion

        public Employee() { }
        public Employee(string prefix, int employeeNumber)
        {
            _employeeNumber = $"{prefix}-{employeeNumber:D5}";
        }

        [JsonInclude]
        public virtual string EmployeeNumber { get => _employeeNumber; private set => _employeeNumber = value; }
        public string Department { get => _department; set => _department = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Das Departement muss vorhanden sein.") : Name.Normalize(value); }
        public DateTime StartDate { get => _startDate; set => _startDate = value == default ? throw new ArgumentException("Das StartDatum muss einen Wert enthalten.", nameof(value)) : value; }
        public virtual DateTime EndDate { get => _endDate; set => _endDate = value; }
        public int Employment { get => _empolyment; set => _empolyment = value % 20 != 0 && value >= 100 || value <= 0 ? throw new ArgumentException("Der Beschäftigungsgrad ist nicht richtig", nameof(value)) : value; }
        public string Role { get => _role; set => _role = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Rolle darf nicht leer sein.") : Name.Normalize(value); }
        public virtual int CadreLevel { get => _cadreLevel; set => _cadreLevel = value < 0 || value > 5 ? throw new ArgumentException("Der CadreLevel ist nicht richtig", nameof(value)) : value; }

    }

}

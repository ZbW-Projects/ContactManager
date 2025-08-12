using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Presentation.Demo.Models
{
    public enum ContactRole { Employee, Trainee, Customer }

    public class Contact
    {
        public string Id { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public ContactRole Role { get; set; }
        public bool Active { get; set; } = true;
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Company { get; set; } = "";
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string Zip { get; set; } = "";
        public System.DateTime? Birthdate { get; set; }

        // Convenience for grid:
        public string Surname => FirstName;            // “Surname” = First name
        public string Lastname => LastName;
        public string Type => Role.ToString();
        public string Status => Active ? "Aktiv" : "Inaktiv";

        public Contact Clone() => (Contact)MemberwiseClone();
    }
}

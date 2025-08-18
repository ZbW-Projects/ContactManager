using ContactManager.Domain.Common;
using ContactManager.Domain.Contact.BoundedContext.Person.Type.WorkCollege;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactManager.Domain.Contact.BoundedContext.Person
{
    public sealed class Department : Enumeration
    {
        public static readonly Department HumanResources = new(1, "Human Resources");
        public static readonly Department Finance = new(2, "Finance");
        public static readonly Department IT = new(3, "IT");
        public static readonly Department Sales = new(4, "Sales");
        public static readonly Department Marketing = new(5, "Marketing");
        public static readonly Department Logistic = new(6, "Logistic");

        private Department(int id, string name) : base(id, name) { }

        public static IEnumerable<Department> List() => GetAll<Department>();

        // Diese Methoden sind noch Optional
        public bool IsHumanResources() => this == HumanResources;
        public bool IsFinance() => this == Finance;
        public bool IsIT() => this == IT;
        public bool IsSales() => this == Sales;
        public bool IsMarketing() => this == Marketing;
        public bool IsLogistic() => this == Logistic;

        public static Department FromName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
            }

            var normalized = name.Trim();

            var type = GetAll<Department>().FirstOrDefault(type => string.Equals(type.Name, normalized, StringComparison.OrdinalIgnoreCase));

            if (type == null)
            {
                throw new ArgumentException($"Invalid Department: {name}", nameof(name));
            }

            return type;
        }

        public static Department FromId(int id)
        {
            var type = GetAll<Department>().FirstOrDefault(type => type.Id == id);

            if (type == null)
            {
                throw new ArgumentException($"Invalid Department ID: {id}", nameof(id));
            }

            return type;
        }

    }
}

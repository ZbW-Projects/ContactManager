using ContactManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactManager.Domain.Contact.BoundedContext.Person.Type.WorkCollege
{
    public class ManagementLevel : Enumeration
    {
        public static readonly ManagementLevel Zero = new(0, "0");
        public static readonly ManagementLevel One = new(1, "1");
        public static readonly ManagementLevel Two = new(2, "2");
        public static readonly ManagementLevel Three = new(3, "3");
        public static readonly ManagementLevel Four = new(4, "4");
        public static readonly ManagementLevel Five = new(5, "5");

        private ManagementLevel(int id, string name) : base(id, name) { }

        public static IEnumerable<ManagementLevel> List() => GetAll<ManagementLevel>();

        // Diese Methoden sind noch Optional
        public bool IsZero() => this == Zero;
        public bool IsOne() => this == One;
        public bool IsTwo() => this == Two;
        public bool IsThree() => this == Three;
        public bool IsFour() => this == Four;
        public bool IsFive() => this == Five;



        public static ManagementLevel FromName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
            }

            var normalized = name.Trim();

            var type = GetAll<ManagementLevel>().FirstOrDefault(type => string.Equals(type.Name, normalized, StringComparison.OrdinalIgnoreCase));

            if (type == null)
            {
                throw new ArgumentException($"Invalid ManagementLevel: {name}", nameof(name));
            }

            return type;
        }

        public static ManagementLevel FromId(int id)
        {
            var type = GetAll<ManagementLevel>().FirstOrDefault(type => type.Id == id);

            if (type == null)
            {
                throw new ArgumentException($"Invalid ManagementLevel ID: {id}", nameof(id));
            }

            return type;
        }

    }
}

using ContactManager.Domain.Common;

namespace ContactManager.Domain.Contact.BoundedContext.Person.PersonalData
{
    public class Gender : Enumeration
    {
        public static readonly Gender Female = new(1, "Female");
        public static readonly Gender Male = new(2, "Male");
        public static readonly Gender Divers = new(3, "Divers");

        private Gender(int id, string name) : base(id, name) { }

        // Diese Gender Methoden sind noch Optional
        public bool IsFemale() => this == Female;
        public bool IsMale() => this == Male;
        public bool IsDivers() => this == Divers;


        public static Gender FromName(string name)
        {
            var gender = GetAll<Gender>().FirstOrDefault(g => string.Equals(g.Name, name, StringComparison.OrdinalIgnoreCase));

            if (gender == null)
            {
                throw new ArgumentException($"Invalid gender: {name}");
            }

            return gender;
        }

        public static Gender FromId(int id)
        {
            var gender = GetAll<Gender>().FirstOrDefault(g => g.Id == id);

            if (gender == null)
            {
                throw new ArgumentException($"Invalid gender ID: {id}");
            }

            return gender;
        }

    }
}

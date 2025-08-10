using ContactManager.Domain.SharedKernel.ValueObjects;

namespace ContactManager.Domain.Contact.BoundedContext.Person
{


    public class DegreeOfEmployment : SingleValueObject<int>
    {
        private DegreeOfEmployment(int value) : base(Normalize(value)) { }

        private static int Normalize(int value)
        {
            if (value < 10 || value > 100)
            {
                throw new ArgumentException("Degree of employment must be between 10 and 100 percent.", nameof(value));
            }
            return value;
        }

        public static DegreeOfEmployment Create(int value) => new(value);

        public override string ToString() => $"{Value}%";
    }

}

using ContactManager.Domain.SharedKernel.ValueObjects;

namespace ContactManager.Domain.Contact.BoundedContext.Person.PersonalData
{
    public class BirthDate : SingleValueObject<DateTime>
    {
        private BirthDate(DateTime value) : base(Normalize(value)) { }

        private static DateTime Normalize(DateTime value)
        {
            if (value == default)
            {
                throw new ArgumentException("Birth date cannot be empty.", nameof(value));
            }

            if (value.Date > DateTime.UtcNow.Date)
            {
                throw new ArgumentException("Birth date cannot be in the future.", nameof(value));
            }

            return value.Date;
        }

        public static BirthDate Create(DateTime value) => new(value);
    }

}

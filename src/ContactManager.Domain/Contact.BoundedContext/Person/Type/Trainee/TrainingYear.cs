using System;
using ContactManager.Domain.SharedKernel.ValueObjects;


namespace ContactManager.Domain.Contact.BoundedContext.Person.Type.Trainee
{
    public class TrainingYear : SingleValueObject<int>
    {
        private TrainingYear(int years) : base(years) { }

        public static TrainingYear Create(DateTime entryDate, DateTime? lastLabourDate = null, DateTime? nowOverride = null)
        {
            if (entryDate == default)
            {
                throw new ArgumentException("Entry date is required.", nameof(entryDate));
            }

            var end = lastLabourDate ?? nowOverride ?? DateTime.Now;

            if (end < entryDate)
            {
                return new TrainingYear(1);
            }

            int years = end.Year - entryDate.Year;

            if (end.Month < entryDate.Month || (end.Month == entryDate.Month && end.Day < entryDate.Day))
            {
                years--;
            }

            if (years < 0)
            {
                years = 0;
            }

            return new TrainingYear(years + 1);

        }
        protected override bool IsInvalid(int value) => value < 1;

        public override string ToString() => $"{Value}";

    }
}

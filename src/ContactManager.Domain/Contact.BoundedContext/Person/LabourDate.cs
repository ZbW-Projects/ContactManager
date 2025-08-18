using ContactManager.Domain.Common;
using System;
using System.Collections.Generic;

namespace ContactManager.Domain.Contact.BoundedContext.Person
{
    public sealed class LabourDate : ValueObject
    {
        public DateTime EntryDate { get; }
        public DateTime? LeaveDate { get; }

        private LabourDate(DateTime entryDate, DateTime? leaveDate)
        {
            if (entryDate == default)
            {
                throw new ArgumentException("Entry date is required.", nameof(entryDate));
            }

            if (leaveDate.HasValue && leaveDate.Value < entryDate)
            {
                throw new ArgumentException("Leave date cannot be earlier than entry date.", nameof(leaveDate));
            }

            EntryDate = entryDate.Date;
            LeaveDate = leaveDate?.Date;
        }

        public static LabourDate Create(DateTime entryDate, DateTime? leaveDate = null)
        {
            return new LabourDate(entryDate, leaveDate);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return EntryDate;
            yield return LeaveDate;
        }

        public override string ToString()
        {
            var entryString = EntryDate.ToString("yyyy-MM-dd");
            var leaveString = LeaveDate.HasValue ? LeaveDate.Value.ToString("yyyy-MM-dd") : "Present";
            return $"{entryString} => {leaveString}";
        }
    }
}

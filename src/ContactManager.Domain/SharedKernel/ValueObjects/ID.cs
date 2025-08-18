
// Input: int 1
// Output: int 1


namespace ContactManager.Domain.SharedKernel.ValueObjects
{

    using ContactManager.Domain.Common;
    using System;

    public class ID : SingleValueObject<int>
    {
        protected ID() : base(default) { } // Required by EF Core or deserialization
        public ID(int value) : base(value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("ID must be a positive integer.", nameof(value));
            }
        }

        public static ID Create(int value) => new(value);
    }

}

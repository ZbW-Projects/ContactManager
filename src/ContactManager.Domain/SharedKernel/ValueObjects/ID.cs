using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Domain.SharedKernel.ValueObjects
{

    using ContactManager.Domain.Common;

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

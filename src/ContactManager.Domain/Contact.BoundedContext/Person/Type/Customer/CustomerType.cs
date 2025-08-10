using ContactManager.Domain.Common;

namespace ContactManager.Domain.Contact.BoundedContext.Person.Type.Customer
{
    public class CustomerType : Enumeration
    {
        public static readonly CustomerType A = new(1, "A");
        public static readonly CustomerType B = new(2, "B");
        public static readonly CustomerType C = new(3, "C");
        public static readonly CustomerType D = new(4, "D");
        public static readonly CustomerType E = new(5, "E");

        private CustomerType(int id, string name) : base(id, name) { }

        public static IEnumerable<CustomerType> List() => GetAll<CustomerType>();

        // Diese Methoden sind noch Optional
        public bool IsA() => this == A;
        public bool IsB() => this == B;
        public bool IsC() => this == C;
        public bool IsD() => this == D;
        public bool IsE() => this == E;



        public static CustomerType FromName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
            }

            var normalized = name.Trim();

            var type = GetAll<CustomerType>().FirstOrDefault(type => string.Equals(type.Name, normalized, StringComparison.OrdinalIgnoreCase));

            if (type == null)
            {
                throw new ArgumentException($"Invalid CustomerType: {name}", nameof(name));
            }

            return type;
        }

        public static CustomerType FromId(int id)
        {
            var type = GetAll<CustomerType>().FirstOrDefault(type => type.Id == id);

            if (type == null)
            {
                throw new ArgumentException($"Invalid CustomerType ID: {id}", nameof(id));
            }

            return type;
        }

    }
}



// Input :  string "W", int 1, int 3 
// Output : "W-0001-0003"


namespace ContactManager.Domain.SharedKernel.ValueObjects
{
    public class EmployeeNumber : SingleValueObject<string>
    {
        private EmployeeNumber(string value) : base(Normalize(value)) { }

        private static string Normalize(string value)
        {
            return value.Trim().ToUpperInvariant();
        }

        public static EmployeeNumber Create(string prefix, int companyId, int personId)
        {
            string number = $"{prefix}-{companyId:D4}-{personId:D4}";
            return new EmployeeNumber(number);
        }

        public override string ToString() => Value;
    }

}

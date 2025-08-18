using System.Threading;
using ContactManager.Application.Common;

namespace ContactManager.Application.Fakes
{
    public sealed class InMemoryIdGenerator : IIdGenerator
    {
        private int _contact;
        private int _company;

        public InMemoryIdGenerator(int contactStart = 0, int companyStart = 0)
        {
            _contact = contactStart;
            _company = companyStart;
        }

        public int NextContactId() => Interlocked.Increment(ref _contact);
        public int NextCompanyId() => Interlocked.Increment(ref _company);

        public string NextEmployeeNumber(int contactId, int companyId, string departmentCode)
            => $"{departmentCode}-{companyId:0000}-{contactId:0000}";
    }
}

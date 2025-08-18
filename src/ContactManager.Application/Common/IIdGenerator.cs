
namespace ContactManager.Application.Common
{
    public interface IIdGenerator
    {
        int NextContactId();
        int NextCompanyId();
        string NextEmployeeNumber(int contactId, int companyId, string departmentCode);
    }

}

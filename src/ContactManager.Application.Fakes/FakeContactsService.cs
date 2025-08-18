using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManager.Application.Abstractions.Dtos;
using ContactManager.Application.Abstractions.UseCases;
using ContactManager.Application.Common;

namespace ContactManager.Application.Fakes
{
    // In-memory demo implementation
    public sealed class FakeContactsService : IContactQueries, IContactCommands
    {
        private readonly List<ContactDetailsDto> _store;
        private readonly IIdGenerator _ids;
        private readonly Dictionary<string, CompanyDto> _companiesByName;

        public FakeContactsService(IEnumerable<ContactDetailsDto> seed = null, IIdGenerator ids = null)
        {
            _store = seed != null ? new List<ContactDetailsDto>(seed) : Seed();

            _companiesByName = new Dictionary<string, CompanyDto>(StringComparer.OrdinalIgnoreCase);
            foreach (var c in _store.Select(x => x.Company).Where(c => c != null))
                _companiesByName[c.Name ?? $"Company#{c.Id}"] = c;

            // Seed the ID generator from maxima so next IDs are unique
            var maxContactId = _store.Any() ? _store.Max(x => x.Id) : 0;
            var maxCompanyId = _companiesByName.Values.Any() ? _companiesByName.Values.Max(c => c.Id) : 0;
            _ids = ids ?? new InMemoryIdGenerator(maxContactId, maxCompanyId);
        }

        // ---------- Queries ----------
        public Task<IReadOnlyList<ContactListItemDto>> GetContactsAsync(ContactFilterDto f)
        {
            string search = (f != null && f.Search != null) ? f.Search.Trim().ToLowerInvariant() : "";
            string type = (f != null) ? f.Type : null;
            string status = (f != null) ? f.Status : null;

            IEnumerable<ContactDetailsDto> q = _store;

            if (!string.IsNullOrEmpty(search))
            {
                q = q.Where(x =>
                    ((x.FirstName ?? "").ToLowerInvariant().Contains(search)) ||
                    ((x.LastName ?? "").ToLowerInvariant().Contains(search)) ||
                    ((x.Email ?? "").ToLowerInvariant().Contains(search)) ||
                    ((x.EmployeeNumber ?? "").ToLowerInvariant().Contains(search)) ||
                    ((x.Company != null ? x.Company.Name : "").ToLowerInvariant().Contains(search)) ||
                    ((x.Company != null ? x.Company.Email : "").ToLowerInvariant().Contains(search))
                );
            }
            if (!string.IsNullOrEmpty(type))
                q = q.Where(x => string.Equals(x.Type, type, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(status))
                q = q.Where(x => string.Equals(x.Status, status, StringComparison.OrdinalIgnoreCase));

            var list = q.Select(ToListItem).ToList();
            return Task.FromResult((IReadOnlyList<ContactListItemDto>)list);
        }

        public Task<IReadOnlyList<ContactListItemDto>> GetDeactivatedAsync()
        {
            var list = _store
                .Where(x => string.Equals(x.Status, "left", StringComparison.OrdinalIgnoreCase))
                .Select(ToListItem)
                .ToList();
            return Task.FromResult((IReadOnlyList<ContactListItemDto>)list);
        }

        public Task<ContactDetailsDto> GetByIdAsync(int id)
            => Task.FromResult(_store.FirstOrDefault(x => x.Id == id));

        // ---------- Commands ----------
        public Task<ResultDtoT<int>> CreateContactAsync(ContactDetailsDto dto)
        {
            var company = EnsureCompany(dto.Company);
            var newId = _ids.NextContactId();

            var employeeNumber = dto.EmployeeNumber;
            if (string.IsNullOrWhiteSpace(employeeNumber)
                && (string.Equals(dto.Type, "Employee", StringComparison.OrdinalIgnoreCase)
                 || string.Equals(dto.Type, "Trainee", StringComparison.OrdinalIgnoreCase)))
            {
                var companyId = company != null ? company.Id : 0;
                employeeNumber = _ids.NextEmployeeNumber(newId, companyId, departmentCode: "W");
            }

            var copy = new ContactDetailsDto
            {
                Id = newId,
                EmployeeNumber = employeeNumber,
                Type = dto.Type,
                Status = string.IsNullOrWhiteSpace(dto.Status) ? "aktive" : dto.Status.Trim(),
                Title = dto.Title,
                Salutation = dto.Salutation,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                EntryDate = dto.EntryDate == default(DateTime) ? DateTime.UtcNow.Date : dto.EntryDate,
                LeaveDate = dto.LeaveDate,
                CustomerType = dto.CustomerType,
                TrainingYear = dto.TrainingYear,
                ManagementLevel = dto.ManagementLevel,
                DegreeOfEmployment = dto.DegreeOfEmployment,
                Department = dto.Department,
                Role = dto.Role,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                Company = company,
                Protocol = dto.Protocol ?? new List<ProtocolDto>(),
                PersonalData = dto.PersonalData
            };

            _store.Add(copy);
            return Task.FromResult(ResultDtoT<int>.Ok(copy.Id));
        }

        public Task<ResultDto> UpdateContactAsync(int id, ContactDetailsDto dto)
        {
            var c = _store.FirstOrDefault(x => x.Id == id);
            if (c == null) return Task.FromResult(ResultDto.Fail("Not found"));

            c.EmployeeNumber = dto.EmployeeNumber ?? c.EmployeeNumber;
            if (!string.IsNullOrWhiteSpace(dto.Type)) c.Type = dto.Type.Trim();
            if (!string.IsNullOrWhiteSpace(dto.Status)) c.Status = dto.Status.Trim();
            c.Title = dto.Title ?? c.Title;
            c.Salutation = dto.Salutation ?? c.Salutation;
            if (!string.IsNullOrWhiteSpace(dto.FirstName)) c.FirstName = dto.FirstName.Trim();
            if (!string.IsNullOrWhiteSpace(dto.LastName)) c.LastName = dto.LastName.Trim();
            if (dto.EntryDate != default) c.EntryDate = dto.EntryDate;
            c.LeaveDate = dto.LeaveDate;
            c.CustomerType = dto.CustomerType ?? c.CustomerType;
            c.TrainingYear = dto.TrainingYear ?? c.TrainingYear;
            c.ManagementLevel = dto.ManagementLevel ?? c.ManagementLevel;
            c.DegreeOfEmployment = dto.DegreeOfEmployment ?? c.DegreeOfEmployment;
            c.Department = dto.Department ?? c.Department;
            if (!string.IsNullOrWhiteSpace(dto.Role)) c.Role = dto.Role.Trim();
            if (!string.IsNullOrWhiteSpace(dto.Email)) c.Email = dto.Email.Trim();
            if (!string.IsNullOrWhiteSpace(dto.PhoneNumber)) c.PhoneNumber = dto.PhoneNumber.Trim();
            if (dto.Company != null) c.Company = EnsureCompany(dto.Company);
            if (dto.Protocol != null) c.Protocol = dto.Protocol;
            if (dto.PersonalData != null) c.PersonalData = dto.PersonalData;

            return Task.FromResult(ResultDto.Ok());
        }

        public Task<ResultDto> DeactivateAsync(int id)
        {
            var c = _store.FirstOrDefault(x => x.Id == id);
            if (c == null) return Task.FromResult(ResultDto.Fail("Not found"));
            c.Status = "left";
            c.LeaveDate = DateTime.UtcNow;
            return Task.FromResult(ResultDto.Ok());
        }

        public Task<ResultDto> AddNoteAsync(int id, ProtocolDto dto)
        {
            var c = _store.FirstOrDefault(x => x.Id == id);
            if (c == null) return Task.FromResult(ResultDto.Fail("Not found"));
            (c.Protocol ??= new List<ProtocolDto>()).Add(new ProtocolDto
            {
                Author = dto.Author ?? "System",
                Date = DateTime.UtcNow,
                Message = dto.Message ?? ""
            });
            return Task.FromResult(ResultDto.Ok());
        }

        // ---------- helpers ----------
        private static ContactListItemDto ToListItem(ContactDetailsDto x)
            => new ContactListItemDto
            {
                Id = x.Id,
                EmployeeNumber = x.EmployeeNumber,
                Type = x.Type,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Status = x.Status,
                Email = x.Email,
                CompanyName = x.Company != null ? x.Company.Name : null
            };

        private CompanyDto EnsureCompany(CompanyDto dto)
        {
            if (dto == null) return null;

            var key = dto.Name ?? "";
            if (_companiesByName.TryGetValue(key, out var existing))
                return existing;

            if (dto.Id == 0) dto.Id = _ids.NextCompanyId();
            _companiesByName[key] = dto;
            return dto;
        }

        private static List<ContactDetailsDto> Seed()
            => new List<ContactDetailsDto>
            {
                new ContactDetailsDto
                {
                    Id=1,
                    EmployeeNumber="W-0001-0001",
                    Type="Employee",
                    Status="aktive",
                    Salutation="Mrs.",
                    FirstName="Lena",
                    LastName="Meyer",
                    EntryDate=new DateTime(2024,1,10),
                    ManagementLevel="1",
                    DegreeOfEmployment="100",
                    Department="Finance",
                    Role="Accountant",
                    Email="lmeyer@acme.com",
                    PhoneNumber="0790987654",
                    Company= new CompanyDto
                    {
                        Id=1,
                        Name="ACME",
                        Address= new AddressDto
                        {
                            Street="somestreet",
                            HouseNumber="4",
                            ZipCode="7000",
                            City="Las Vegas",
                            State="Nevada",
                            Country="U.S.A"
                        },
                        Email="info@acme.com",
                        PhoneNumber="0791234567",
                    },
                    PersonalData= new PersonalDataDto
                    {
                        AHVNumber="756.4235.6385.73",
                        BirthDate=new DateTime(1980,1,11),
                        Gender="girl",
                        Nationality="US",
                        Email="lena1980meyer@privat.com",
                        Phone="0764680246",
                        Address= new AddressDto
                        {
                            Street="anotherstreet",
                            HouseNumber="2",
                            ZipCode="7000",
                            City="Las Vegas",
                            State="Nevada",
                            Country="U.S.A"
                        }
                    }
                },
            };
    }
}



namespace ContactManager.Application.Abstractions.Dtos
{
    public class ContactListItemDto
    {
        public int Id { get; set; }
        public string? EmployeeNumber { get; set; }
        public string Type { get; set; }  // Employee | Trainee | Customer
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Status { get; set; } // aktive | off | left  
        public string Email { get; set; }
        public string CompanyName { get; set; }
    }

    public class ContactFilterDto
    {
        public string Search { get; set; } // name | company | email | EmployeeNumber
        public string Type { get; set; }
        public string Status { get; set; } // aktive | off | left 
    }

    public class ProtocolDto
    {
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
    }

    public class AddressDto
    {
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }

    public class CompanyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AddressDto Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class PersonalDataDto
    {
        public string? AHVNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Gender { get; set; }
        public string? Nationality { get; set; }
        public AddressDto? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }

    public class ContactDetailsDto
    {
        public int Id { get; set; }
        public string? EmployeeNumber { get; set; }
        public string Type { get; set; }
        public string Status { get; set; } // aktive | off | left
        public string? Title { get; set; }
        public string? Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public string? CustomerType { get; set; }
        public string? TrainingYear { get; set; }
        public string? ManagementLevel { get; set; }
        public string? DegreeOfEmployment { get; set; }
        public string? Department { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Company Data
        public CompanyDto Company { get; set; }

        // Protocol Data
        public List<ProtocolDto>? Protocol { get; set; }

        // PersonalData
        public PersonalDataDto? PersonalData { get; set; }

    }



    public class ResultDto
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public static ResultDto Ok() { return new ResultDto { Success = true }; }
        public static ResultDto Fail(string e) { return new ResultDto { Success = false, Error = e }; }
    }
    public class ResultDtoT<T>
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public T Value { get; set; }
        public static ResultDtoT<T> Ok(T v) { return new ResultDtoT<T> { Success = true, Value = v }; }
        public static ResultDtoT<T> Fail(string e) { return new ResultDtoT<T> { Success = false, Error = e }; }
    }
}

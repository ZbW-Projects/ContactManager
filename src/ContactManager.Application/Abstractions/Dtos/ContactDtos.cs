

namespace ContactManager.Application.Abstractions.Dtos
{
    public class ContactListItemDto
    {
        public string? EmployeeNnumber { get; set; } // Optional
        public string Type { get; set; }  // Employee | Trainee | Customer
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; } // aktive | off | left  
        public string CompanyEmail { get; set; }
        public string CompanyName { get; set; }
    }

    public class ConatactFilterDto
    {
        public string Search { get; set; } // name | company | email | EmployeeNumber
        public string Type { get; set; }
        public string Status { get; set; }
    }

    public class ProtocolEntryDto
    {
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
    }

    public class ContactDetailsDto
    {
        public string? EployeeNumber { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string? Title { get; set; }
        public string? Salutation { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public string? CustomerType { get; set; }
        public string? TrainingYear { get; set; }
        public string? ManagementLevel { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string? DegreeOfEmployment { get; set; }
        public string? Department { get; set; }
        public string Role { get; set; }

        // PersonalData
        public string? AHVNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Gender { get; set; }
        public string? Nationality { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

    }

    public class EmployeeCreateDto
    {

    }

    public class TraineeCreateDto
    {

    }

    public class CustomerCreateDto
    {

    }

    public class ContactsUpdateEmployee
    {

    }

    public class ContactsUpdateTrainee
    {

    }

    public class ContactsUpdateCustomer
    {

    }

    public class AddNoteDto
    {

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

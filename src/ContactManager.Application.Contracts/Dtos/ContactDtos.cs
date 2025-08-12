using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Application.Contracts.Dtos
{
    // Listenansicht (CM-01/02/03/10)
    public class ContactListItemDto
    {
        public string Id { get; set; }
        public string Role { get; set; }     // "Employee" | "Trainee" | "Customer"
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
    }

    // Filter für Suche/Listing (CM-01..03)
    public class ContactFilterDto
    {
        public string Search { get; set; }   // Name, Company, Email, WorkerId
        public string Role { get; set; }     // optional
        public bool? Active { get; set; }    // null=egal, true/false filtern
    }

    // Detailansicht (CM-07/08/11/13)
    public class ContactDetailsDto
    {
        public string Id { get; set; }
        public string Role { get; set; }         // Employee/Trainee/Customer
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthdate { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public bool Active { get; set; }
        // Protokoll (CM-12/13)
        public List<ProtocolEntryDto> Protocol { get; set; }
    }

    // Protokolleintrag (CM-12/13)
    public class ProtocolEntryDto
    {
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
    }

    // Create-DTOs (CM-04/05/06)
    public class EmployeeCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EntryDate { get; set; }
        public string Email { get; set; }
    }
    public class TraineeCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EntryDate { get; set; }
        public int CurrentTrainingYear { get; set; }
        public string Email { get; set; }
    }
    public class CustomerCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
    }

    // Updates (CM-07/08/09)
    public class ContactBasicsUpdateDto
    {
        public string FirstName { get; set; }  // optional
        public string LastName { get; set; }   // optional
        public string Email { get; set; }      // optional
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
    }
    public class AssignCompanyDto   // CM-08
    {
        public string Company { get; set; }
    }
    public class AddNoteDto         // CM-12
    {
        public string Author { get; set; }
        public string Message { get; set; }
        public DateTime? Date { get; set; }    // null => now
    }

    // Reporting / Export (CM-14/15)
    public class TotalsDto
    {
        public int Employees { get; set; }
        public int Trainees { get; set; }
        public int Customers { get; set; }
        public int Active { get; set; }
        public int Inactive { get; set; }
    }
    public class CsvExportRequestDto
    {
        public ContactFilterDto Filter { get; set; }  // Was exportieren?
        public string FilePath { get; set; }          // Zielpfad
        public bool IncludeHeader { get; set; }       // default true
    }

    // Standardisierte Ergebnisse
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

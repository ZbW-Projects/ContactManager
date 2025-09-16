using ContactManager.Core.Model;
using ContactManager.Core.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ContactManager.Test.Services
{
    [TestClass]
    [DoNotParallelize]
    public class ControllerUseCaseTests
    {
        [TestInitialize]
        public void Setup()
        {
            //lädt LocalStorage und setzt _contacts
            Controller.SpinData();
        }

        #region Tests Generelle Use Cases

        [TestMethod]
        public void GetList_returns_contacts()
        {
            var list = Controller.GetList();
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0, "Es sollten Kontakte vorhanden sein.");
        }

        [TestMethod]
        public void Search_finds_contact_by_lastname()
        {
            var any = Controller.GetList().First();
            var term = any.LastName;                  // search for something that exists
            var results = Controller.Search(term);
            Console.WriteLine(term);
            Assert.IsTrue(results.Any(r => r.LastName.Equals(term, StringComparison.OrdinalIgnoreCase)));
        }


        [TestMethod]
        public void DeleteContact_removes_contact()
        {
            var last = Controller.GetList().Last();
            var (ok, msg) = Controller.DeleteContact(last.Id);
            Assert.IsTrue(ok, msg);

            var list = Controller.GetList();
            Assert.IsFalse(list.Any(c => c.Id == last.Id));
        }

        #endregion

        #region Test Customer Use Cases
        [TestMethod]
        public void CreateCustomer_adds_new_customer()
        {
            var dto = new DtoCustomer
            {
                Salutation = "Herr",
                FirstName = "Max",
                LastName = "Meier",
                PhoneNumberBuisness = "0440000000",
                Status = true,
                Street = "Test",
                StreetNumber = "1",
                ZipCode = "8000",
                Place = "Zürich",
                Type = "Customer",
                CompanyName = "Test AG",
                CustomerType = 'A',
                CompanyContact = "max.meier@example.com"
            };

            var (ok, msg) = Controller.CreateCustomer(dto);
            Assert.IsTrue(ok, msg);

            var list = Controller.Search("Meier");
            Assert.IsTrue(list.Any(c => c.LastName == "Meier"));
        }

        [TestMethod]
        public void UpdateCustomer_changes_data()
        {
            var firstCustomer = Controller.GetList().FirstOrDefault(c => c.Type == "Customer");
            Assert.IsNotNull(firstCustomer);

            var dto = new DtoCustomer
            {
                Salutation = "Herr",
                FirstName = "Update",
                LastName = "Update",
                PhoneNumberBuisness = "0440003333",
                Status = false,
                Street = "Test",
                StreetNumber = "1",
                ZipCode = "8000",
                Place = "Zürich",
                Type = "Customer",
                CompanyName = "Test AG",
                CustomerType = 'A',
                CompanyContact = "update.update@test.com"
            };

            var (ok, msg) = Controller.UpdateCustomer(firstCustomer.Id, dto);
            Assert.IsTrue(ok, msg);

            var list = Controller.GetList();
            var updated = list.FirstOrDefault(c => c.Id == firstCustomer.Id);
            Assert.IsNotNull(updated);
            Assert.AreEqual("Update", updated.FirstName);
            Assert.AreEqual("Inaktiv", updated.Status);
        }

        [TestMethod]
        public void GetCustomer_returns_expected_customer()
        {
            // Arrange
            var row = Controller.Search("Update").Last();
            var customerId = row.Id;

            // Act Kunde laden
            var dto = Controller.GetCustomer(customerId);
            // Assert – prüfen ob Daten korrekt zurückkommen
            Assert.IsNotNull(dto);
            Assert.AreEqual("Update", dto.FirstName);
            Assert.AreEqual("Update", dto.LastName);
            Assert.AreEqual(customerId, dto.Id);
            Assert.AreEqual("Test ag", dto.CompanyName);
        }

        #region Messages

        [TestMethod]
        public void AddCustomerNote_persists_one_message_and_owner()
        {
            // Arrange
            var row = Controller.Search("Update").First();
            var customerId = row.Id;

            //Act füge eine Nachricht
            var (ok, msg) = Controller.AddCustomerNote(customerId, "Versucht Herrn Update zu erreichen.", "Edi");
            Assert.IsTrue(ok, msg);


            // Assert
            Assert.IsTrue(ContactManager.Core.Data.LocalStorage.Contacts.TryGetValue(customerId, out var p));
            var c2 = (Customer)p!;
            Assert.IsTrue(c2.Messages.Items.Count >= 1);
            var last = c2.Messages.Items[^1];
            Assert.AreEqual("Edi", last.Owner);
            Assert.AreEqual("Versucht Herrn Update zu erreichen.", last.Content);
            Assert.IsTrue(last.TimeStamp <= DateTime.UtcNow);

        }

        #endregion

        #endregion

        #region Test Employee Use Cases

        [TestMethod]
        public void CreateEmployee_generates_new_employee()
        {
            var dto = new DtoEmployee
            {
                Salutation = "Herr",
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1991, 1, 1),
                Gender = "M",
                Title = "",
                SocialSecurityNumber = "756.7538.5284.04",
                PhoneNumberPrivate = "0791234567",
                PhoneNumberMobile = "0791234567",
                PhoneNumberBuisness = "0441234567",
                EmailPrivat = "luca.meier.emp@test.local",
                Status = true,
                Nationality = "Schweiz",
                Street = "Bahnhofstrasse",
                StreetNumber = "1a",
                ZipCode = "8000",
                Place = "Zürich",
                Type = "Employee",
                Department = "IT",
                StartDate = new DateTime(2024, 9, 1),
                EndDate = default,
                Employment = 80,
                Role = "Developer",
                CadreLevel = 1
            };

            var (ok, msg) = Controller.CreateEmployee(dto);
            Assert.IsTrue(ok, msg);

            var list = Controller.Search("Doe");
            Assert.IsTrue(list.Any(c => c.LastName == "Doe"));

        }

        [TestMethod]
        public void UpdateEmployee_changes_data()
        {
            var firstCustomer = Controller.GetList().FirstOrDefault(c => c.Type == "Employee");
            Assert.IsNotNull(firstCustomer);

            var dto = new DtoEmployee
            {
                Salutation = "Herr",
                FirstName = "John",
                LastName = "Wayne",
                DateOfBirth = new DateTime(1991, 1, 1),
                Gender = "M",
                Title = "Dr.",
                SocialSecurityNumber = "756.7538.5284.04",
                PhoneNumberPrivate = "0791234567",
                PhoneNumberMobile = "0791234567",
                PhoneNumberBuisness = "0441234567",
                EmailPrivat = "luca.meier.emp@test.local",
                Status = false,
                Nationality = "Schweiz",
                Street = "Bahnhofstrasse",
                StreetNumber = "1a",
                ZipCode = "8000",
                Place = "Zürich",
                Type = "Employee",
                Department = "IT",
                StartDate = new DateTime(2024, 9, 1),
                EndDate = new DateTime(2026, 10, 10),
                Employment = 80,
                Role = "Security",
                CadreLevel = 2
            };

            var (ok, msg) = Controller.UpdateEmployee(firstCustomer.Id, dto);
            Assert.IsTrue(ok, msg);

            var list = Controller.GetList();
            var updated = list.FirstOrDefault(c => c.Id == firstCustomer.Id);
            Assert.IsNotNull(updated);
            Assert.AreEqual("Wayne", updated.LastName);
            Assert.AreEqual("Inaktiv", updated.Status);
        }

        [TestMethod]
        public void GetEmployee_returns_expected_employee()
        {
            // Arrange
            var row = Controller.Search("Wayne").Last();
            var employeeId = row.Id;

            // Act Kunde laden
            var dto = Controller.GetEmployee(employeeId);
            // Assert – prüfen ob Daten korrekt zurückkommen
            Assert.IsNotNull(dto);
            Assert.AreEqual("John", dto.FirstName);
            Assert.AreEqual("Wayne", dto.LastName);
            Assert.AreEqual(employeeId, dto.Id);
            Assert.AreEqual("Dr.", dto.Title);
        }

        #endregion

        #region Test Trainee Use Cases

        [TestMethod]
        public void CreateTrainee_generates_new_trainee()
        {
            var dto = new DtoTrainee
            {
                Salutation = "Frau",
                FirstName = "Sarah",
                LastName = "Müller",
                DateOfBirth = new DateTime(2008, 5, 1),
                Gender = "F",
                SocialSecurityNumber = "756.7538.5284.04",
                PhoneNumberPrivate = "0791234567",
                PhoneNumberMobile = "0791234567",
                PhoneNumberBuisness = "0441234567",
                EmailPrivat = "sarah.mueller@test.local",
                Status = true,
                Nationality = "Schweiz",
                Street = "Bahnhofstrasse",
                StreetNumber = "1a",
                ZipCode = "8000",
                Place = "Zürich",
                Type = "Trainee",
                Department = "Verkauf",
                StartDate = new DateTime(2024, 9, 1),
                EndDate = new DateTime(2027, 9, 25),
                Employment = 80,
                Role = "KV",
                TraineeYears = 3,
            };

            var (ok, msg) = Controller.CreateTrainee(dto);
            Assert.IsTrue(ok, msg);

            var list = Controller.Search("Müller");
            Assert.IsTrue(list.Any(c => c.LastName == "Müller"));
        }

        [TestMethod]
        public void UpdateTrainee_changes_data()
        {
            var firstCustomer = Controller.GetList().FirstOrDefault(c => c.Type == "Trainee");
            Assert.IsNotNull(firstCustomer);

            var dto = new DtoTrainee
            {
                Salutation = "Frau",
                FirstName = "Sarah",
                LastName = "Müller",
                DateOfBirth = new DateTime(2008, 5, 1),
                Gender = "F",
                SocialSecurityNumber = "756.7538.5284.04",
                PhoneNumberPrivate = "0790987654",
                PhoneNumberMobile = "0791234567",
                PhoneNumberBuisness = "0441234567",
                EmailPrivat = "sarah.mueller@test.local",
                Status = false,
                Nationality = "Schweiz",
                Street = "Bergenstrasse",
                StreetNumber = "16",
                ZipCode = "8000",
                Place = "Zürich",
                Type = "Trainee",
                Department = "Verkauf",
                StartDate = new DateTime(2024, 9, 1),
                EndDate = new DateTime(2027, 9, 25),
                Employment = 80,
                Role = "KV",
                TraineeYears = 3,
            };

            var (ok, msg) = Controller.UpdateTrainee(firstCustomer.Id, dto);
            Assert.IsTrue(ok, msg);

            var list = Controller.GetList();
            var updated = list.FirstOrDefault(c => c.Id == firstCustomer.Id);
            Assert.IsNotNull(updated);
            Assert.AreEqual("Müller", updated.LastName);
            Assert.AreEqual("Inaktiv", updated.Status);
        }

        [TestMethod]
        public void GetTrainee_returns_expected_trainee()
        {
            // Arrange
            var row = Controller.Search("Müller").Last();
            var traineeId = row.Id;

            // Act Kunde laden
            var dto = Controller.GetTrainee(traineeId);
            // Assert – prüfen ob Daten korrekt zurückkommen
            Assert.IsNotNull(dto);
            Assert.AreEqual("Sarah", dto.FirstName);
            Assert.AreEqual("Müller", dto.LastName);
            Assert.AreEqual(traineeId, dto.Id);
            Assert.AreEqual("", dto.Title);
        }

        #endregion 

    }
}

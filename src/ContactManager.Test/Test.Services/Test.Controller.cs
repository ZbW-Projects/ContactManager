using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ContactManager.Core.Services;

namespace ContactManager.Test.Test.Services
{
    [TestClass]
    [DoNotParallelize]
    public class ControllerUseCaseTests
    {
        [TestInitialize]
        public void Setup()
        {
            // ersetzt das Frontend: lädt LocalStorage und setzt _contacts
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
            var first = Controller.GetList().First();
            var (ok, msg) = Controller.DeleteContact(first.Id);
            Assert.IsTrue(ok, msg);

            var list = Controller.GetList();
            Assert.IsFalse(list.Any(c => c.Id == first.Id));
        }

        #endregion

        #region Test Customer Use Cases
        [TestMethod]
        public void CreateCustomer_adds_new_customer()
        {
            var dto = new DtoCustomer
            {
                Salutaion = "Herr",
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
                Id = firstCustomer.Id,
                Salutaion = "Herr",
                FirstName = "Update",
                LastName = "Kunde",
                Title = "",
                PhoneNumberBuisness = "0441112233",
                Status = false,
                Street = "Neue Strasse",
                StreetNumber = "2",
                ZipCode = "8001",
                Place = "Zürich",
                Type = "Customer",
                CompanyName = "Update GmbH",
                CustomerType = 'B',
                CompanyContact = "update@example.com"
            };

            var (ok, msg) = Controller.UpdateCustomer(firstCustomer.Id, dto);
            Assert.IsTrue(ok, msg);

            var list = Controller.GetList();
            var updated = list.FirstOrDefault(c => c.Id == firstCustomer.Id);
            Assert.IsNotNull(updated);
            Assert.AreEqual("Update", updated.FirstName);
            Assert.AreEqual("Inaktiv", updated.Status);
        }

        #region Messages


        #endregion

        #endregion
    }
}

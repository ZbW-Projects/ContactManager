using ContactManager.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContactManager.Tests.Core.Model
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CompanyName_Valid_IsNormalized()
        {
            var c = new Customer { CompanyName = "  acme AG  " };
            Assert.AreEqual("Acme ag", c.CompanyName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CompanyName_Empty_Throws()
        {
            var c = new Customer { CompanyName = "   " };
        }

        [TestMethod]
        public void CustomerType_Letter_IsUppercased()
        {
            var c = new Customer { CustomerType = 'k' };
            Assert.AreEqual('K', c.CustomerType);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CustomerType_NonLetter_Throws()
        {
            var c = new Customer { CustomerType = '1' };
        }

        [TestMethod]
        public void CompanyContact_ValidEmail_Trimmed()
        {
            var c = new Customer { CompanyContact = "  john.doe@example.com  " };
            Assert.AreEqual("john.doe@example.com", c.CompanyContact);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CompanyContact_InvalidEmail_Throws()
        {
            var c = new Customer { CompanyContact = "not-an-email" };
        }

        [TestMethod]
        public void AddMessage_Appends_To_Protocol_With_NormalizedOwner_And_UtcTimestamp()
        {
            var c = new Customer();
            c.AddMessage("Rückruf vereinbart", "  aLEx  ");

            Assert.AreEqual(1, c.Messages.Items.Count);
            var msg = c.Messages.Items[0];
            Assert.AreEqual("Rückruf vereinbart", msg.Content);
            Assert.AreEqual("Alex", msg.Owner);
            Assert.IsTrue((DateTime.UtcNow - msg.TimeStamp).TotalSeconds < 5);
        }
    }

    [TestClass]
    public class ProtocolTests
    {
        [TestMethod]
        public void Add_Creates_Message_And_Adds_To_Items()
        {
            var p = new Protocol();
            p.Add("Angebot gesendet", "Mia");

            Assert.AreEqual(1, p.Items.Count);
            Assert.AreEqual("Angebot gesendet", p.Items[0].Content);
            Assert.AreEqual("Mia", p.Items[0].Owner);
        }
    }

    [TestClass]
    public class MessageTests
    {
        [TestMethod]
        public void Ctor_Sets_Content_Timestamp_And_NormalizesOwner()
        {
            var t = new DateTime(2024, 11, 1, 8, 30, 0, DateTimeKind.Utc);
            var m = new Message("Hallo", "  lUkaS ", t);

            Assert.AreEqual("Hallo", m.Content);
            Assert.AreEqual("Lukas", m.Owner);
            Assert.AreEqual(t, m.TimeStamp);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Owner_Set_Empty_Throws()
        {
            var m = new Message("X", "Valid", DateTime.UtcNow);
            m.Owner = "   ";
        }
    }
}

using ContactManager.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactManager.Test.Core.Model
{
    [TestClass]
    public class NameHelperTests
    {
        [TestMethod]
        public void Normalize_RegularName_CapitalizesFirstAndLowercasesRest()
        {
            Assert.AreEqual("Müller", Name.Normalize("  mÜlLeR  "));
        }

        [TestMethod]
        public void Normalize_OneLetter_Works()
        {
            Assert.AreEqual("A", Name.Normalize("a"));
        }

        [TestMethod]
        public void Normalize_NullOrWhitespace_ReturnsEmpty()
        {
            Assert.AreEqual("", Name.Normalize(null));
            Assert.AreEqual("", Name.Normalize("   "));
        }
    }

    [TestClass]
    public class AhvHelperTests
    {
        [TestMethod]
        public void IsValid_ValidAhv_ReturnsTrue()
        {
            // gültiges Beispiel (EAN-13 Checksumme korrekt)
            Assert.IsTrue(AHV.IsValid("756.9217.0769.85"));
            Assert.IsTrue(AHV.IsValid("7569217076985"));
        }

        [TestMethod]
        public void IsValid_EmptyOrWhitespace_IsConsideredValid()
        {
            Assert.IsTrue(AHV.IsValid(null));
            Assert.IsTrue(AHV.IsValid("   "));
        }

        [TestMethod]
        public void IsValid_InvalidPrefixOrLength_ReturnsFalse()
        {
            Assert.IsFalse(AHV.IsValid("123.9217.0769.85")); // falsches Präfix
            Assert.IsFalse(AHV.IsValid("756.9217.0769.8"));  // zu kurz
        }

        [TestMethod]
        public void IsValid_NonDigits_ReturnsFalse()
        {
            Assert.IsFalse(AHV.IsValid("756.9217.076X.85"));
        }

        [TestMethod]
        public void IsValid_BadChecksum_ReturnsFalse()
        {
            Assert.IsFalse(AHV.IsValid("756.9217.0769.84"));
        }

        [TestMethod]
        public void Normalize_FormatsToStandard()
        {
            Assert.AreEqual("756.9217.0769.85", AHV.Normalize(" 7569217076985 "));
            Assert.AreEqual("756.9217.0769.85", AHV.Normalize("756-9217-0769-85"));
        }
    }

    [TestClass]
    public class PhoneHelperTests
    {
        [TestMethod]
        public void IsValid_SwissInternationalAndNational_ReturnsTrue()
        {
            Assert.IsTrue(Phone.IsValid("+41791234567")); // +41 79 ...
            Assert.IsTrue(Phone.IsValid("0791234567"));   // 0 79 ...
        }

        [TestMethod]
        public void IsValid_EmptyOrWhitespace_IsConsideredValid()
        {
            Assert.IsTrue(Phone.IsValid(null));
            Assert.IsTrue(Phone.IsValid("   "));
        }

        [TestMethod]
        public void IsValid_InvalidCharactersOrPattern_ReturnsFalse()
        {
            Assert.IsFalse(Phone.IsValid("+41 79 ABC 45 67")); // Buchstaben
            Assert.IsFalse(Phone.IsValid("+411234567"));       // zu kurz für +41
            Assert.IsFalse(Phone.IsValid("012345678"));        // zu kurz national
        }

        [TestMethod]
        public void Normalize_SwissInternational_AddsSpaces()
        {
            Assert.AreEqual("+41 79 123 45 67", Phone.Normalize("+41791234567"));
        }

        [TestMethod]
        public void Normalize_SwissNational_AddsSpaces()
        {
            Assert.AreEqual("079 123 45 67", Phone.Normalize("0791234567"));
            Assert.AreEqual("079 123 45 67", Phone.Normalize(" 079-123-45-67 "));
        }
    }

    [TestClass]
    public class EmailHelperTests
    {
        [TestMethod]
        public void IsValid_ProperEmail_ReturnsTrue()
        {
            Assert.IsTrue(Email.IsValid("john.doe@example.com"));
            Assert.IsTrue(Email.IsValid(" JOHN.DOE+tag@EXAMPLE.com "));
        }

        [TestMethod]
        public void IsValid_NullOrWhitespace_ReturnsFalse()
        {
            Assert.IsFalse(Email.IsValid(null));
            Assert.IsFalse(Email.IsValid("  "));
        }

        [TestMethod]
        public void IsValid_MissingAtOrLocalOrDomain_ReturnsFalse()
        {
            Assert.IsFalse(Email.IsValid("john.doeexample.com")); // kein @
            Assert.IsFalse(Email.IsValid("@example.com"));        // kein local-part
            Assert.IsFalse(Email.IsValid("john@"));               // keine Domain
        }
    }
}

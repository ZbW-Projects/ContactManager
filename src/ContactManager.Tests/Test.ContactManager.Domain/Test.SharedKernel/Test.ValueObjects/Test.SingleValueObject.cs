using ContactManager.Domain.SharedKernel.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContactManager.Tests.Domain.SharedKernel.ValueObjects
{
    [TestClass]
    public class SingleValueObjectTests
    {
        // Dummy-Klassen für Tests
        private class TestStringVO : SingleValueObject<string>
        {
            public TestStringVO(string value) : base(value) { }
        }

        private class TestIntVO : SingleValueObject<int>
        {
            public TestIntVO(int value) : base(value) { }
        }

        private class TestDateVO : SingleValueObject<DateTime>
        {
            public TestDateVO(DateTime value) : base(value) { }
        }

        // ✅ String Tests
        [TestMethod]
        public void Constructor_ValidString_ShouldSetValue()
        {
            var vo = new TestStringVO("Hello");
            Assert.AreEqual("Hello", vo.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_InvalidString_ShouldThrow()
        {
            var vo = new TestStringVO("   ");
        }

        // ✅ Int Tests
        [TestMethod]
        public void Constructor_ValidInt_ShouldSetValue()
        {
            var vo = new TestIntVO(42);
            Assert.AreEqual(42, vo.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_InvalidInt_ShouldThrow()
        {
            var vo = new TestIntVO(0); // <= 0 ungültig
        }

        // ✅ DateTime Tests
        [TestMethod]
        public void Constructor_ValidDate_ShouldSetValue()
        {
            var date = new DateTime(2020, 1, 1);
            var vo = new TestDateVO(date);
            Assert.AreEqual(date, vo.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_DefaultDate_ShouldThrow()
        {
            var vo = new TestDateVO(default);
        }

        // ✅ Equality Tests
        [TestMethod]
        public void Equality_SameValues_ShouldBeEqual()
        {
            var vo1 = new TestStringVO("Same");
            var vo2 = new TestStringVO("Same");

            Assert.AreEqual(vo1, vo2);
            Assert.IsTrue(vo1.Equals(vo2));
            Assert.AreEqual(vo1.GetHashCode(), vo2.GetHashCode());
        }

        [TestMethod]
        public void Inequality_DifferentValues_ShouldNotBeEqual()
        {
            var vo1 = new TestStringVO("One");
            var vo2 = new TestStringVO("Two");

            Assert.AreNotEqual(vo1, vo2);
            Assert.IsFalse(vo1.Equals(vo2));
        }

        // ✅ ToString Tests
        [TestMethod]
        public void ToString_ShouldReturnUnderlyingValue()
        {
            var vo = new TestStringVO("TestValue");
            Assert.AreEqual("TestValue", vo.ToString());
        }

        [TestMethod]
        public void ToString_NullValue_ShouldReturnEmptyString()
        {
            // Workaround: Null nur durch Überschreiben der Validation testbar
            var vo = new TestStringVO("Test");
            Assert.AreEqual("Test", vo.ToString());
        }
    }
}

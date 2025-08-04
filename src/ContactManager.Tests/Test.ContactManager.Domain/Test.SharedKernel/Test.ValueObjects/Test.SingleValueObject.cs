using ContactManager.Domain.SharedKernel.ValueObjects;
using Newtonsoft.Json.Linq;

namespace ContactManager.Tests.Test.ContactManager.Domain.Test.SharedKernel.Test.ValueObjects
{

    // ====================
    //Dummy-Wert-Objekte für Tests
    // ====================

    // Dummy implementation für string
    internal class DummyStringValueObject : SingleValueObject<string>
    {
        internal DummyStringValueObject(string value) : base(value) { }
    }

    // Dummy implementaion für DateTime
    internal class DummyDateValueObject : SingleValueObject<DateTime>
    {
        internal DummyDateValueObject(DateTime value) : base(value) { }
    }

    // Dummy implementaion für Integers
    internal class DummyIntValueObject : SingleValueObject<int>
    {
        internal DummyIntValueObject(int value) : base(value) { }
    }

    // ========================
    // Test-Szenarien
    // ========================

    [TestClass]
    public class TestSingleValueObject
    {


        // ============================
        // String Tests
        // ============================

        [TestMethod]
        public void Should_Create_StingValueObject_When_Valid()
        {
            // Arrange
            var value = "ValidString";

            // Act 
            var obj = new DummyStringValueObject(value);

            // Assert
            Assert.AreEqual(value, obj.Value);
            Assert.AreEqual(value, obj.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_When_StringValueObject_Is_Null()
        {
            _ = new DummyStringValueObject(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_When_StringValueObject_Is_Empty()
        {
            _ = new DummyStringValueObject("  ");
        }



        // ================================
        // Date test
        // ================================

        [TestMethod]
        public void Should_Create_DateValueObject_When_Valid()
        {
            // Arrange
            var now = DateTime.Now;

            // Act
            var obj = new DummyDateValueObject(now);

            // Assert
            Assert.AreEqual(now, obj.Value);
            Assert.AreEqual(now.ToString(), obj.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_When_DateValueObject_Is_Defalut()
        {
            _ = new DummyDateValueObject(default);
        }

        // ===============================
        // Integer Test
        // ===============================

        [TestMethod]
        public void Should_CreateIntValueObject_When_Valid()
        {
            // Arrange
            int integer = 1;
            // Act
            var obj = new DummyIntValueObject(integer);
            // Assert
            Assert.AreEqual(integer, obj.Value);
            Assert.AreEqual(integer.ToString(), obj.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_When_IntValueObject_Is_Null()
        {
            _ = new DummyIntValueObject(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_When_IntValueObject_Is_Negative()
        {
            _ = new DummyIntValueObject(-2);
        }


        // Es können verschiedene Typen getestet werden, zum Beispiel Integer.
    }
}

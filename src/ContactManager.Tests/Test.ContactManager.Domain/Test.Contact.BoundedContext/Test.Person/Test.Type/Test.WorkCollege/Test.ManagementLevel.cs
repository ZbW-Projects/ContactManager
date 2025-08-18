using ContactManager.Domain.Contact.BoundedContext.Person.Type.WorkCollege;
using ContactManager.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace ContactManager.Tests.Domain.Contact.BoundedContext.Person.Type.WorkCollege
{
    [TestClass]
    public class ManagementLevelTests
    {
        [TestMethod]
        public void List_Returns_All_Levels_In_Id_Order()
        {
            // Act
            var all = ManagementLevel.List().ToArray();

            // Assert
            CollectionAssert.AreEqual(
                new[]
                {
                    ManagementLevel.Zero,
                    ManagementLevel.One,
                    ManagementLevel.Two,
                    ManagementLevel.Three,
                    ManagementLevel.Four,
                    ManagementLevel.Five
                },
                all);
        }

        [TestMethod]
        public void FromId_ValidIds_Returns_Instances()
        {
            Assert.AreSame(ManagementLevel.Zero, ManagementLevel.FromId(0));
            Assert.AreSame(ManagementLevel.One, ManagementLevel.FromId(1));
            Assert.AreSame(ManagementLevel.Two, ManagementLevel.FromId(2));
            Assert.AreSame(ManagementLevel.Three, ManagementLevel.FromId(3));
            Assert.AreSame(ManagementLevel.Four, ManagementLevel.FromId(4));
            Assert.AreSame(ManagementLevel.Five, ManagementLevel.FromId(5));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromId_Invalid_Throws()
        {
            _ = ManagementLevel.FromId(99);
        }

        [TestMethod]
        public void FromName_Valid_Returns_Instance_CaseInsensitive_And_Trimmed()
        {
            Assert.AreSame(ManagementLevel.Zero, ManagementLevel.FromName("0"));
            Assert.AreSame(ManagementLevel.One, ManagementLevel.FromName("  1  "));
            Assert.AreSame(ManagementLevel.Two, ManagementLevel.FromName("two".Replace("two", "2"))); // gleiche Zeichenfolge "2"
            Assert.AreSame(ManagementLevel.Three, ManagementLevel.FromName("3"));
            Assert.AreSame(ManagementLevel.Four, ManagementLevel.FromName("4"));
            Assert.AreSame(ManagementLevel.Five, ManagementLevel.FromName("5"));

            // Case-insensitive → hier zwar Ziffern, aber testen wir dennoch
            Assert.AreSame(ManagementLevel.Five, ManagementLevel.FromName("5".ToUpper()));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromName_Whitespace_Throws()
        {
            _ = ManagementLevel.FromName("   ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromName_Unknown_Throws()
        {
            _ = ManagementLevel.FromName("X");
        }

        [TestMethod]
        public void Equality_And_HashCode_By_Type_And_Id()
        {
            var a = ManagementLevel.Three;
            var b = ManagementLevel.FromId(3);

            Assert.IsTrue(a.Equals(b));
            Assert.IsTrue(a == b);
            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());

            Assert.IsTrue(ManagementLevel.One != ManagementLevel.Two);
        }

        [TestMethod]
        public void CompareTo_Sorts_By_Id()
        {
            Assert.IsTrue(ManagementLevel.Zero.CompareTo(ManagementLevel.One) < 0);
            Assert.IsTrue(ManagementLevel.Five.CompareTo(ManagementLevel.Four) > 0);
            Assert.AreEqual(0, ManagementLevel.Two.CompareTo(ManagementLevel.FromId(2)));
        }

        [TestMethod]
        public void Convenience_IsX_Methods_Work()
        {
            Assert.IsTrue(ManagementLevel.Zero.IsZero());
            Assert.IsTrue(ManagementLevel.One.IsOne());
            Assert.IsTrue(ManagementLevel.Two.IsTwo());
            Assert.IsTrue(ManagementLevel.Three.IsThree());
            Assert.IsTrue(ManagementLevel.Four.IsFour());
            Assert.IsTrue(ManagementLevel.Five.IsFive());

            Assert.IsFalse(ManagementLevel.Zero.IsOne());
            Assert.IsFalse(ManagementLevel.One.IsZero());
            Assert.IsFalse(ManagementLevel.Five.IsFour());
        }

        [TestMethod]
        public void ToString_Returns_Name()
        {
            Assert.AreEqual("3", ManagementLevel.Three.ToString());
        }
    }
}

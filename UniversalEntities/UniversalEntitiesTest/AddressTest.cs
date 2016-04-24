using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniversalEntities;

namespace UniversalEntitiesTest
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void SortAddressLines()
        {
            Address a1 = new Address();
            a1.Line1 = "1";
            a1.Line2 = "2";
            a1.Line3 = "3";
            a1.SortAddressLines();
            Assert.AreEqual("1", a1.Line1);
            Assert.AreEqual("2", a1.Line2);
            Assert.AreEqual("3", a1.Line3);

            a1.Line1 = "1";
            a1.Line2 = "3";
            a1.Line3 = "2";
            a1.SortAddressLines();
            Assert.AreEqual("1", a1.Line1);
            Assert.AreEqual("3", a1.Line2);
            Assert.AreEqual("2", a1.Line3);

            a1.Line1 = "2";
            a1.Line2 = "3";
            a1.Line3 = "1";
            a1.SortAddressLines();
            Assert.AreEqual("2", a1.Line1);
            Assert.AreEqual("3", a1.Line2);
            Assert.AreEqual("1", a1.Line3);

            a1.Line1 = "2";
            a1.Line2 = "1";
            a1.Line3 = "3";
            a1.SortAddressLines();
            Assert.AreEqual("2", a1.Line1);
            Assert.AreEqual("1", a1.Line2);
            Assert.AreEqual("3", a1.Line3);

            a1.Line1 = "3";
            a1.Line2 = "1";
            a1.Line3 = "2";
            a1.SortAddressLines();
            Assert.AreEqual("3", a1.Line1);
            Assert.AreEqual("1", a1.Line2);
            Assert.AreEqual("2", a1.Line3);

            a1.Line1 = "3";
            a1.Line2 = "2";
            a1.Line3 = "1";
            a1.SortAddressLines();
            Assert.AreEqual("3", a1.Line1);
            Assert.AreEqual("2", a1.Line2);
            Assert.AreEqual("1", a1.Line3);


            a1.Line1 = "";
            a1.Line2 = "1";
            a1.Line3 = "2";
            a1.SortAddressLines();
            Assert.AreEqual("1", a1.Line1);
            Assert.AreEqual("2", a1.Line2);
            Assert.AreEqual("", a1.Line3);

            a1.Line1 = "";
            a1.Line2 = "2";
            a1.Line3 = "1";
            a1.SortAddressLines();
            Assert.AreEqual("2", a1.Line1);
            Assert.AreEqual("1", a1.Line2);
            Assert.AreEqual("", a1.Line3);

            a1.Line1 = "1";
            a1.Line2 = "";
            a1.Line3 = "2";
            a1.SortAddressLines();
            Assert.AreEqual("1", a1.Line1);
            Assert.AreEqual("2", a1.Line2);
            Assert.AreEqual("", a1.Line3);

            a1.Line1 = "2";
            a1.Line2 = "";
            a1.Line3 = "1";
            a1.SortAddressLines();
            Assert.AreEqual("2", a1.Line1);
            Assert.AreEqual("1", a1.Line2);
            Assert.AreEqual("", a1.Line3);

            a1.Line1 = "1";
            a1.Line2 = "2";
            a1.Line3 = "";
            a1.SortAddressLines();
            Assert.AreEqual("1", a1.Line1);
            Assert.AreEqual("2", a1.Line2);
            Assert.AreEqual("", a1.Line3);

            a1.Line1 = "2";
            a1.Line2 = "1";
            a1.Line3 = "";
            a1.SortAddressLines();
            Assert.AreEqual("2", a1.Line1);
            Assert.AreEqual("1", a1.Line2);
            Assert.AreEqual("", a1.Line3);

            a1.Line1 = "";
            a1.Line2 = "1";
            a1.Line3 = "";
            a1.SortAddressLines();
            Assert.AreEqual("1", a1.Line1);
            Assert.AreEqual("", a1.Line2);
            Assert.AreEqual("", a1.Line3);

            a1.Line1 = "";
            a1.Line2 = "";
            a1.Line3 = "1";
            a1.SortAddressLines();
            Assert.AreEqual("1", a1.Line1);
            Assert.AreEqual("", a1.Line2);
            Assert.AreEqual("", a1.Line3);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniversalEntities;

namespace UniversalEntitiesTest
{
    [TestClass]
    public class PersonNameTest
    {
        [TestMethod]
        public void FullNameTest()
        {
            PersonName name = new PersonName();
            name.Title = "Dr.";
            name.First = "Gaurang";
            name.Middle = "Friend";
            //name.Last = "Gupta";

            Assert.AreEqual("Dr. Gaurang",name.Full);
            Assert.AreEqual("DR. GAURANG", name.Full, true);


        }


    }
}

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstproduct
    {
        [TestMethod]
        public void Instanceok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //test to see that it exists
            Assert.IsNotNull(Anproduct);
        }

        [TestMethod]
        public void Activeok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            Anproduct.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.Active, TestData);
        }

        [TestMethod]
        public void DateAddedok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Anproduct.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.DateAdded, TestData);
        }

        [TestMethod]
        public void AddressIdok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Anproduct.AddressID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.AddressID, TestData);
        }

        [TestMethod]
        public void CountryCodeok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            string TestData = "UK";
            //assign the data to the property
            Anproduct.CountryCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.CountryCode, TestData);
        }
        [TestMethod]
        public void HouseNumberok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            string TestData = "1";
            //assign the data to the property
            Anproduct.HouseNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.HouseNumber, TestData);
        }

        [TestMethod]
        public void Postcodeok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            string TestData = "BB1 1BB";
            //assign the data to the property
            Anproduct.Postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.Postcode, TestData);
        }

        [TestMethod]
        public void Streetok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            string TestData = "Test Street";
            //assign the data to the property
            Anproduct.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.Street, TestData);
        }

        [TestMethod]
        public void Townok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            string TestData = "Test Town";
            //assign the data to the property
            Anproduct.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.Town, TestData);
        }
    }
}


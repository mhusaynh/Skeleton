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
        public void ProductIDok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Anproduct.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.ProductID, TestData);
        }

        [TestMethod]
        public void ProductNameok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            string TestData = "Test Product";
            //assign the data to the property
            Anproduct.ProductName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.ProductName, TestData);
        }
        [TestMethod]
        public void Priceok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            decimal TestData = 9.99m;
            //assign the data to the property
            Anproduct.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.Price, TestData);
        }
        [TestMethod]
        public void Colourok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            string TestData = "Red";
            //assign the data to the property
            Anproduct.Colour = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.Colour, TestData);
        }
        [TestMethod]
        public void Quantityok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            Int32 TestData = 100;
            //assign the data to the property
            Anproduct.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.Quantity, TestData);
        }
        [TestMethod]
        public void Categoryok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            string TestData = "Electronics";
            //assign the data to the property
            Anproduct.Category = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.Category, TestData);
        }
        [TestMethod]
        public void Brandok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //create some test data to assign to the property
            string TestData = "Test Brand";
            //assign the data to the property
            Anproduct.Brand = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Anproduct.Brand, TestData);
        }
    }
}


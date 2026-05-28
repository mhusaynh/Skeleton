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
        [TestMethod]
        public void FindMethodok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            //test to see that the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductIDFound()
            {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            // 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            if (Anproduct.ProductID != ProductID)
            {
                OK = false;
            }
            //check the product ID
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            if (Anproduct.ProductName != "Test Product")
            {
                OK = false;
            }
            //check the product name
            Assert.IsTrue(OK);



        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            if (Anproduct.Price != 9.99m)
            {
                OK = false;
            }
            //check the price
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestColourFound()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            if (Anproduct.Colour != "Red")
            {
                OK = false;
            }
            //check the colour
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            if (Anproduct.Quantity != 100)
            {
                OK = false;
            }
            //check the quantity
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCategoryFound()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            if (Anproduct.Category != "Electronics")
            {
                OK = false;
            }
            //check the category
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestBrandFound()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            if (Anproduct.Brand != "Test Brand")
            {
                OK = false;
            }
            //check the brand
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            if (Anproduct.Active != true)
            {
                OK = false;
            }
            //check the active status
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            if (Anproduct.DateAdded != Convert.ToDateTime("01/01/2020"))
            {
                OK = false;
            }
            //check the date added
            Assert.IsTrue(OK);
        }
    }
}






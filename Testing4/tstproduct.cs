using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstproduct
    {
        string ProductName = "Test Product";
        string Price = "9.99";
        string Colour = "Red";
        string Quantity = "100";
        string Category = "Test Category";
        string Brand = "Test Brand";
        //string Active = "true";
        string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void Instanceok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //test to see that it exists
            Assert.IsNotNull(Anproduct);
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
            string TestData = "Test Category";
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
        public void FindMethodok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductID = 5;
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
            Int32 ProductID = 5;
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
            Int32 ProductID = 5;
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
            Int32 ProductID = 5;
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
            Int32 ProductID = 5;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            if (Anproduct.Colour != "Black")
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
            Int32 ProductID = 5;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            if (Anproduct.Quantity != 10)
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
            Int32 ProductID = 5;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            if (Anproduct.Category != "Test Category")
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
            Int32 ProductID = 5;
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
            Int32 ProductID = 5;
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
            Int32 ProductID = 5;
            //invoke the method
            Found = Anproduct.Find(ProductID);
            if (Anproduct.DateAdded != Convert.ToDateTime("NULL"))
            {
                OK = false;
            }
            //check the date added
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = ""; //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
                    {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "a"; //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "aa"; //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = new string('a', 49); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMax()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = new string('a', 50); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = new string('a', 51); //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMid() 
            {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = new string('a', 25); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "-1"; //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "0"; //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "1"; //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "50.00"; //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "this is not a price"; //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ColourMinLessOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = ""; //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ColourMin()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = "a"; //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ColourMinPlusOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = "aa"; //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ColourMaxLessOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = new string('a', 49); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ColourMax()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = new string('a', 50); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ColourMaxPlusOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = new string('a', 51); //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ColourMid()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = new string('a', 25); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "-1"; //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "0"; //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "1"; //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "50"; //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityInvalidData()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "this is not a quantity"; //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CategoryMinLessOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = ""; //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CategoryMin()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = "a"; //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryMinPlusOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = "aa"; //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryMaxLessOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = new string('a', 49); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryMax()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = new string('a', 50); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryMaxPlusOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = new string('a', 51); //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CategoryMid()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = new string('a', 25); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BrandMinLessOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = ""; //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BrandMin()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = "a"; //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BrandMinPlusOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = "aa"; //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BrandMaxLessOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = new string('a', 49); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BrandMax()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = new string('a', 50); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BrandMaxPlusOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = new string('a', 51); //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BrandMid()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = new string('a', 25); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateAdded = DateTime.MinValue.ToString(); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateAdded = DateTime.MinValue.AddDays(-1).ToString(); //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateAdded = DateTime.MinValue.ToString(); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateAdded = DateTime.MinValue.AddDays(1).ToString(); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateAdded = DateTime.MaxValue.ToString(); //this should be ok
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is ok (i.e. there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateAdded = "this is not a date"; //this should trigger an error
            //invoke the method
            Error = Anproduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
            //test to see that the result is not ok (i.e. there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        
    }
}








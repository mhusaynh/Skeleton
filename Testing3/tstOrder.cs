using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //create some test data to pass the method
        string Product = "Nike Air Force";
        string Price = "30.00";
        string DateAdded = DateTime.Now.ToShortDateString();
        string Quantity = "2";

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);

        }

        [TestMethod]
        public void InstanceNotOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Completed = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Completed, TestData);
        }


        [TestMethod]
        public void OrderIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void ProductPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "nike air max";
            //assign the data to the property
            AnOrder.Product = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Product, TestData);
        }

        [TestMethod]
        public void PricePropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            decimal TestData = 2999m;
            //assign the data to the property
            AnOrder.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Price, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOk()
        {
            //create some instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOk()
        {
            //create some instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnOrder.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }

        [TestMethod]
        public void CompletedPropertyOk()
        {
            //create some instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Completed = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Completed, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validator
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 3;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 3;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderId != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the product property
            if (AnOrder.Product != "Nike Air Max")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the price property
            if (AnOrder.Price != 34)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 3;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the dateAdded property
            if (AnOrder.DateAdded != Convert.ToDateTime("06/07/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 3;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the quantity property
            if (AnOrder.Quantity != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompletedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the completed property
            if (AnOrder.Completed != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Product = null;
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Product = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Product = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Product = "aaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "aaa");
        }

        [TestMethod]
        public void ProductExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Product = "";
            Product = Product.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "This is not a date!";
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test price data
            decimal TestPrice;
            //set the price to a extreme min value
            TestPrice = -1000000m;
            //convert the price variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test price data
            decimal TestPrice;
            //set the price to whatever the price is minus 1
            TestPrice = 0.00m;
            //convert the price variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test price data
            decimal TestPrice;
            //set the price to the min value
            TestPrice = 0.01m;
            //convert the price variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //string variable to store any error message
                String Error = "";
                //create a variable to store the test price data
                decimal TestPrice;
                //set the price to the min value plus 1
                TestPrice = 1.00m;
                //convert the price variable to a string variable
                string Price = TestPrice.ToString();
                //invoke the method
                Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //string variable to store any error message
                String Error = "";
                //create a variable to store the test price data
                decimal TestPrice;
                //set the price to the min value
                TestPrice = 999999.99m;
                //convert the price variable to a string variable
                string Price = TestPrice.ToString();
                //invoke the method
                Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test price data
            decimal TestPrice;
            //set the price to the min value
            TestPrice = 1000000.00m;
            //convert the price variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test price data
            decimal TestPrice;
            //set the price to the min value
            TestPrice = 1000000.01m;
            //convert the price variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test price data
            decimal TestPrice;
            //set the price to the min value
            TestPrice = 500.00m;
            //convert the price variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test price data
            decimal TestPrice;
            //set the price to the min value
            TestPrice = 1000000000.00m;
            //convert the price variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string Price = "pay";
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test quantity data
            int TestQuantity;
            //set the quantity to a extreme min value
            TestQuantity = -1000000;
            //convert the quantity variable to a string variable
            string Quantity = TestQuantity.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test quantity data
            int TestQuantity;
            //set the quantity to a extreme min value
            TestQuantity = 0;
            //convert the quantity variable to a string variable
            string Quantity = TestQuantity.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test quantity data
            int TestQuantity;
            //set the quantity to a extreme min value
            TestQuantity = 1;
            //convert the quantity variable to a string variable
            string Quantity = TestQuantity.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test quantity data
            int TestQuantity;
            //set the quantity to a extreme min value
            TestQuantity = 2;
            //convert the quantity variable to a string variable
            string Quantity = TestQuantity.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test quantity data
            int TestQuantity;
            //set the quantity to a extreme min value
            TestQuantity = 9999;
            //convert the quantity variable to a string variable
            string Quantity = TestQuantity.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test quantity data
            int TestQuantity;
            //set the quantity to a extreme min value
            TestQuantity = 10000;
            //convert the quantity variable to a string variable
            string Quantity = TestQuantity.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test quantity data
            int TestQuantity;
            //set the quantity to a extreme min value
            TestQuantity = 10001;
            //convert the quantity variable to a string variable
            string Quantity = TestQuantity.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test quantity data
            int TestQuantity;
            //set the quantity to a extreme min value
            TestQuantity = 500;
            //convert the quantity variable to a string variable
            string Quantity = TestQuantity.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test quantity data
            int TestQuantity;
            //set the quantity to a extreme min value
            TestQuantity = 1000000000;
            //convert the quantity variable to a string variable
            string Quantity = TestQuantity.ToString();
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string Quantity = "3.65";
            //invoke the method
            Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

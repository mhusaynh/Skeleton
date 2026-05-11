using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstAdmin
    {

        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();

            //test to see that it exists
            Assert.IsNotNull(AnAdmin);

        }
        [TestMethod]
        public void StockOk()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnAdmin.Stock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAdmin.Stock, TestData);
        }
        [TestMethod]
        public void AdminidOK()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAdmin.Adminid = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAdmin.Adminid, TestData);
        }
        [TestMethod]
        public void UsernameOK()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //create some test data to assign to the property
            string TestData = "name";
            //assign the data to the property
            AnAdmin.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAdmin.UserName, TestData);
        }
        [TestMethod]
        public void PasswordOK()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //create some test data to assign to the property
            string TestData = "password123";
            //assign the data to the property
            AnAdmin.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAdmin.Password, TestData);
        }
        [TestMethod]
        public void EmailOk()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //create some test data to assign to the property
            string TestData = "admin@text";
            //assign the data to the property
            AnAdmin.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAdmin.Email, TestData);

        }
        [TestMethod]
        public void OrderOk()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //create some test data to assign to the property
            string TestData = "1";
            //assign the data to the property
            AnAdmin.Order = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAdmin.Order, TestData);
        }

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Adminid = 1;
            //invoke the method
            Found = AnAdmin.Find(Adminid);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/

        [TestMethod]
        public void TestAdminidFound()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Adminid = 1;
            //invoke the method
            Found = AnAdmin.Find(Adminid);
            //check the Adminid
            if (AnAdmin.Adminid != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUserNameFound()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Adminid = 1;
            //invoke the method
            Found = AnAdmin.Find(Adminid);
            //check the UserName
            if (AnAdmin.UserName != "name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Adminid = 1;
            //invoke the method
            Found = AnAdmin.Find(Adminid);
            //check the Email
            if (AnAdmin.Email != "admin@text")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Adminid = 1;
            //invoke the method
            Found = AnAdmin.Find(Adminid);
            //check the Password
            if (AnAdmin.Password != "password123")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderFound()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Adminid = 1;
            //invoke the method
            Found = AnAdmin.Find(Adminid);
            //check the Order
            if (AnAdmin.Order != "1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockFound()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Adminid = 1;
            //invoke the method
            Found = AnAdmin.Find(Adminid);
            //check the Stock
            if (AnAdmin.Stock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
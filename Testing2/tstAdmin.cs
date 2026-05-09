using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstAdmin
    {
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
    }
}
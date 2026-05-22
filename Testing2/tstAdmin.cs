using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstAdmin
    {
        //good test data
        //create some test data to pass to the method
        string UserName = "John";
        string Email = "john12@gmail.com";
        string Password = "john123";
        string Order = "22";

        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAdmins);

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
            if (AnAdmin.UserName != "John")
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
            if (AnAdmin.Email != "john12@gmail.com")
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
            if (AnAdmin.Password != "john123")
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
            if (AnAdmin.Order != "22")
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
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = ""; //this should trigger an error
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMin()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "a"; //this should be ok
                                   //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "aa"; //this should be ok
                                    //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMax()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMid()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "aaa"; //this should be ok
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "aaaaaaa"; //this should trigger an error
                                         //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "";
            UserName = UserName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should trigger an error
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "a@a.com"; //this should be ok
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aa@a.com"; //this should be ok
                                       //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        { //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(49, 'a');
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = ""; //this should trigger an error
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "a"; //this should be ok
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aa"; //this should be ok
                                    //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(15, 'a');
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(16, 'a');
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(8, 'a');
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(500, 'a'); //this should fail
                                                    //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderMinLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Order = ""; //this should trigger an error
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderMin()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Order = "a"; //this should be ok
                                //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Order = "aa"; //this should be ok
                                 //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Order = "aaaaa";
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderMax()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Order = "aaaaaa";
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Order = "aaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderMid()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Order = "aaa";
            //invoke the method
            Error = AnAdmin.Valid(UserName, Email, Password, Order);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
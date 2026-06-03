using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrderUser
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserId, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Ashik";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "ashik100";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOk()
        {
            //create some instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Orders";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOk()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Ashik";
            string Password = "ashik100";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUsernamePWFound()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string Username = "Ashik";
            string Password = "ashik100";
            //invoke the method
            Found = AnUser.FindUser(Username, Password);
            //check the user id property
            if (AnUser.UserName != Username && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}

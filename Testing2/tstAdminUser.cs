using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstAdminUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAdminUser AnUser = new clsAdminUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsAdminUser AnUser = new clsAdminUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserId, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsAdminUser AnUser = new clsAdminUser();
            //create some test data to assign to the property
            string TestData = "Allenso";
            //assign the data to the property
            AnUser.Username = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Username, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsAdminUser AnUser = new clsAdminUser();
            //create some test data to assign to the property
            string TestData = "allenso123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartementPropertyOK()
        {
            //create an instance of the class we want to create
            clsAdminUser AnUser = new clsAdminUser();
            //create some test data to assign to the property
            string TestData = "Admin";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsAdminUser AnUser = new clsAdminUser();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string Username = "Allenso";
            string Password = "allenso123";
            //invoke the method
            Found = AnUser.FindUser(Username, Password);
            //test to see that the result is true
            Assert.IsTrue(Found);
        }
    }
}

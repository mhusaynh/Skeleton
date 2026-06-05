using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class tstProductUser
    {
        [TestMethod]
        public void Instance()
        {
            clsProductUser AnUser = new clsProductUser();

            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyok()
        {
            clsProductUser AnUser = new clsProductUser();
            int TestData = 6;
            AnUser.UserID = TestData;
            Assert.AreEqual(TestData, AnUser.UserID);

        }
        [TestMethod]
        public void UserNamePropertyok()
        {
            clsProductUser AnUser = new clsProductUser();
            string TestData = "sohail1025";
            AnUser.Username = TestData;
            Assert.AreEqual(TestData, AnUser.Username);
        }
        [TestMethod]
        public void PasswordPropertyok()
        {
            clsProductUser AnUser = new clsProductUser();
            string TestData = "Password1025";
            AnUser.Password = TestData;
            Assert.AreEqual(TestData, AnUser.Password);
        }
        [TestMethod]
        public void DepartmentPropertyok()
        {
            clsProductUser AnUser = new clsProductUser();
            string TestData = "sohail1025";
            AnUser.Department = TestData;
            Assert.AreEqual(TestData, AnUser.Department);
        }
        [TestMethod]
        public void FindUserMethodok()
        {
            clsProductUser AnUser = new clsProductUser();

            Boolean Found = false;
            string Username = "sohail1025";
            string Password = "Password1025";
            Found = AnUser.FindUser(Username, Password);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsProductUser AnUser = new clsProductUser();

            Boolean Found = false;
            Boolean OK = true;
            string Username = "sohail1025";
            string Password = "Password1025";
            Found = AnUser.FindUser(Username, Password);

            if (AnUser.Username != Username || AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}

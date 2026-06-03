using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsUser AnAddress = new clsUser();

            Assert.IsNotNull(AnAddress);
        }

        public void UserIdPropertyOK()
        {
            clsUser AUser = new clsUser();

            Int32 TestData = 1;

            AUser.UserId = 1;

            Assert.AreEqual(AUser.UserId, TestData);
        }
        public void UserNamePropertyOK()
        {
            clsUser AUser = new clsUser();
            String TestData = "Test";
            AUser.UserName = "Test";
            Assert.AreEqual(AUser.UserName, TestData);
        }

        public void EmailPropertyOK()
        {
            clsUser AUser = new clsUser();

            String TestData = "Test";

            AUser.Email = "Test";

            Assert.AreEqual(AUser.Email, TestData);
        }

        public void PasswordPropertyOK()
        {
            clsUser AUser = new clsUser();

            String TestData = "Test";

            AUser.Password = "Test";

            Assert.AreEqual(AUser.Password, TestData);
        }

        public void AddressPropertyOK()
        {
            clsUser AUser = new clsUser();

            String TestData = "Test";

            AUser.Address = "Test";

            Assert.AreEqual(AUser.Address, TestData);
        }

        public void ActivePropertyOK()
        {
            clsUser AUser = new clsUser();

            Boolean TestData = true;

            AUser.Active = true;

            Assert.AreEqual(AUser.Active, TestData);
        }

        public void DateAddedPropertyOK()
        {
            clsUser AUser = new clsUser();

            DateTime TestData = DateTime.Now.Date;

            AUser.DateAdded = DateTime.Now.Date;

            Assert.AreEqual(AUser.DateAdded, TestData);
        }

        public void FindMethodOK()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            Assert.IsTrue(Found);
        }

        public void TestUserIdFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            if (AUser.UserId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestEmailFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            if (AUser.Email != "Test")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestPasswordFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            if (AUser.Password != "Test")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
         public void TestAddressFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            if (AUser.Address != "Test")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
         }
         public void TestActiveFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            if (AUser.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
         }
          public void TestDateAddedFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            if (AUser.DateAdded != DateTime.Now.Date)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestUserNameFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            if (AUser.UserName != "Test")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

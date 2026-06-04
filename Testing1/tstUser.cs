using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class TstUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsUser AnAddress = new clsUser();

            Assert.IsNotNull(AnAddress);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void UserIdPropertyOK()
        {
            clsUser AUser = new clsUser();

            Int32 TestData = 1;

            AUser.UserId = 1;

            Assert.AreEqual(AUser.UserId, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsUser AUser = new clsUser();
            String TestData = "Test";
            AUser.UserName = "Test";
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsUser AUser = new clsUser();

            String TestData = "Test";

            AUser.Email = "Test";

            Assert.AreEqual(AUser.Email, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsUser AUser = new clsUser();

            String TestData = "Test";

            AUser.Password = "Test";

            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsUser AUser = new clsUser();

            String TestData = "Test";

            AUser.Address = "Test";

            Assert.AreEqual(AUser.Address, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsUser AUser = new clsUser();

            Boolean TestData = true;

            AUser.Active = true;

            Assert.AreEqual(AUser.Active, TestData);
        }

        [TestMethod]
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
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsUser AUser = new clsUser();

            DateTime TestData = DateTime.Now.Date;

            AUser.DateAdded = DateTime.Now.Date;

            Assert.AreEqual(AUser.DateAdded, TestData);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            if (AUser.Email != "husayn@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            if (AUser.Password != "Password123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            if (AUser.Address != "123 Address")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
         }
        [TestMethod]
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
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            if (AUser.DateAdded != Convert.ToDateTime("05/05/2026 12:10:54"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUserNameFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 1;
            Found = AUser.Find(UserId);
            if (AUser.UserName != "HUSAYN")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

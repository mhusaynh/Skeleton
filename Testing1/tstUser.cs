using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class TstUser
    {
        string UserName = "HUSAYN";
        string Email = "husayn@gmail.com";
        string Password = "Password123";
        string Address = "123 Address";
        DateTime DateAdded = DateTime.Now.Date;
        [TestMethod]
        public void ValidMethodOK()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            Error = AUser.Valid(AUser.UserName, AUser.Email, AUser.Password, AUser.Address, AUser.DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
            {
            clsUser AUser = new clsUser();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            Error = AUser.Valid(AUser.UserName, AUser.Email, AUser.Password, AUser.Address, TestDate);
            Assert.AreNotEqual(Error, "");
        }
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
        [TestMethod]
        public void UserNameMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string UserName = "";
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string UserName = "a";
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string UserName = "aa";
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string UserName = "";
            UserName.PadRight(49, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string UserName = "";
            UserName.PadRight(50, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string UserName = "";
            UserName.PadRight(51, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string UserName = "";
            UserName.PadRight(25, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameExtremeMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string UserName = "";
            UserName = UserName.PadRight(500, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Email = "";
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Email = "a";
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Email = "aa";
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Email = "";
            Email.PadRight(49, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Email = "";
            Email.PadRight(50, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Email = "";
            Email.PadRight(51, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Email = "";
            Email.PadRight(25, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(500, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Password = "";
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Password = "a";
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Password = "aa";
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Password = "";
            Password.PadRight(49, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Password = "";
            Password.PadRight(50, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Password = "";
            Password.PadRight(51, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Password = "";
            Password.PadRight(25, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordExtremeMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(500, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Address = "";
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Address = "a";
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Address = "aa";
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Address = "";
            Address.PadRight(49, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Address = "";
            Address.PadRight(50, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Address = "";
            Address.PadRight(51, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Address = "";
            Address.PadRight(25, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(500, 'a');
            Error = AUser.Valid(UserName, Email, Password, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);

            Error = AUser.Valid(UserName, Email, Password, Address, TestDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            Error = AUser.Valid(UserName, Email, Password, Address, TestDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            Error = AUser.Valid(UserName, Email, Password, Address, TestDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            Error = AUser.Valid(UserName, Email, Password, Address, TestDate);
            Assert.AreEqual(Error, "");
        }

    }
}

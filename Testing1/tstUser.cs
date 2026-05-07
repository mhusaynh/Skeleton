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

            String TestData = "Test";

            AUser.UserId = "Test";

            Assert.AreEqual(AUser.UserId, TestData);
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

            AUser.DateAdded = true;

            Assert.AreEqual(AUser.DateAdded, TestData);
        }
    }
}

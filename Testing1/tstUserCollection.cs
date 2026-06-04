using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    internal class tstUserCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();
            //test to see that it exists
            Assert.IsNotNull(AllUsers);
        }
        [TestMethod]
        public void UserListOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new ClassLibrary.clsUserCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsUser> TestList = new List<clsUser>();
            //add an item to the list
            clsUser TestItem = new clsUser();
            TestItem.UserId = 1;
            TestItem.UserName = "John Doe";
            TestItem.Password = "password123";
            TestItem.Email = "john@hotmail.com";
            TestItem.Address = "123 Main Street";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Active = true;
            TestList.Add(TestItem);
            //assign the data to the property
            AllUsers.UserList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.UserList, TestList);
        }
        [TestMethod]
        public void ThisUserPropertyOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new ClassLibrary.clsUserCollection();
            //create some test data to assign to the property
            clsUser TestUser = new clsUser();
            TestUser.UserId = 1;
            TestUser.UserName = "John Doe";
            TestUser.Password = "password123";
            TestUser.Email = "john@hotmail.com";
            TestUser.Address = "123 Main Street";
            TestUser.DateAdded = DateTime.Now.Date;
            TestUser.Active = true;
            //assign the data to the property
            AllUsers.ThisUser = TestUser;
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUser, TestUser);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new ClassLibrary.clsUserCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsUser> TestList = new List<clsUser>();
            //add an item to the list
            clsUser TestItem = new clsUser();
            TestItem.UserId = 1;
            TestItem.UserName = "John Doe";
            TestItem.Password = "password123";
            TestItem.Email = "jd@hotmail.com";
            TestItem.Address = "123 Main Street";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Active = true;
            TestList.Add(TestItem);
            //assign the data to the property
            AllUsers.UserList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.Count, TestList.Count);

        }

    }
}

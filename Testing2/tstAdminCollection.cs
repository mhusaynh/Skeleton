using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstAdminCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAdmins);
        }
        [TestMethod]
        public void AdminListOK()
        {
            //Create an instance of the class we want to create
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //Create some test data to assign to the property
            //In this case we will create a list of objects 
            List<clsAdmin> TestList = new List<clsAdmin>();
            //Add an item to the list
            //Create the item of test data
            clsAdmin TestItem = new clsAdmin();
            //Set its properties
            TestItem.Stock = true;
            TestItem.Adminid = 1;
            TestItem.UserName = "John";
            TestItem.Email = "john12@gmail.com";
            TestItem.Password = "john123";
            TestItem.Order = "22";
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllAdmins.AdminList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllAdmins.AdminList, TestList);
        }
        [TestMethod]
        public void CountPorpertyOK()
        {
            //Create an instance of the class we want to create
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //Create some test data to assign to the property
            Int32 SomeCount = 2;
            //Assign the data to the property
            AllAdmins.Count = SomeCount;
            //Test to see that the two values are the same
            Assert.AreEqual(AllAdmins.Count, SomeCount);
        }
        [TestMethod]
        public void ThisAdminPropertyOK()
        {
            //Create an instance of the class we want to create
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //Create some test data to assign to the property
            clsAdmin TestAdmin = new clsAdmin();
            //Set the properties of the test object
            TestAdmin.Stock = true;
            TestAdmin.Adminid = 1;
            TestAdmin.UserName = "John";
            TestAdmin.Email = "john12@gmail.com";
            TestAdmin.Password = "john123";
            TestAdmin.Order = "22";
            //Assign the data to the property
            AllAdmins.ThisAdmin = TestAdmin;
            //Test to see that the two values are the same
            Assert.AreEqual(AllAdmins.ThisAdmin, TestAdmin);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //Create some test data to assign to the property
            //In this case we will create a list of objects 
            List<clsAdmin> TestList = new List<clsAdmin>();
            //Add an item to the list
            //Create the item of test data
            clsAdmin TestItem = new clsAdmin();
            //Set its properties
            TestItem.Stock = true;
            TestItem.Adminid = 1;
            TestItem.UserName = "John";
            TestItem.Email = "john12@gmail.com";
            TestItem.Password = "john123";
            TestItem.Order = "22";
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllAdmins.AdminList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllAdmins.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //Create an instance of the class we want to create
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllAdmins.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //Create some test data to assign to the property
            clsAdmin TestItem = new clsAdmin();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //Set the properties of the test object
            TestItem.UserName = "John";
            TestItem.Email = "john12@gmail.com";
            TestItem.Password = "john123";
            TestItem.Order = "22";
            TestItem.Stock = true;
            //Set ThisAdmin to the test data
            AllAdmins.ThisAdmin = TestItem;
            //Add the record
            PrimaryKey = AllAdmins.Add();
            //Set the primary key of the test data
            TestItem.Adminid = PrimaryKey;
            //Find the record
            AllAdmins.ThisAdmin.Find(PrimaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllAdmins.ThisAdmin, TestItem);
        }
    }
}

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstAdminCollection
    {
        [TestMethod]
        public void InstanceOK()
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
            TestItem.Adminid = 6;
            TestItem.UserName = "Sam";
            TestItem.Email = "sam44@gmail.com";
            TestItem.Password = "sam888";
            TestItem.Order = "42";
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
            Int32 SomeCount = 8;
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
            TestAdmin.Adminid = 6;
            TestAdmin.UserName = "Sam";
            TestAdmin.Email = "sam44@gmail.com";
            TestAdmin.Password = "sam888";
            TestAdmin.Order = "42";
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
            TestItem.Adminid = 6;
            TestItem.UserName = "Sam";
            TestItem.Email = "sam44@gmail.com";
            TestItem.Password = "sam888";
            TestItem.Order = "42";
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
            Assert.AreEqual(AllAdmins.Count, 8);
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
            TestItem.Stock = true;
            TestItem.Adminid = 6;
            TestItem.UserName = "Sam";
            TestItem.Email = "sam44@gmail.com";
            TestItem.Password = "sam888";
            TestItem.Order = "42";
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
        [TestMethod]
        public void UpdateMethodOK()
        {
            //Create an instance of the class we want to create
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //Create some test data to assign to the property
            clsAdmin TestItem = new clsAdmin();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.Stock = true;
            TestItem.UserName = "Sam";
            TestItem.Email = "sam44@gmail.com";
            TestItem.Password = "sam888";
            TestItem.Order = "42";
            //Set ThisAdmin to the test data
            AllAdmins.ThisAdmin = TestItem;
            //Add the record
            PrimaryKey = AllAdmins.Add();
            //Set the primary key of the test data
            TestItem.Adminid = PrimaryKey;
            //Modify the test data
            TestItem.Stock = false;
            TestItem.UserName = "Sonal";
            TestItem.Email = "sonal23@gmail.com";
            TestItem.Password = "sonal777";
            TestItem.Order = "98";
            //Set the record based on the new test data
            AllAdmins.ThisAdmin = TestItem;
            //Update the record
            AllAdmins.Update();
            //Find the record
            AllAdmins.ThisAdmin.Find(PrimaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllAdmins.ThisAdmin, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create an instance of the class we want to create
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //Create some test data to assign to the property
            clsAdmin TestItem = new clsAdmin();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.Stock = true;
            TestItem.Adminid = 6;
            TestItem.UserName = "Sam";
            TestItem.Email = "sam44@gmail.com";
            TestItem.Password = "sam888";
            TestItem.Order = "42";
            //Set ThisAdmin to the test data
            AllAdmins.ThisAdmin = TestItem;
            //Add the record
            PrimaryKey = AllAdmins.Add();
            //Set the primary key of the test data
            TestItem.Adminid = PrimaryKey;
            //find the record
            AllAdmins.ThisAdmin.Find(PrimaryKey);
            //Delete the record
            AllAdmins.Delete();
            //now find the record
            Boolean Found = AllAdmins.ThisAdmin.Find(PrimaryKey);
            //Test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByUserNameMethodOK()
        {
            //Create an instance of the class we want to create
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //Create an instance of the filtered data
            clsAdminCollection FilteredAdmins = new clsAdminCollection();
            //Apply a blank string (should return all records)
            FilteredAdmins.ReportByUserName("");
            //Test to see that the two values are the same
            Assert.AreEqual(AllAdmins.Count, FilteredAdmins.Count);
        }
        [TestMethod]
        public void ReportByUserNameNoneFound()
        {
            //Create an instance of the class we want to create
            clsAdminCollection FilteredAdmins = new clsAdminCollection();
            //Apply a UserName that doesn't exist
            FilteredAdmins.ReportByUserName("xxxxxx");
            //Test to see that there are no records
            Assert.AreEqual(0, FilteredAdmins.Count);
        }
        [TestMethod]
        public void ReportByUserNameTestDataFound()
        {
            //Create an instance of the class we want to create
            clsAdminCollection FilteredAdmins = new clsAdminCollection();
            //variable to store the outcome
            Boolean OK = true;
            //Apply a UserName that doesn't exist
            FilteredAdmins.ReportByUserName("yyyyyy");
            //check that the correct number of records are found
            if (FilteredAdmins.Count == 2)
            {
                //check that the first record is ID 6
                if (FilteredAdmins.AdminList[0].Adminid != 6)
                {
                    OK = false;
                }
                //check that the second record is ID 7
                if (FilteredAdmins.AdminList[1].Adminid != 7)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
        }

    }
}

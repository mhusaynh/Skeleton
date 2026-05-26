using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that is exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.Product = "Nike Air Max";
            TestItem.Price = 25.99m;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Quantity = 2;
            TestItem.Completed = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrders = new clsOrder();
            //set the properties of the test object
            TestOrders.OrderId = 1;
            TestOrders.Product = "Nike Air Max";
            TestOrders.Price = 25.99m;
            TestOrders.DateAdded = DateTime.Now;
            TestOrders.Quantity = 2;
            TestOrders.Completed = true;
            //assign the data to the property
            AllOrders.ThisOrders = TestOrders;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrders, TestOrders);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the list
            //create the item to the test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.Product = "Nike Air Max";
            TestItem.Price = 25.99m;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Quantity = 2;
            TestItem.Completed = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Product = "Nike Air Force";
            TestItem.Price = 30.00m;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Quantity = 2;
            TestItem.Completed = true;
            //set ThisOrders to the test data
            AllOrders.ThisOrders = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrders.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrders, TestItem);
        }

        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Product = "Nike Air Force";
            TestItem.Price = 30.00m;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Quantity = 2;
            TestItem.Completed = true;
            //set ThisOrders to the test data
            AllOrders.ThisOrders = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId= PrimaryKey;
            //modify the test record
            TestItem.Product = "Asics Superblast";
            TestItem.Price = 20.00m;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Quantity = 4;
            TestItem.Completed = false;
            //set the record based on the new test data
            AllOrders.ThisOrders = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrders.Find (PrimaryKey);
            //test to see if ThisOrders matches the test data
            Assert.AreEqual(AllOrders.ThisOrders, TestItem);
        }

        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Product = "Nike Air Force";
            TestItem.Price = 30.00m;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Quantity = 2;
            TestItem.Completed = true;
            //set ThisOrders to the test data
            AllOrders.ThisOrders = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrders.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrders.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
    }
}

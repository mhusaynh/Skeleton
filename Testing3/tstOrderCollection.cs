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
            TestItem.Product = "Nike Pro Max";
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
            TestOrders.Product = "Nike Pro Max";
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
            TestItem.Product = "Nike Pro Max";
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
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ClassLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testing4
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //test to see that it exists
            Assert.IsNotNull(AllProducts);
        }

        [TestMethod]

        public void ProductListok()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            List<clsproduct> TestList = new List<clsproduct>();
            //create the item of test data
            clsproduct TestItem = new clsproduct();
            //set its properties
            TestItem.ProductID = 5;
            TestItem.ProductName = "Test Product";
            TestItem.Price = 9.99m;
            TestItem.Colour = "Black";
            TestItem.Quantity = 10;
            TestItem.Category = "Test Category";
            TestItem.Brand = "Test Brand";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Active = true;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductList, TestList);

        }
        [TestMethod]
        public void CountPropertyok()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
        
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, AllProducts.ProductList.Count);

        }
        [TestMethod]
        public void ThisProductPropertyok()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item of test data
            clsproduct TestItem = new clsproduct();
            //set its properties
            TestItem.ProductID = 5;
            TestItem.ProductName = "Test Product";
            TestItem.Price = 9.99m;
            TestItem.Colour = "Black";
            TestItem.Quantity = 10;
            TestItem.Category = "Test Category";
            TestItem.Brand = "Test Brand";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Active = true;
            //assign the data to the property
            AllProducts.ThisProduct = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }
        [TestMethod]
        public void ProductListCountok()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            List<clsproduct> TestList = new List<clsproduct>();
            //create the item of test data
            clsproduct TestItem = new clsproduct();
            //set its properties
            TestItem.ProductID = 5;
            TestItem.ProductName = "Test Product";
            TestItem.Price = 9.99m;
            TestItem.Colour = "Black";
            TestItem.Quantity = 10;
            TestItem.Category = "Test Category";
            TestItem.Brand = "Test Brand";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Active = true;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductList.Count, TestList.Count);
        }
    }
}




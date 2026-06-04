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
        [TestMethod]
        public void AddMethodok()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item of test data
            clsproduct TestItem = new clsproduct();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
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
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }
        [TestMethod]
        public void UpdateMethodok()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item of test data
            clsproduct TestItem = new clsproduct();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
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
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //modify the test data
            TestItem.ProductName = "Updated Product";
            TestItem.Price = 19.99m;
            TestItem.Colour = "White";
            TestItem.Quantity = 20;
            TestItem.Category = "Updated Category";
            TestItem.Brand = "Updated Brand";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Active = false;
            //assign the modified data to the property
            AllProducts.ThisProduct = TestItem;
            //update the record
            AllProducts.Update();
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }
        [TestMethod]
        public void DeleteMethodok()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item of test data
            clsproduct TestItem = new clsproduct();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
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
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //delete the record
            AllProducts.Delete();
            //find the record
            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByProductNameMethodok()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create an instance of the filtered data
            clsProductCollection FilteredProducts = new clsProductCollection();
            //apply a blank string (should return all records)
            FilteredProducts.ReportByProductName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count);

        }
        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            //create an instance of the filtered data
            clsProductCollection FilteredProducts = new clsProductCollection();
            //apply a product name that doesn't exist
            FilteredProducts.ReportByProductName("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredProducts.Count);
        }
        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            //create an instance of the filtered data
            clsProductCollection FilteredProducts = new clsProductCollection();
           //variable to store outcome
            Boolean OK = true;
            //apply a product name that doesn't exist
            FilteredProducts.ReportByProductName("Test Product");
            //check that the correct number of records are found
            if (FilteredProducts.Count == 1)
            {
                //check that the first record is ID 5
                if (FilteredProducts.ProductList[0].ProductID != 5)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}





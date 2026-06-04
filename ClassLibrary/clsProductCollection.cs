using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsProductCollection
    {
        private List<clsproduct> mProductList = new List<clsproduct>();

        private clsproduct mThisProduct = new clsproduct();

        public clsProductCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        { //populate  the array list based on the data table in the parameter DB
                int Index = 0;

                //get the count of records
                int RecordCount = DB.Count;
                //clear the private array list
                mProductList = new List<clsproduct>();
                //while there are records to process
                while (Index < RecordCount)
                {
                    //create a blank product
                    clsproduct AProduct = new clsproduct();
                    //read in the fields from the current record
                    AProduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                    AProduct.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                    AProduct.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                    AProduct.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);
                    AProduct.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                    AProduct.Category = Convert.ToString(DB.DataTable.Rows[Index]["Category"]);
                    AProduct.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand"]);
                    AProduct.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                    AProduct.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                    //add the record to the private data structure
                    mProductList.Add(AProduct);

                    //point at the next record
                    Index++;
                }

        }
        
        public List<clsproduct> ProductList
        {
            get
            {
                //return the private data
                return mProductList;
            }
            set
            {
                //set the private data
                mProductList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mProductList.Count;
            }
            set
            {
                //we will worry about this later
            }
        }
        
        public clsproduct ThisProduct
        {
            get
            {
                //return the private data
                return mThisProduct;
            }
            set
            {
                //set the private data
                mThisProduct = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Colour", mThisProduct.Colour);
            DB.AddParameter("@Quantity", mThisProduct.Quantity);
            DB.AddParameter("@Category", mThisProduct.Category);
            DB.AddParameter("@Brand", mThisProduct.Brand);
            DB.AddParameter("@DateAdded", mThisProduct.DateAdded);
            DB.AddParameter("@Active", mThisProduct.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblProduct_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of mThisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Colour", mThisProduct.Colour);
            DB.AddParameter("@Quantity", mThisProduct.Quantity);
            DB.AddParameter("@Category", mThisProduct.Category);
            DB.AddParameter("@Brand", mThisProduct.Brand);
            DB.AddParameter("@DateAdded", mThisProduct.DateAdded);
            DB.AddParameter("@Active", mThisProduct.Active);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblProduct_Update");
        }
    }
}

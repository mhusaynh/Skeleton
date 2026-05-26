using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        public List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member for thisOrders
        clsOrder mThisOrders = new clsOrder();

        //public property for the address list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this late
            }
        }

        public clsOrder ThisOrders
        {
            get
            {
                //return the private data
                return mThisOrders;
            }
            set
            {
                //set the private data
                mThisOrders = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisOrders
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Product", mThisOrders.Product);
            DB.AddParameter("@Price", mThisOrders.Price);
            DB.AddParameter("@DateAdded", mThisOrders.DateAdded);
            DB.AddParameter("@Quantity", mThisOrders.Quantity);
            DB.AddParameter("@Completed", mThisOrders.Completed);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisOrders
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@OrderId", mThisOrders.OrderId);
            DB.AddParameter("@Product", mThisOrders.Product);
            DB.AddParameter("@Price", mThisOrders.Price);
            DB.AddParameter("@DateAdded", mThisOrders.DateAdded);
            DB.AddParameter("@Quantity", mThisOrders.Quantity);
            DB.AddParameter("@Completed", mThisOrders.Completed);

            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrders
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrders.OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public clsOrderCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields for the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.Product = Convert.ToString(DB.DataTable.Rows[Index]["Product"]);
                AnOrder.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.Completed = Convert.ToBoolean(DB.DataTable.Rows[Index]["Completed"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
    }
}
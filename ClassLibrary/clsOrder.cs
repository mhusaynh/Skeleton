using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the order id property
        private Int32 mOrderId;

        //orderId public property
        public Int32 OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }

        //private data member for the product property
        private string mProduct;

        //product public property
        public string Product
        {
            get
            {
                //this line of code sends data out of the property
                return mProduct;
            }
            set
            {
                //this line of code allows data into the property
                mProduct = value;
            }
        }

        //private data member for the price property
        private decimal mPrice;

        //price public property
        public decimal Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }

        //private data member for the dateAdded property
        private DateTime mDateAdded;

        //dateAdded public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        //private data member for the quantity property
        private Int32 mQuantity;

        //quantity public property
        public Int32 Quantity
        {
            get
            {
                //this line of code sends data out of the property
                return mQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mQuantity = value;
            }
        }

        //private data member for the completed property
        private bool mCompleted;

        //completed public property
        public bool Completed
        {
            get
            {
                //this line of code sends data out of the property
                return mCompleted;
            }
            set
            {
                //this line of code allows data into the property
                mCompleted = value;
            }
        }

        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the order id to search for
            DB.AddParameter("@OrderId", OrderId);

            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");

            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mProduct = Convert.ToString(DB.DataTable.Rows[0]["Product"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mCompleted = Convert.ToBoolean(DB.DataTable.Rows[0]["Completed"]);
                //return that everything worked OK
                return true;
            }

            // if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string Product, string Price, string DateAdded, string Quantity)
        {
            //create a string variable to store the error
            String Error = "";
            //if the Product is blank
            if (Product == null)
            {
                //record the error
                Error = Error + "The Product may be blank : ";
            }
            //return any error message
            return Error;
        }
    }
}
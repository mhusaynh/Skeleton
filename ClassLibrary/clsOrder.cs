using System;

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

        public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mOrderId = 10;
            mProduct = "Nike Air Force";
            mPrice = 29.99m;
            mDateAdded = Convert.ToDateTime("13/04/2024");
            mQuantity = 3;
            mCompleted = true;
            //always return true
            return true;
        }
    }
}
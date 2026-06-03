using System;

namespace ClassLibrary
{
    public class clsproduct
    {


        private Int32 mProductID;
        public int ProductID
        {
            get
            {
                // this line of code sends data from the private data member to the public property
                return mProductID;
            }
            set
            {
                // this line of code sends data from the public property to the private data member
                mProductID = value;
            }
        }


        private string mProductName;
        public string ProductName
        {
            get
            {
                // this line of code sends data from the private data member to the public property
                return mProductName;
            }
            set
            {
                // this line of code sends data from the public property to the private data member
                mProductName = value;
            }
        }

        private decimal mPrice;
        public decimal Price
        {
            get
            {
                // this line of code sends data from the private data member to the public property
                return mPrice;
            }
            set
            {
                // this line of code sends data from the public property to the private data member
                mPrice = value;
            }
        }

        private string mColour;
        public string Colour
        {
            get
            {
                // this line of code sends data from the private data member to the public property
                return mColour;
            }
            set
            {
                // this line of code sends data from the public property to the private data member
                mColour = value;
            }
        }


        private Int32 mQuantity;
        public int Quantity
        {
            get
            {
                // this line of code sends data from the private data member to the public property
                return mQuantity;
            }
            set
            {
                // this line of code sends data from the public property to the private data member
                mQuantity = value;
            }
        }

        private string mCategory;
        public string Category
        {
            get
            {
                // this line of code sends data from the private data member to the public property
                return mCategory;
            }
            set
            {
                // this line of code sends data from the public property to the private data member
                mCategory = value;
            }
        }

        private string mBrand;
        public string Brand
        {
            get
            {
                // this line of code sends data from the private data member to the public property
                return mBrand;
            }
            set
            {
                // this line of code sends data from the public property to the private data member
                mBrand = value;
            }
        }
        private bool mActive;
        public bool Active
        {
            get
            {
                // this line of code sends data from the private data member to the public property
                return mActive;
            }
            set
            {
                // this line of code sends data from the public property to the private data member
                mActive = value;
            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                // this line of code sends data from the private data member to the public property
                return mDateAdded;
            }
            set
            {
                // this line of code sends data from the public property to the private data member
                mDateAdded = value;
            }
        }

        public bool Find(int ProductID)
        {
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the ProductID to search for
            DB.AddParameter("@ProductID", ProductID);
            // execute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByProductID");
            if (DB.Count == 1)
            {// copy the data from the database to the private data members
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mCategory = Convert.ToString(DB.DataTable.Rows[0]["Category"]);
                mBrand = Convert.ToString(DB.DataTable.Rows[0]["Brand"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                return true;
            }// if no record was found
            else
            {
                return false;
            }

        }

        public string Valid(string productName, string price, string colour, string quantity, string category, string brand, string dateAdded)
        {
            // create a variable to store the error message
            String Error = "";
            //create a temporary variable to store the converted price
            Decimal PriceTemp;
            //create a temporary variable to store the converted quantity
            Int32 QuantityTemp;
            //create a temporary variable to store the converted date
            DateTime DateTemp;
            //if the product name is blank
            if (productName.Length == 0)
            {
                //record the error
                Error = Error + "The product name may not be blank : ";
            }
            //if the product name is greater than 50 characters
            if (productName.Length > 50)
            {
                //record the error
                Error = Error + "The product name must be less than 50 characters : ";
            }

            try
            {
                //try to convert the price to a decimal
                PriceTemp = Convert.ToDecimal(price);
                //if the price is less than 0
                if (PriceTemp < 0)
                {
                    //record the error
                    Error = Error + "The price must be greater than or equal to 0 : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The price must be a valid decimal number : ";
            }

            if (colour.Length == 0)
            {
                //record the error
                Error = Error + "The colour may not be blank : ";
            }

            //if the colour is greater than 50 characters
            if (colour.Length > 50)
            {
                //record the error
                Error = Error + "The colour must be less than 50 characters : ";
            }

            try
            {
                //try to convert the quantity to an integer
                QuantityTemp = Convert.ToInt32(quantity);
                //if the quantity is less than 0
                if (QuantityTemp < 0)
                {
                    //record the error
                    Error = Error + "The quantity must be greater than or equal to 0 : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The quantity must be a valid integer : ";
            }

            //if the category is blank
            if (category.Length == 0)
            {
                //record the error
                Error = Error + "The category may not be blank : ";
            }

            //if the category is greater than 50 characters
            if (category.Length > 50)
            {
                //record the error
                Error = Error + "The category must be less than 50 characters : ";
            }

            //if the brand is blank
            if (brand.Length == 0)
            {
                //record the error
                Error = Error + "The brand may not be blank : ";
            }

            //if the brand is greater than 50 characters
            if (brand.Length > 50)
            {
                //record the error
                Error = Error + "The brand must be less than 50 characters : ";
            }
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //try to convert the date added to a date
                DateTemp = Convert.ToDateTime(dateAdded);
                //if the date added is less than today's date
                if (DateTemp < DateComp)
                {
                    //record the error
                    Error = Error + "The date added cannot be in the past : ";
                }

                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date added cannot be in the future : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date added must be a valid date : ";
            }

            //return any error messages
            return Error;
        }
    }
}

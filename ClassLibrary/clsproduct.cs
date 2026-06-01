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
    
    }
}
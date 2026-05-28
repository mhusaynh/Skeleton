using System;

namespace ClassLibrary
{
    public class clsproduct
    {
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

        public bool Find(int ProductID)
        {
            mActive = true;
            mDateAdded = Convert.ToDateTime("01/01/2020");
            mProductID = ProductID;
            mProductName = "Test Product";
            mPrice = 9.99m;
            mColour = "Red";
            mQuantity = 100;
            mCategory = "Test Category";
            mBrand = "Test Brand";
            return true;

        }
    
    }
}
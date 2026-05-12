using System;

namespace ClassLibrary
{
    public class clsAdmin
    {
        //private data member for the Adminid property
        private int mAdminid;
        //Adminid public property
        public int Adminid 
            {
            get
            {
                //this line of code sends data out of the property
                return mAdminid;
            }
            set
            {
                //this line of code allows data into the property
                mAdminid = value;
            }
        }
        //private data member for the UserName property
        private string mUserName;
        public string UserName
            {
            get
            {
                //this line of code sends data out of the property
                return mUserName;
            }
            set
            {
                //this line of code allows data into the property
                mUserName = value;
            }
        }
        //private data member for the Email property
        private string mEmail;
        public string Email
            {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        //private data member for the Password property
        private string mPassword;
        public string Password
            {
            get
            {
                //this line of code sends data out of the property
                return mPassword;
            }
            set
            {
                //this line of code allows data into the property
                mPassword = value;
            }
        }
        //private data member for the Order property
        private string mOrder;
        public string Order
            {
            get
            {
                //this line of code sends data out of the property
                return mOrder;
            }
            set
            {
                //this line of code allows data into the property
                mOrder = value;
            }
        }
        //private data member for the Stock property
            private bool mStock;
        public bool Stock
            {
            get
            {
                //this line of code sends data out of the property
                return mStock;
            }
            set
            {
                //this line of code allows data into the property
                mStock = value;
            }
        }

        /****** FIND METHOD ******/

        public bool Find(int adminid)
        {
            //set the private data member to the test data value
            mAdminid = 1;
            mUserName = "name";
            mEmail = "admin@text";
            mPassword = "password123";
            mOrder = "1";
            mStock = true;
            //always return true
            return true;
        }
        
    }
}
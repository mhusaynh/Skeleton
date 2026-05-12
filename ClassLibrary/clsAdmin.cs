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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Adminid to search for
            DB.AddParameter("@Adminid", adminid);
            //execute the stored procedure
            DB.Execute("sproc_tblAdmin_FilterByAdminid");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mAdminid = Convert.ToInt32(DB.DataTable.Rows[0]["Adminid"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mOrder = Convert.ToString(DB.DataTable.Rows[0]["Order"]);
                mStock = Convert.ToBoolean(DB.DataTable.Rows[0]["Stock"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false, indicating a problem
                return false;


            }
        }
    }
}

using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsAdminCollection
    {
        //privete data member for the list
        List<clsAdmin> mAdminList = new List<clsAdmin>();
        //private data member for ThisAdmin
         clsAdmin mThisAdmin = new clsAdmin();

        //constructor for the class
        public clsAdminCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored prodcedure
            DB.Execute("sproc_tblAdmin_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank admin
                clsAdmin AnAdmin = new clsAdmin();
                //read in the fields from the current record
                AnAdmin.Stock = Convert.ToBoolean(DB.DataTable.Rows[Index]["Stock"]);
                AnAdmin.Adminid = Convert.ToInt32(DB.DataTable.Rows[Index]["Adminid"]);
                AnAdmin.UserName = Convert.ToString(DB.DataTable.Rows[Index]["UserName"]);
                AnAdmin.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnAdmin.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AnAdmin.Order = Convert.ToString(DB.DataTable.Rows[Index]["Order"]);
                //add the record to the private data member
                mAdminList.Add(AnAdmin);
                //point at the next record
                Index++;
            }

        }

        public List<clsAdmin> AdminList 
        {
            get
            {
                //return the private data
                return mAdminList;
            }
            set
            {
                //set the private data
                mAdminList = value;
            }
        }
        public int Count
            {
            get
            {
                //return the count of the list
                return mAdminList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsAdmin ThisAdmin
            {
            get
            {
                //return the private data
                return mThisAdmin;
            }
            set
            {
                //set the private data
                mThisAdmin = value;
            }
        }

        public int Add()
        {
            //add a record to the database based on the values of mThisAdmin
           //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@UserName", mThisAdmin.UserName);
            DB.AddParameter("@Email", mThisAdmin.Email);
            DB.AddParameter("@Password", mThisAdmin.Password);
            DB.AddParameter("@Order", mThisAdmin.Order);
            DB.AddParameter("@Stock", mThisAdmin.Stock);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblAdmin_Insert");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
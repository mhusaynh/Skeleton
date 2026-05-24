using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsAdminCollection
    {
        //private data member for the list
        List<clsAdmin> mAdminList = new List<clsAdmin>();
        //privte member data for thisAdmin
        clsAdmin mThisAdmin = new clsAdmin();

        //public property for the admin list
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
        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return mAdminList.Count;
            }
            set
            {
                //we will worry about this later
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

        //constructor for the class
        public clsAdminCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAdmin_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisAdmin
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
            //update an existing record based on the values of mThisAdmin
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Adminid", mThisAdmin.Adminid);
            DB.AddParameter("@UserName", mThisAdmin.UserName);
            DB.AddParameter("@Email", mThisAdmin.Email);
            DB.AddParameter("@Password", mThisAdmin.Password);
            DB.AddParameter("@Order", mThisAdmin.Order);
            DB.AddParameter("@Stock", mThisAdmin.Stock);
            //execute the stored procedure
            DB.Execute("sproc_tblAdmin_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by ThisAdmin
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Adminid", mThisAdmin.Adminid);
            //execute the stored procedure
            DB.Execute("sproc_tblAdmin_Delete");
        }

        public void ReportByUserName(string UserName)
        {
            //filters the records based on a full or partial user name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the UserName parameter for the stored procedure
            DB.AddParameter("@UserName", UserName);
            //execute the stored procedure
            DB.Execute("sproc_tblAdmin_FilterByUserName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mAdminList = new List<clsAdmin>();
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
    }
}
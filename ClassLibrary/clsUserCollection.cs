using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsUserCollection
    {
        //private data member for the list
        List<clsUser> mUserList = new List<clsUser>();
        //privte member data for thisUser
        clsUser mThisUser = new clsUser();

        //public property for the User list
        public List<clsUser> UserList
        {
            get
            {
                //return the private data
                return mUserList;
            }
            set
            {
                //set the private data
                mUserList = value;
            }
        }
        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return mUserList.Count;
            }
            set
            {
                //we will worry about this later
            }
        }
        public clsUser ThisUser
        {
            get
            {
                //return the private data
                return mThisUser;
            }
            set
            {
                //set the private data
                mThisUser = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        { //populate  the array list based on the data table in the parameter DB
            int Index = 0;

            //get the count of records
            int RecordCount = DB.Count;
            //clear the private array list
            mUserList = new List<clsUser>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank User
                clsUser AUser = new clsUser();
                //read in the fields from the current record
                AUser.UserId = Convert.ToInt32(DB.DataTable.Rows[Index]["UserId"]);
                AUser.UserName = Convert.ToString(DB.DataTable.Rows[Index]["UserName"]);
                AUser.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AUser.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AUser.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AUser.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AUser.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                //add the record to the private data structure
                mUserList.Add(AUser);

                //point at the next record
                Index++;
            }

        }

        public clsUserCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblUser_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisUser
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@UserName", mThisUser.UserName);
            DB.AddParameter("@Email", mThisUser.Email);
            DB.AddParameter("@Password", mThisUser.Password);
            DB.AddParameter("@DateAdded", mThisUser.DateAdded);
            DB.AddParameter("@Active", mThisUser.Active);
            DB.AddParameter("@Address", mThisUser.Address);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblUser_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of mThisUser
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Userid", mThisUser.UserId);
            DB.AddParameter("@UserName", mThisUser.UserName);
            DB.AddParameter("@Email", mThisUser.Email);
            DB.AddParameter("@Password", mThisUser.Password);
            DB.AddParameter("@DateAdded", mThisUser.DateAdded);
            DB.AddParameter("@Active", mThisUser.Active);
            DB.AddParameter("@Address", mThisUser.Address);
            //execute the stored procedure
            DB.Execute("sproc_tblUser_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by ThisUser
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@UserId", mThisUser.UserId);
            //execute the stored procedure
            DB.Execute("sproc_tblUser_Delete");
        }

        public void ReportByUserName(string UserName)
        {
            //filters the records based on a full or partial user name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the UserName parameter for the stored procedure
            DB.AddParameter("@UserName", UserName);
            //execute the stored procedure
            DB.Execute("sproc_tblUser_FilterByUserName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}
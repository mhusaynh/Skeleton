using System;
using System.IO;

namespace ClassLibrary
{
    public class clsUserUser
    {
        //private data member for the UserID property
        private Int32 mUserId;
        //private data member for the UserName property
        private string mUsername;
        //private data member for the Password property
        private string mPassword;
        //private data member for the Department property
        private string mDepartment;


        public int UserId
            {
            get
            {
                //return the private data
                return mUserId;
            }
            set
            {
                //set the private data
                mUserId = value;
            }
        }
        public string Username
        {
            get
            {
                //return the private data
                return mUsername;
            }
            set
            {
                //set the private data
                mUsername = value;
            }
        }
        public string Password
            {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the private data
                mPassword = value;
            }
        }
        public string Department
            {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the private data
                mDepartment = value;
            }
        }

        public bool FindUser(string Username, string Password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the username and password to search for
            DB.AddParameter("@Username", Username);
            DB.AddParameter("@Password", Password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUsernamePW");
            //if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
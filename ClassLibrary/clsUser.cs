using System;

namespace ClassLibrary
{
    public class clsUser
    {
        private Int32 mUserId;
        private String mUserName;
        private String mPassword;
        private String mEmail;
        private String mAddress;
        private DateTime mDateAdded;
        private Boolean mActive;
        public Boolean Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public String Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        public String Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        public String Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        public String UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }
        public Int32 UserId { 
            get
            { 
                return mUserId;
            }
            set
            {
                mUserId = value;
            }
        }

        public bool Find(int userId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserId", userId);
            DB.Execute("sproc_tblUser_FilterByUserId");
            if (DB.Count == 1)
            {
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                return true;
            }
            else
            {
                return false;
            }
        }


        public string Valid(string userName, string email, string password, string address, DateTime dateAdded)
        {
            string Error = "";
            if (userName.Length == 0)
            {
                Error = Error + "The user name may not be blank. ";
            }
            if (UserName.Length > 50)
            {
                Error = Error + "The user name must be less than 50 characters. ";
            }
            if (email.Length == 0)
            {
                Error = Error + "The email may not be blank. ";
            }
            if (email.Length > 50)
            {
                Error = Error + "The email must be less than 50 characters. ";
            }
            if (password.Length == 0)
            {
                Error = Error + "The password may not be blank. ";
            }
            if (password.Length > 50)
            {
                Error = Error + "The password must be less than 50 characters. ";
            }
            if (address.Length == 0)
            {
                Error = Error + "The address may not be blank. ";
            }
            if (address.Length > 50)
            {
                Error = Error + "The address must be less than 50 characters. ";
            }
            if (dateAdded < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past. ";
            }
            if (dateAdded > DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future. ";
            }

            return Error;
        }
    }
}
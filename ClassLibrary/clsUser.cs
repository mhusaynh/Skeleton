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
        public Int32 UserId
        {
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
            mUserId = 1;
            mUserName = "husayn";
            mPassword = "password123";
            mAddress = "123 street";
            mEmail = "husayn@hotmail.ocm";
            mActive = true;
            mDateAdded = Convert.ToDateTime("23/12/2022");
            return true;
        }
    }
}
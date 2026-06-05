using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 UserId;


    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the admin to be processed
        UserId = Convert.ToInt32(Session["UserId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (UserId != -1)
            {
                //display the current data for the record
                DisplayUser();
            }
        }

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create new instance of ClsUser
        // capture form into a new clsUser and store the object in Session
        clsUser AUser = new clsUser();
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        string Email = txtEmail.Text;
        string Address = txtAddress.Text;
        string DateAdded = txtDateAdded.Text;
        string Active = chkActive.Text;
        string Error = "";
        Error = AUser.Valid(UserName, Email, Password, Address, Convert.ToDateTime(DateAdded));
        if (Error == "")
        {
            AUser.UserId = Convert.ToInt32(UserId);
            AUser.UserName = UserName;
            AUser.Password = Password;
            AUser.Email = Email;
            AUser.Address = Address;
            AUser.DateAdded = Convert.ToDateTime(DateAdded);
            clsUserCollection UserList = new clsUserCollection();

            //if this is a new record i.e. Userid = -1 then add the data
            if (UserId == -1)
            {
                //set the ThisUser property
                UserList.ThisUser = AUser;
                //add the new record
                UserList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                UserList.ThisUser.Find(UserId);
                //set the ThisUser property
                UserList.ThisUser = AUser;
                //update the record
                UserList.Update();
            }

            //redirect back to the list page
            Response.Redirect("UserList.aspx");
        }
        else
        {
            lblError.Text = Error;
            return;
        }

        // store the object under the key expected by viewer
        Session["AUser"] = AUser;

        // navigate to viewer
        Response.Redirect("UserViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        ClassLibrary.clsUser AUser = new ClassLibrary.clsUser();
        Int32 UserId;
        Boolean Found = false;
        UserId = Convert.ToInt32(txtUserId.Text);
        Found = AUser.Find(UserId);

        if (Found == true)
        {
            txtEmail.Text = AUser.Email;
            txtPassword.Text = AUser.Password;
            txtAddress.Text = AUser.Address;
            txtUserId.Text = AUser.UserId.ToString();
            txtUserName.Text = AUser.UserName;
            txtDateAdded.Text = AUser.DateAdded.ToString();
        }
    }

    void DisplayUser()
    {
        //create an instance of the admin book
        clsUserCollection UserBook = new clsUserCollection();
        //find the record to update
        UserBook.ThisUser.Find(UserId);
        //display the data for this record
        txtUserId.Text = UserBook.ThisUser.UserId.ToString();
        txtUserName.Text = UserBook.ThisUser.UserName.ToString();
        txtEmail.Text = UserBook.ThisUser.Email.ToString();
        txtPassword.Text = UserBook.ThisUser.Password.ToString();
        txtAddress.Text = UserBook.ThisUser.Address.ToString();
        txtDateAdded.Text = UserBook.ThisUser.DateAdded.ToString();
        chkActive.Text = UserBook.ThisUser.Active.ToString();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the list page
        Response.Redirect("UserList.aspx");
    }
}
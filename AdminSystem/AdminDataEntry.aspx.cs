using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 Adminid;


    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the admin to be processed
        Adminid = Convert.ToInt32(Session["Adminid"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (Adminid != -1)
            {
                //display the current data for the record
                DisplayAdmin();
            }
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of the Admin class
        clsAdmin AnAdmin = new clsAdmin();
        //capture the Username
        string UserName = txtUserName.Text;
        //capture the Password
        string Password = txtPassword.Text;
        //capture the Email
        string Email = txtEmail.Text;
        //capture the Order
        string Order = txtOrder.Text;
        //capture the Stock
        string Stock = chkStock.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnAdmin.Valid(UserName, Email, Password, Order);
        if (Error == "")
        {
            //capture the Adminid
            AnAdmin.Adminid = Adminid;
            //capture the Username
            AnAdmin.UserName = UserName;
            //capture the Password
            AnAdmin.Password = Password;
            //capture the Email
            AnAdmin.Email = Email;
            //capture the Order
            AnAdmin.Order = Order;
            //capture the Stock
            AnAdmin.Stock = chkStock.Checked;
            //Create a new instance of the Admin collection
            clsAdminCollection AdminList = new clsAdminCollection();

            //if this is a new record i.e. Adminid = -1 then add the data
            if (Adminid == -1)
            {
                //set the ThisAdmin property
                AdminList.ThisAdmin = AnAdmin;
                //add the new record
                AdminList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                AdminList.ThisAdmin.Find(Adminid);
                //set the ThisAdmin property
                AdminList.ThisAdmin = AnAdmin;
                //update the record
                AdminList.Update();
            }

                //redirect back to the list page
                Response.Redirect("AdminList.aspx");
        }
        else
        {
            //display the error message
            IbIError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the admin class
        clsAdmin AnAdmin = new clsAdmin();
        //create a variable to store the primary key
        Int32 Adminid;
        //create a boolean variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Adminid = Convert.ToInt32(txtAdminid.Text);
        //find the record
        Found = AnAdmin.Find(Adminid);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtUserName.Text = AnAdmin.UserName;
            txtPassword.Text = AnAdmin.Password;
            txtEmail.Text = AnAdmin.Email;
            txtOrder.Text = AnAdmin.Order;
            chkStock.Checked = AnAdmin.Stock;

        }
    }
    void DisplayAdmin()
    {
        //create an instance of the admin book
        clsAdminCollection AdminBook = new clsAdminCollection();
        //find the record to update
        AdminBook.ThisAdmin.Find(Adminid);
        //display the data for this record
        txtAdminid.Text = AdminBook.ThisAdmin.Adminid.ToString();
        txtUserName.Text = AdminBook.ThisAdmin.UserName.ToString();
        txtEmail.Text = AdminBook.ThisAdmin.Email.ToString();
        txtPassword.Text = AdminBook.ThisAdmin.Password.ToString();
        txtOrder.Text = AdminBook.ThisAdmin.Order.ToString();
        chkStock.Checked = AdminBook.ThisAdmin.Stock;
    }

    protected void btnReturntoMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the list page
        Response.Redirect("AdminList.aspx");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
 

    protected void Page_Load(object sender, EventArgs e)
    {

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
            //set the ThisAdmin property
            AdminList.ThisAdmin = AnAdmin;
            //add the new record
            AdminList.Add();
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
}
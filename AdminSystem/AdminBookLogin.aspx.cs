using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AdminBookLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the admin user class
        clsAdminUser AnUser = new clsAdminUser();
        //create the variable to store the Username and password
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        //create a variable to store the results of the find user method
        Boolean Found = false;
        //getthe username entered by the user
        Username = Convert.ToString(txtUsername.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(Username, Password);
        //Add a session to capture the user name
        Session["AnUser"] = AnUser;
        //if Username and/or password is empty
        if (txtUsername.Text == "")
        {
            //record the error
            lblError.Text =  "Enter a username";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter a password";
        }
        //if found is true
        else if (Found == true)
        {
            //redirect to the main page
            Response.Redirect("AdminList.aspx");
        }
        else
        {
            //record the error
            lblError.Text = "Login details are incorrect. Please try again";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}
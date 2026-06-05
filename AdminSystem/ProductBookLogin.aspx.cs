using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductBookLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the order user class
        clsProductUser AnUser = new clsProductUser();


        //get the username entered by the user
        string Username = txtUsername.Text;
        //get the password entered by the user
        string Password = txtPassword.Text;
        Boolean Found = false;


        //if username and/or password is empty
        if (txtUsername.Text == "")
        {
            //record the error
            lblError.Text = "Enter a username: ";
        }
        else if (txtPassword.Text == "")
        {
            Session["AnUser"] = AnUser;
            //record the error
            lblError.Text = "Enter a password: ";
        }
        //if found
        else
        {
            //find the user
            Found = AnUser.FindUser(Username, Password);

        if (Found == true)
            {

                //redirect to the List Page
                Response.Redirect("ProductList.aspx");
            }
            else if (Found == true)
            {
                //record the error
                lblError.Text = "Login details are incorrect. Please try again ";
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}

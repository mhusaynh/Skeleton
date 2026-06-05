using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayUser();
        }
        //create a new instance of clsUserUser
        clsUser AnUser = new clsUser();
        //get data from the session object
      //  AnUser = (clsUser)Session["AnUser"];
        //displaythe user name
       // Response.Write("Logged in as " + AnUser.UserName);

    }

    void DisplayUser()
    {
        // Create an instance of the product collection
        clsUserCollection UserBook = new clsUserCollection();
        // Set the data source to the list of users in the collection
        lstUsers.DataSource = UserBook.UserList;
        // Set the name of the primary key
        lstUsers.DataValueField = "UserID";
        // Set the data field to display
        lstUsers.DataTextField = "UserName";
        // Bind the data to the list
        lstUsers.DataBind();
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 Userid;
        //if a record has been selected from the list
        if (lstUsers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            Userid = Convert.ToInt32(lstUsers.SelectedValue);
            //store the data in the session object
            Session["Userid"] = Userid;
            //redirect to the edit page
            Response.Redirect("UserDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate that this is a new record
        Session["Userid"] = -1;
        //redirect to the data entry page
        Response.Redirect("UserDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 Userid;
        //if a record has been selected from the list
        if (lstUsers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            Userid = Convert.ToInt32(lstUsers.SelectedValue);
            //store the data in the session object
            Session["Userid"] = Userid;
            //redirect to the delete page
            Response.Redirect("UserConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to delete";
        }

    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the admin collection
        clsUserCollection AnUser = new clsUserCollection();
        //retrieve the value of the user name from the presentation layer
        AnUser.ReportByUserName(txtFilter.Text);
        //set the data source to the list of admins in the collection
        lstUsers.DataSource = AnUser.UserList;
        //set the name of the primary key
        lstUsers.DataValueField = "UserId";
        //set the data field to display
        lstUsers.DataTextField = "UserName";
        //bind the data to the list
        lstUsers.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the admin object
        clsUserCollection AnUser = new clsUserCollection();
        //set an empty string
        AnUser.ReportByUserName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of admins in the collection
        lstUsers.DataSource = AnUser.UserList;
        //set the name of the primary key
        lstUsers.DataValueField = "UserId";
        //set the data field to display
        lstUsers.DataTextField = "UserName";
        //bind the data to the list
        lstUsers.DataBind();
    }

    protected void btnReturntoMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}

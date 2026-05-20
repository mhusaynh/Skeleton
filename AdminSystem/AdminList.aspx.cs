using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayAdmin();
        }
    }

    void DisplayAdmin()
    {
        //create an instance of the admin collection
        clsAdminCollection AdminBook = new clsAdminCollection();
        //set the data source to the list of admins in the collection
        lstAdminList.DataSource = AdminBook.AdminList;
        //set the name of the primary key
        lstAdminList.DataValueField = "Adminid";
        //set the data field to display
        lstAdminList.DataTextField = "UserName";
        //bind the data to the list
        lstAdminList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Adminid"] = -1;
        //redirect to the data entry page
        Response.Redirect("AdminDataEntry.aspx");
    }
}
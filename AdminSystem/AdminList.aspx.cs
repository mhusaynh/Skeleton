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
        IstAdminList.DataSource = AdminBook.AdminList;
        //set the name of the primary key
        IstAdminList.DataValueField = "Adminid";
        //set the data field to display
        IstAdminList.DataTextField = "UserName";
        //bind the data to the list
        IstAdminList.DataBind();
    }



    protected void IstAdminList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate that this is a new record
        Session["Adminid"] = -1;
        //redirect to the data entry page
        Response.Redirect("AdminDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 Adminid;
        //if a record has been selected from the list
        if (IstAdminList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            Adminid = Convert.ToInt32(IstAdminList.SelectedValue);
            //store the data in the session object
            Session["Adminid"] = Adminid;
            //redirect to the edit page
            Response.Redirect("AdminDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}

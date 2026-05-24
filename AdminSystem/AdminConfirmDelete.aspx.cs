using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 Adminid;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of the record to be deleted from the session object
        Adminid = Convert.ToInt32(Session["Adminid"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the admin book collection class
        clsAdminCollection AdminBook = new clsAdminCollection();
        //find the record to delete
        AdminBook.ThisAdmin.Find(Adminid);
        //delete the record
        AdminBook.Delete();
        //redirect back to the list page
        Response.Redirect("AdminList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("AdminList.aspx");
    }
}
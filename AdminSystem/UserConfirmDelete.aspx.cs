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
    Int32 UserId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of the record to be deleted from the session object
        UserId = Convert.ToInt32(Session["UserId"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the admin book collection class
        clsUserCollection UserBook = new clsUserCollection();
        //find the record to delete
        UserBook.ThisUser.Find(UserId);
        //delete the record
        UserBook.Delete();
        //redirect back to the list page
        Response.Redirect("UserList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("UserList.aspx");
    }
}
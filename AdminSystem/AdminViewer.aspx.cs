using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of the Admin class
        clsAdmin AnAdmin = new clsAdmin();
        //get the data from the session object
        AnAdmin = (clsAdmin)Session["AnAdmin"];
        //display the Adminid for this entry
        Response.Write(AnAdmin.Adminid);
        //display the Username for this entry
        Response.Write(AnAdmin.UserName);
        //display the Password for this entry
        Response.Write(AnAdmin.Email);
        //display the Email for this entry
        Response.Write(AnAdmin.Password);
        //display the Order for this entry
        Response.Write(AnAdmin.Order);
        //display the Stock for this entry
        Response.Write(AnAdmin.Stock);


    }
}
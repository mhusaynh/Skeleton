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
        //create a new instance of clsUserName
        clsAdmin AnAdmin = new clsAdmin();
        //capture the Adminid
        AnAdmin.Adminid = Convert.ToInt32(txtAdminid.Text);
        //capture the Username
        AnAdmin.UserName = txtUserName.Text;
        //capture the Password
        AnAdmin.Password = txtPassword.Text;
        //capture the Email
        AnAdmin.Email = txtEmail.Text;
        //capture the Order
        AnAdmin.Order = txtOrder.Text;
        //capture the Stock
        AnAdmin.Stock = chkStock.Checked;
        //store the Adminid in the session object
        Session["AnAdmin"] = AnAdmin;
        //navigate to the viewer page
        Response.Redirect("AdminViewer.aspx");
    }
}
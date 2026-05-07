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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create new instance of ClsUser
        // capture form into a new clsUser and store the object in Session
        clsUser AUser = new clsUser();
        AUser.UserId = txtUserId.Text;
        AUser.Email = txtEmail.Text;
        AUser.Password = txtPassword.Text;
        AUser.Address = txtAddress.Text;
        AUser.DateAdded = DateTime.Now;

        // store the object under the key expected by viewer
        Session["AUser"] = AUser;

        // navigate to viewer
        Response.Redirect("UserViewer.aspx");
    }
}
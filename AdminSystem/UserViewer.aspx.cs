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
        //Create new instance of ClsUser
        clsUser clsUser = new clsUser();
        clsUser AUser = clsUser;
        //Get the data from the session object
        AUser = (clsUser)Session["AUser"];
        //Display the user data for this entry

        Response.Write(AUser.UserId);
        Response.Write(AUser.Email);
        Response.Write(AUser.Password);
        Response.Write(AUser.Address);
        Response.Write(AUser.DateAdded);


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdmin_Click(object sender, EventArgs e)
    {
        //redirect the user to the admin login page
        Response.Redirect("AdminBookLogin.aspx");
    }

    protected void btnUser_Click(object sender, EventArgs e)
    {
        //redirect the user to the user login page
        Response.Redirect("UserBookLogin.aspx");
    }



    protected void btnOrders_Click(object sender, EventArgs e)
    {
        //redirect the user to the orders login page
        Response.Redirect("OrderBookLogin.aspx");
    }



    protected void btnProduct_Click(object sender, EventArgs e)
    {
        //redirect the user to the product login page
        Response.Redirect("ProductBookLogin.aspx");
    }



    protected void btnReview_Click(object sender, EventArgs e)
    {
        //redirect the user to the review login page
        Response.Redirect("ReviewDataEntry.aspx");
    }
}
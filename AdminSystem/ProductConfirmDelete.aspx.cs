using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // Variable to store the primary key value of the record to be deleted
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of the record to be deleted from the session object
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // Create an instance of the Product collection
        clsProductCollection ProductList = new clsProductCollection();
        // Find the record to delete
        ProductList.ThisProduct.Find(ProductID);
        // Delete the record
        ProductList.Delete();
        // Redirect back to the main page
        Response.Redirect("ProductList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // Redirect back to the main page
        Response.Redirect("ProductList.aspx");
    }
}
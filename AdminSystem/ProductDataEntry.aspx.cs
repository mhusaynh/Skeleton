using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {   
        clsproduct AnProduct = new clsproduct();

        AnProduct.ProductID = Convert.ToInt32(txtProductID.Text);
        AnProduct.ProductName = txtProductName.Text;
        AnProduct.Price = Convert.ToDecimal(txtPrice.Text);
        AnProduct.Colour = txtColour.Text;
        AnProduct.Quantity = Convert.ToInt32(txtQuantity.Text);
        AnProduct.Category = txtCategory.Text;
        AnProduct.Brand = txtBrand.Text;
        AnProduct.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        AnProduct.Active = chkActive.Checked;
        //Store the product in the session object to pass it to the viewer page
        Session["AnProduct"] = AnProduct;
        //Redirect to the viewer page
        Response.Redirect("ProductViewer.aspx");

    }
}
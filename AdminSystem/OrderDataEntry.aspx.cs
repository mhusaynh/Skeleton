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


    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        
        //capture the OrderId
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        
        //capture the Product
        AnOrder.Product = txtProduct.Text;
        
        //capture the Price
        AnOrder.Price = Convert.ToDecimal(txtPrice.Text);
        
        //capture the DateAdded
        AnOrder.DateAdded = Convert.ToDateTime(txtDateAdded.Text);

        //capture the Quantity
        AnOrder.Quantity = Convert.ToInt32(txtQuantity.Text);

        //capture the Completed check box
        AnOrder.Completed = chkCompleted.Checked;

        //store the address in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrderViewer.aspx");
    }


}
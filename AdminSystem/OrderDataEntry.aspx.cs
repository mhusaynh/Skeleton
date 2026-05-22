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
        
        //capture the Product
        string Product = txtProduct.Text;

        //capture the Price
        string Price = txtPrice.Text;
        
        //capture the DateAdded
        string DateAdded = txtDateAdded.Text;

        //capture the Quantity
        string Quantity = txtQuantity.Text;

        //capture the Completed check box
        string Completed = chkCompleted.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AnOrder.Valid(Product, Price, DateAdded, Quantity);
        if (Error == "")
        {
            //capture the Product
            AnOrder.Product = Product;
            //capture the Price
            AnOrder.Price = Convert.ToDecimal(Price);
            //capture the DateAdded
            AnOrder.DateAdded = Convert.ToDateTime(DateTime.Now);
            //capture the Quantity
            AnOrder.Quantity = Convert.ToInt32(Quantity);
            //capture the Completed
            AnOrder.Completed = chkCompleted.Checked;
            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();
            //set this ThisOrder property
            OrderList.ThisOrders = AnOrder;
            //add the new record
            OrderList.Add();
            //navigate to the view page
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        // if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtProduct.Text = AnOrder.Product;
            txtPrice.Text = AnOrder.Price.ToString();
            txtDateAdded.Text = AnOrder.DateAdded.ToString();
            txtQuantity.Text = AnOrder.Quantity.ToString();
            chkCompleted.Checked = AnOrder.Completed;
        }
    }
}
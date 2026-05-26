using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderId != -1)
            {
                //display the current data for the record
                DisplayOrders();
            }
        }
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
            //capture the Order id
            AnOrder.OrderId = OrderId;
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

            //if this is a new record i.e. OrderId = -1 then add the data
            if (OrderId == -1)
            {
                //set the ThisOrders property
                OrderList.ThisOrders = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrders.Find(OrderId);
                //set the ThisOrders property
                OrderList.ThisOrders = AnOrder;
                //update the record
                OrderList.Update();
            }
            //redirect back to the list page
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

    void DisplayOrders()
    {
        //create an instance of the order book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update
        OrderBook.ThisOrders.Find(OrderId);
        //display the data for the record
        txtOrderId.Text = OrderBook.ThisOrders.OrderId.ToString();
        txtProduct.Text = OrderBook.ThisOrders.Product.ToString();
        txtPrice.Text = OrderBook.ThisOrders.Price.ToString();
        txtDateAdded.Text = OrderBook.ThisOrders.DateAdded.ToString();
        txtQuantity.Text = OrderBook.ThisOrders.Quantity.ToString();
        chkCompleted.Text = OrderBook.ThisOrders.Completed.ToString();
    }
}
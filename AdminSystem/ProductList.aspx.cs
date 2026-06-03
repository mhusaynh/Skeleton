using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // If the page is being loaded for the first time
        if (IsPostBack == false)
        {
            // Update the list box
            DisplayProducts();
        }
    }

        void DisplayProducts()
        {
            // Create an instance of the product collection
            clsProductCollection Products = new clsProductCollection();
            // Set the data source to the list of products in the collection
            lstProductList.DataSource = Products.ProductList;
            // Set the name of the primary key
            lstProductList.DataValueField = "ProductID";
            // Set the data field to display
            lstProductList.DataTextField = "ProductName";
            // Bind the data to the list
            lstProductList.DataBind();
        }
}

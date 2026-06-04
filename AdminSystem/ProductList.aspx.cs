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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Store -1 in the session to indicate this is a new record
        Session["ProductID"] = -1;
        // Redirect to the data entry page
        Response.Redirect("ProductDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to edit
        Int32 ProductID;
        // If a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to edit
            ProductID = Convert.ToInt32(lstProductList.SelectedValue);
            // Store the data in the session object
            Session["ProductID"] = ProductID;
            // Redirect to the edit page
            Response.Redirect("ProductDataEntry.aspx");
        }
        else // If no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}

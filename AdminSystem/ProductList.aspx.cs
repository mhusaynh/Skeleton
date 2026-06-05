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
        if (Session["AnUser"] != null)
        {
            clsProductUser AnUser = new clsProductUser();

            AnUser = (clsProductUser)Session["AnUser"];

            Response.Write("Logged in as:" + AnUser.Username);
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to delete
        Int32 ProductID;
        // If a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to delete
            ProductID = Convert.ToInt32(lstProductList.SelectedValue);
            // Store the data in the session object
            Session["ProductID"] = ProductID;
            // Redirect to the delete page
            Response.Redirect("ProductConfirmDelete.aspx");
        }
        else 
        {
            // If no record has been selected
            lblError.Text = "Please select a record to delete from the list";
        }
    }
    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // Create an instance of the product collection
        clsProductCollection Products = new clsProductCollection();
        // Filter the list based on the product name
        Products.ReportByProductName(txtFilter.Text);
        // Set the data source to the list of products in the collection
        lstProductList.DataSource = Products.ProductList;
        // Set the name of the primary key
        lstProductList.DataValueField = "ProductID";
        // Set the data field to display
        lstProductList.DataTextField = "ProductName";
        // Bind the data to the list
        lstProductList.DataBind();

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // Create an instance of the product collection
        clsProductCollection Products = new clsProductCollection();
        // Display all products
        Products.ReportByProductName("");
        // Clear the filter text box
        txtFilter.Text = "";
        // Set the data source to the list of products in the collection
        lstProductList.DataSource = Products.ProductList;
        // Set the name of the primary key
        lstProductList.DataValueField = "ProductID";
        // Set the data field to display
        lstProductList.DataTextField = "ProductName";
        // Bind the data to the list
        lstProductList.DataBind();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}

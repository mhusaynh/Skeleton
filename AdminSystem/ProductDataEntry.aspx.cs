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

        //capture the product name
        string ProductName = txtProductName.Text;
        //capture the price
        string Price = txtPrice.Text;
        //capture the colour
        string Colour = txtColour.Text;
        //capture the quantity
        string Quantity = txtQuantity.Text;
        //capture the category
        string Category = txtCategory.Text;
        //capture the brand
        string Brand = txtBrand.Text;
        //capture the date added
        string DateAdded = txtDateAdded.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnProduct.Valid(ProductName, Price, Colour, Quantity, Category, Brand, DateAdded);
        if (Error == "")
        {
            //capture the product name
            AnProduct.ProductName = ProductName;
            //capture the price
            AnProduct.Price = Convert.ToDecimal(Price);
            //capture the colour
            AnProduct.Colour = Colour;
            //capture the quantity
            AnProduct.Quantity = Convert.ToInt32(Quantity);
            //capture the category
            AnProduct.Category = Category;
            //capture the brand
            AnProduct.Brand = Brand;
            //capture the date added
            AnProduct.DateAdded = Convert.ToDateTime(DateAdded);
            //capture the active status
            AnProduct.Active = chkActive.Checked;

            //create a new instance of the product collection
            clsProductCollection ProductList = new clsProductCollection();

            //set the ThisProduct property
            ProductList.ThisProduct = AnProduct;

            //add the new record
            ProductList.Add();

            //redirect back to the list page
            Response.Redirect("ProductList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsproduct AnProduct = new clsproduct();
        Int32 ProductID;
        Boolean Found = false;
        ProductID = Convert.ToInt32(txtProductID.Text);
        Found = AnProduct.Find(ProductID);
        if (Found == true)
        {
            txtProductName.Text = AnProduct.ProductName;
            txtPrice.Text = AnProduct.Price.ToString();
            txtColour.Text = AnProduct.Colour;
            txtQuantity.Text = AnProduct.Quantity.ToString();
            txtCategory.Text = AnProduct.Category;
            txtBrand.Text = AnProduct.Brand;
            txtDateAdded.Text = AnProduct.DateAdded.ToString();
            chkActive.Checked = AnProduct.Active;
        }
    }
}
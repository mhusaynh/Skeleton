using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsproduct AnProduct = new clsproduct();

        AnProduct = (clsproduct)Session["AnProduct"];

        Response.Write(AnProduct.ProductID);
        Response.Write("<br/>");

        Response.Write(AnProduct.ProductName);
        Response.Write("<br/>");

        Response.Write(AnProduct.Price);
        Response.Write("<br/>");

        Response.Write(AnProduct.Colour);
        Response.Write("<br/>");

        Response.Write(AnProduct.Quantity);
        Response.Write("<br/>");

        Response.Write(AnProduct.Category);
        Response.Write("<br/>");

        Response.Write(AnProduct.Brand);
        Response.Write("<br/>");

        Response.Write(AnProduct.DateAdded);
        Response.Write("<br/>");



    }
}
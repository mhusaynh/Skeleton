using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AnReview"] != null)
        {
            // Use fully qualified name to specify the correct type
            clsReview AnReview = Session["AnReview"] clsReview;
            if (AnReview != null)
            {
                txtUserID.Text = Convert.ToString(AnReview.UserId);
                txtProductID.Text = Convert.ToString(AnReview.ProductId);
                txtRatingID.Text = Convert.ToString(AnReview.Rating);
                txtCommentID.Text = AnReview.Comment;
                txtDatePostingID.Text = Convert.ToString(AnReview.DatePosted);
            }
        }
    }

    protected void btnok_click(object sender, EventArgs e)
    {
        // Use fully qualified name to specify the correct type
        clsReview AnReview = new clsReview();

        string UserId = txtUserID.Text;
        string ProductId = txtProductID.Text;
        string Rating = txtRatingID.Text;
        string Comment = txtCommentID.Text;
        string DatePosted = txtDatePostingID.Text;

        AnReview.UserId = Convert.ToInt32(txtUserID.Text);
        AnReview.ProductId = Convert.ToInt32(txtProductID.Text);
        AnReview.Rating = Convert.ToInt32(txtRatingID.Text);
        AnReview.Comment = txtCommentID.Text;
        AnReview.DatePosted = Convert.ToDateTime(txtDatePostingID.Text);

        Session["AnReview"] = AnReview;

        Response.Redirect("ReviewDataEntry.aspx");
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
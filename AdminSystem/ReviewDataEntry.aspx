<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 31px">
            This is the Review Data Entry Page</div>
        <p>
            <asp:Label ID="IbIReviewld" runat="server" style="z-index: 1; left: 34px; top: 49px; position: absolute; height: 16px; width: 74px; right: 1491px" Text="Review lD"></asp:Label>
            <asp:Label ID="IbIUser" runat="server" style="z-index: 1; left: 34px; top: 80px; position: absolute; height: 19px" Text="User ID"></asp:Label>
        </p>
        <asp:TextBox ID="txtUserID" runat="server"  style="z-index: 1; left: 141px; top: 77px; position: absolute; height: 16px; width: 122px;"></asp:TextBox>
        <asp:Label ID="IbIproduct" runat="server" style="z-index: 1; left: 33px; top: 113px; position: absolute; width: 77px" Text="Product ID"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 141px; top: 112px; position: absolute; height: 16px; width: 120px"></asp:TextBox>
        <asp:Button ID="btnfind" runat="server" style="z-index: 1; left: 304px; top: 53px; position: absolute" Text="Find" />
        <br />
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 141px; top: 254px; position: absolute" Text="Active" />
        <p>
            &nbsp;&nbsp;</p>
        <p>
            <asp:Label ID="IbIRating" runat="server" style="z-index: 1; left: 34px; top: 146px; position: absolute" Text="Rating ID"></asp:Label>
        </p>
        <p>
            <asp:Label ID="IbIComment" runat="server" style="z-index: 1; left: 33px; top: 179px; position: absolute; width: 93px" Text="Comment ID"></asp:Label>
            <asp:TextBox ID="txtDatePostingID" runat="server" style="z-index: 1; left: 142px; top: 211px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IbIError" runat="server" style="z-index: 1; left: 37px; top: 274px; position: absolute; width: 45px"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 61px; top: 310px; position: absolute; height: 27px; width: 52px" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 178px; top: 310px; position: absolute; width: 52px; height: 27px" Text="Cancel" />
        </p>
        <p>
            <asp:TextBox ID="txtRatingID" runat="server" style="z-index: 1; left: 142px; top: 145px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtCommentID" runat="server" style="z-index: 1; left: 143px; top: 177px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IbIDatePosting" runat="server" style="z-index: 1; left: 34px; top: 212px; position: absolute; width: 103px" Text="Date Posting ID"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtReviewID" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 140px; top: 46px; position: absolute; height: 16px; width: 125px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

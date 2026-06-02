<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblShoesLTD" runat="server" style="z-index: 1; left: 272px; top: 117px; position: absolute; width: 78px" Text="Shoes LTD" Width ="128px"></asp:Label>
        </p>
    <asp:Button ID="btnAdmin" runat="server" style="z-index: 1; left: 210px; top: 254px; position: absolute" Text="Admin" OnClick="btnAdmin_Click" />
        <asp:Button ID="btnUser" runat="server" style="z-index: 1; left: 327px; top: 253px; position: absolute" Text="User" OnClick="btnUser_Click"/>
        <asp:Button ID="btnOrders" runat="server" style="z-index: 1; left: 426px; top: 253px; position: absolute; left: 550px; height: 25px; width: 63px;" Text="Orders" OnClick="btnOrders_Click"/>
        <asp:Button ID="btnProduct" runat="server" style="z-index: 1; left: 547px; top: 252px; position: absolute; left: 433px; height: 27px;" Text="Product" OnClick="btnProduct_Click"/>
        <asp:Button ID="btnReview" runat="server"  style="z-index: 1; left: 666px; top: 250px; position: absolute; height: 29px; width: 63px;" Text="Review" OnClick="btnReview_Click"/>
    </form>
    </body>
</html>

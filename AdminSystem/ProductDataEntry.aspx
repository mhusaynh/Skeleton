<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProductID" runat="server" Text="Product ID"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblProductName" runat="server" Text="Product Name"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblColour" runat="server" Text="Colour"></asp:Label>
            <asp:TextBox ID="txtColour" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCategory" runat="server" Text="Category"></asp:Label>
            <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblBrand" runat="server" Text="Brand "></asp:Label>
            <asp:TextBox ID="txtBrand" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" Text="DateAdded"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" OnCheckedChanged="chkActive_CheckedChanged" Text="Active" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

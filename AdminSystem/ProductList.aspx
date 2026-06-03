<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProductList" runat="server" Text="Product List"></asp:Label>
            <br />
            <br />
            <asp:ListBox ID="lstProductList" runat="server"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        </div>
    </form>
</body>
</html>

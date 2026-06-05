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
            <asp:ListBox ID="lstProductList" runat="server" Height="564px" Width="660px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="Button1_Click" Text="Delete" />
            <br />
            <br />
            <asp:Label ID="lblEnter" runat="server" Text="Enter Product Name: "></asp:Label>
&nbsp;<asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" 
                Text="Apply Filter " />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" 
                Text="Clear Filter " />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Return to Main Menu" />
        </div>
    </form>
</body>
</html>

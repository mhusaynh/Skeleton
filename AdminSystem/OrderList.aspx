<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="List" runat="server">
        <div>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 110px; top: 415px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 14px; top: 6px; position: absolute; height: 389px; width: 441px"></asp:ListBox>
        </div>
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 180px; top: 415px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 40px; top: 415px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 40px; top: 600px; position: absolute" Text="lblError"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 201px; top: 487px; position: absolute; width: 220px;"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 41px; top: 491px; position: absolute" Text="Enter a Product"></asp:Label>
            </p>
        <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 59px; top: 537px; position: absolute" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 219px; top: 537px; position: absolute" Text="Clear Filter" OnClick="btnClearFilter_Click" />
    </form>
</body>
</html>

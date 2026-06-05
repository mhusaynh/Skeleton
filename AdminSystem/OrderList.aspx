<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href ="Content/bootstrap.min.css" rel="stylesheet"/>
    <script src ="Scripts/bootstrap.bundle.min.js"<></script>
    <script src="Scripts/bootstrap.min.js"<></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css"/>
</head>
<body style="background-color: #73633C">
    <form id="List" runat="server">
        <div>
            <asp:Button ID="btnMainMenu" runat="server" style="z-index: 1; left: 392px; top: 556px; position: absolute" Text="Return to Main Menu" OnClick="btnMainMenu_Click" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 116px; top: 440px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 28px; top: 36px; position: absolute; height: 389px; width: 441px"></asp:ListBox>
        </div>
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 185px; top: 440px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
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
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 42px; top: 440px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 40px; top: 615px; position: absolute" Text="lblError"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 200px; top: 500px; position: absolute; width: 220px;"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 46px; top: 501px; position: absolute" Text="Enter a Product"></asp:Label>
            </p>
        <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 54px; top: 556px; position: absolute" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 167px; top: 556px; position: absolute" Text="Clear Filter" OnClick="btnClearFilter_Click" />
    </form>
</body>
</html>

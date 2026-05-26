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
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 40px; top: 480px; position: absolute" Text="lblError"></asp:Label>
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 14px; top: 6px; position: absolute; height: 389px; width: 441px"></asp:ListBox>
        </div>
        <div>
        </div>
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
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 40px; top: 415px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        </p>
    </form>
</body>
</html>

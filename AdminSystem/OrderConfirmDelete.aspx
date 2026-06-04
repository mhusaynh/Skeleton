<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #2E7594">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderForm" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 456px; width: 481px" OnSelectedIndexChanged="lstOrderForm_SelectedIndexChanged"></asp:ListBox>
            <asp:Label ID="lblText" runat="server" style="z-index: 1; left: 80px; top: 85px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 150px; top: 140px; position: absolute" Text="No" OnClick="btnNo_Click" />
        </div>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 90px; top: 140px; position: absolute" Text="Yes" OnClick="btnYes_Click" />
    </form>
</body>
</html>

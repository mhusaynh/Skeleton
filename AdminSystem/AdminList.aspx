<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:ListBox ID="IstAdminList" runat="server" Height="273px" OnSelectedIndexChanged="IstAdminList_SelectedIndexChanged" Width="298px"></asp:ListBox>
        </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="margin-left: 49px" Text="Edit" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>

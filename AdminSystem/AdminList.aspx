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
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="margin-left: 58px" Text="Delete" Width="62px" />
        </p>
        <p>
            &nbsp;</p>
        <p style="margin-top: 16px">
            Enter a User name
            <asp:TextBox ID="txtFilter" runat="server" Height="16px" style="margin-left: 18px; margin-top: 3px" Width="155px"></asp:TextBox>
        </p>
        <p style="margin-top: 16px">
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="margin-left: 110px" Text="Clear Filter" width="124px" />
            <asp:Button ID="btnReturntoMainMenu" runat="server" OnClick="btnReturntoMainMenu_Click" style="margin-left: 176px" Text="Return to Main Menu" />
        </p>
        <p style="margin-top: 16px">
            &nbsp;</p>
        <p style="margin-top: 16px">
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300"></asp:Label>
        </p>
    </form>
</body>
</html>

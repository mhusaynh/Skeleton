<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminBookLogin.aspx.cs" Inherits="AdminBookLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 418px; background-color: #e8f4fd">
    <form id="form1" runat="server">
        <div>
        
        <p>
            <strong>Admin Book Login Page</strong></p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" Height="18px" style="margin-left: 52px; margin-top: 1px; margin-bottom: 1px;" Width="200px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" Style="position: absolute; top: 158px; left:465px; z-index: 1;" ForeColor="#FF3300"></asp:Label>
        </p>
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 52px; margin-top: 13px;" TextMode="Password" width="202px" height="20px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnLogin" runat="server" style="margin-left: 123px" Text="Login" Width="56px" OnClick="btnLogin_Click" />
        <asp:Button ID="btnCancel" runat="server" style="margin-left: 99px" Text="Cancel" Width="56px" OnClick="btnCancel_Click" />
            </div>
    </form>
</body>
</html>

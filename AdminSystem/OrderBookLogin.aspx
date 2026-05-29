<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderBookLogin.aspx.cs" Inherits="OrderBookLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 438px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 45px; top: 85px; position: absolute" Text="Order Login Page"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 80px; top: 150px; position: absolute" Text="UserName"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 180px; top: 150px; position: absolute" ></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 80px; top: 190px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 180px; top: 190px; position: absolute" TextMode="Password" ></asp:TextBox>
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 430px; top: 170px; position: absolute" Text="[lblError]" ForeColor="#FF3300"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 167px; top: 255px; position: absolute" Text="Login" OnClick="btnLogin_Click" />
        <p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 236px; top: 255px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
    </body>
</html>

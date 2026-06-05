<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductBookLogin.aspx.cs" Inherits="ProductBookLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbllogin" runat="server" style="z-index: 1; left: 45px; top: 85px; position: absolute" Text="Product Login Page"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 44px; top: 190px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 180px; top: 190px; position: absolute" TextMode="Password" ></asp:TextBox>
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 478px; top: 162px; position: absolute" Text="[lblError]" ForeColor="#FF3300"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 101px; top: 257px; position: absolute" Text="Login" OnClick="btnLogin_Click" />
        <p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 236px; top: 255px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 36px; top: 138px; position: absolute" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 184px; top: 136px; position: absolute" ></asp:TextBox>
        </p>
    </form>
    </body>
</html>

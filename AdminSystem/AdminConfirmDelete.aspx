<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #e8f4fd">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
&nbsp;&nbsp; Are you sure you want to delete this record?</p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="margin-left: 44px; margin-top: 15px" Text="Yes" width="66px" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="margin-left: 91px" Text="No" width="66px" />
    </form>
</body>
</html>

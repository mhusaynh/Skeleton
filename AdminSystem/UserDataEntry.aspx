<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserDataEntry.aspx.cs" Inherits="_1_DataEntry" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 744px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtUserId" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 91px; top: 34px; position: absolute; width: 156px"></asp:TextBox>
        <br />
        <asp:Label ID="lblUserId" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; right: 1456px" Text="User ID"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 91px; top: 103px; position: absolute; width: 156px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 13px; top: 103px; position: absolute; right: 1463px; height: 19px; bottom: 528px;" Text="Password"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 91px; top: 66px; position: absolute; width: 156px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 11px; top: 69px; position: absolute; right: 1449px; height: 19px" Text="Email"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 91px; top: 144px; position: absolute; width: 156px"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 11px; top: 144px; position: absolute; right: 1459px; height: 19px" Text="Address"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 91px; top: 184px; position: absolute; width: 156px"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 11px; top: 184px; position: absolute; right: 1454px; height: 19px" Text="DateAdded"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 10px; top: 224px; position: absolute" Text="Active" TextAlign="Left" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 255px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 11px; top: 284px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 67px; top: 284px; position: absolute" Text="CANCEL" />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>

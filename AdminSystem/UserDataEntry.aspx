<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserDataEntry.aspx.cs" Inherits="_1_DataEntry" %>


<!DOCTYPE html>
<script runat="server">
</script>


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
        <br />
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 12px; top: 87px; position: absolute; right: 1414px" Text="UserName"></asp:Label>
         <asp:TextBox ID="txtUserName" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 100px; top: 84px; position: absolute; width: 156px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 97px; top: 151px; position: absolute; width: 156px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 12px; top: 159px; position: absolute; right: 1409px; height: 18px; bottom: 664px;" Text="Password"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 99px; top: 119px; position: absolute; width: 156px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 13px; top: 125px; position: absolute; right: 1447px; height: 19px" Text="Email"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 97px; top: 184px; position: absolute; width: 156px"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 12px; top: 188px; position: absolute; right: 1458px; height: 19px" Text="Address"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 96px; top: 211px; position: absolute; width: 156px"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 11px; top: 212px; position: absolute; right: 1454px; height: 19px" Text="DateAdded"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 17px; top: 278px; position: absolute" Text="Active" TextAlign="Left" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 307px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 17px; top: 338px; position: absolute" Text="OK" />
        <asp:Label ID="lblUserId0" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; right: 1416px" Text="User ID"></asp:Label>
        <asp:TextBox ID="txtUserId" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 99px; top: 35px; position: absolute; width: 156px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="margin-left: 291px" Text="Find" Width="136px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 77px; top: 338px; position: absolute; height: 26px;" Text="CANCEL" OnClick="btnCancel_Click" />
         <asp:Button ID="btnReturn" runat="server" style="z-index: 1; left: 170px; top: 338px; position: absolute; height: 26px;" Text="RETURN TO MAIN MENU" OnClick="btnReturn_Click" />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>

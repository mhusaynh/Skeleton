<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 271px;  background-color: #e8f4fd">
    <form id="form1" runat="server">
        <div>
            This is the Admin Data Entry Page</div>
        <p>
            <asp:TextBox ID="txtAdminid" runat="server" style="z-index: 1; top: 58px; position: absolute; left: 107px"></asp:TextBox>
        <asp:Label ID="lblAdminId" runat="server" style="z-index: 1; left: 11px; top: 56px; position: absolute; height: 22px;" Text="Admin ID"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 105px; top: 131px; position: absolute" width="168px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 106px; top: 94px; position: absolute" width="168px"></asp:TextBox>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 18px; top: 133px; position: absolute" Text="Email" width="60px"></asp:Label>
        </p>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 104px; top: 171px; position: absolute; right: 1045px;" width="168px"></asp:TextBox>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 15px; top: 171px; position: absolute; height: 19px" Text="Password" width="60px"></asp:Label>
            <asp:Label ID="lblOrder" runat="server" style="z-index: 1; left: 20px; top: 215px; position: absolute" Text="Order" width="60px"></asp:Label>
        </p>
        <asp:TextBox ID="txtOrder" runat="server" style="z-index: 1; left: 104px; top: 211px; position: absolute" width="168px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkStock" runat="server" style="z-index: 1; left: 107px; top: 265px; position: absolute" Text="Stock" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 17px; top: 319px; position: absolute" Text="OK" width="59px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 125px; top: 318px; position: absolute" Text="Cancel" width="59px" OnClick="btnCancel_Click" />
            <asp:Button ID="btnReturntoMainMenu" runat="server" OnClick="btnReturntoMainMenu_Click" style="z-index: 1; left: 345px; top: 320px; position: absolute" Text="Return to Main Menu" />
        <p>
            <asp:Label ID="IbIError" runat="server" style="z-index: 1; left: 21px; top: 404px; position: absolute; width: 79px;" ForeColor="#FF3300"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 9px; top: 95px; position: absolute; height: 22px; width: 82px;" Text="UserName"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" Height="31px" OnClick="btnFind_Click" Text="Find" width="60px" Style="z-index: 1; left: 365px; top: 87px; position: absolute"  />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

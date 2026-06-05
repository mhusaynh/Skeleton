<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 350px; background-color: #3C5273">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnMainMenu" runat="server" style="z-index: 1; left: 280px; top: 415px; position: absolute" Text="Return to Main Menu" OnClick="btnMainMenu_Click"/>
            This is the Order Data Entry Page</div>
        <p>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 37px; top: 113px; position: absolute" Text="OrderId" width="128px"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 121px; top: 111px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblProduct" runat="server" style="z-index: 1; left: 38px; top: 157px; position: absolute" Text="Product" width="128px"></asp:Label>
            <asp:TextBox ID="txtProduct" runat="server" style="z-index: 1; left: 119px; top: 155px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkCompleted" runat="server" style="z-index: 1; left: 112px; top: 342px; position: absolute" Text="Completed" />
        </p>
        <p>
&nbsp;&nbsp;&nbsp;
        </p>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 39px; top: 199px; position: absolute; width: 116px" Text="Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 119px; top: 197px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 33px; top: 236px; position: absolute; right: 1402px" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 125px; top: 239px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 38px; top: 284px; position: absolute" Text="Quantity" width="116px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 121px; top: 283px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 46px; top: 381px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 103px; top: 415px; position: absolute" Text="Ok" />
        <p>
            <asp:Button ID="lblFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 389px; top: 125px; position: absolute" Text="Find" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 169px; top: 415px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>

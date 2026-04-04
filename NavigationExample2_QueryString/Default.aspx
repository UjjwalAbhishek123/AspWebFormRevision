<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NavigationExample2_QueryString.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Navigation demo using Query String<br />
            <br />
            Login (showing username in queryString):
            <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <br />
            <br />
            Login (hiding username in queryString using Session):
            <asp:TextBox ID="txtLogin2" runat="server"></asp:TextBox>
        &nbsp;
            <asp:Button ID="btnLogin2" runat="server" OnClick="btnLogin2_Click" Text="Login" />
        </div>
    </form>
</body>
</html>

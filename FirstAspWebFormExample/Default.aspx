<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstAspWebFormExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Basic Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to my first ASP.NET web Application</h1>

            <%--runat="server" tells that it is server control and will run at server--%>
            Enter First Name:<asp:TextBox ID="TxtFirst" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Last Name:<asp:TextBox ID="TxtLast" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnGo" runat="server" Text="Go" OnClick="BtnGo_Click" />
            <br />
            <br />
            <hr />
            <asp:Label ID="LblResult" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>

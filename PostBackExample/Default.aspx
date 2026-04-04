<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PostBackExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtBx" runat="server"></asp:TextBox>
            <br />
            <br />

            <%--calendar--%>
            <asp:Calendar ID="myCalendar" runat="server" AutoPostBack="True"></asp:Calendar>
            <br /><br />

            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Go" />
            <br /><br />

            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

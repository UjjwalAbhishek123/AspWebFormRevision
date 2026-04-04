<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NavigationExample1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Navigation Demos
            <br />
            <br />
            <a href="Page2.aspx">Text HyperLink using HTML</a><br />
            <br />
            Asp.Net Hyperlink:
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Page2.aspx">Go to Page 2</asp:HyperLink>
            <br />
            <br />
            Asp.Net Hyperlink(image):
            <asp:HyperLink ID="HyperLink2" runat="server" ImageHeight="70px" ImageUrl="~/images/NextPage.png" ImageWidth="100px" NavigateUrl="~/Page2.aspx"></asp:HyperLink>
            <br />
            <br />
            LinkButton(for code based navigation demo):
            <asp:LinkButton ID="LinkButton1" runat="server" BackColor="Blue" BorderColor="Red" BorderStyle="Outset" ForeColor="White" OnClick="LinkButton1_Click">Page 2</asp:LinkButton>
            <br />
            <br />
            Regular button based nav:
            <asp:Button ID="btnPage2" runat="server" OnClick="btnPage2_Click" Text="Page 2" />
        </div>
    </form>
</body>
</html>

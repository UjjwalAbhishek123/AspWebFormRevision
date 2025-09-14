<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MathematicalWebApplcn_Examples.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Length:
            <asp:TextBox ID="txtLength" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLength" ErrorMessage="Length required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Width:
            <asp:TextBox ID="txtWidth" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtWidth" ErrorMessage="Width required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="BtnArea" runat="server" OnClick="BtnArea_Click" Text="Area" />
            <br />
            <br />
            Area:
            <asp:Label ID="lblArea" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

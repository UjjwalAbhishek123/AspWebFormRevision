<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ServerControls_EmployeeInfoExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Employee Information</h2>
            <p>
                Name:
                <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            </p>
            <p>
                Select Office:
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>Pick City</asp:ListItem>
                    <asp:ListItem>New Delhi</asp:ListItem>
                    <asp:ListItem>Madhubani</asp:ListItem>
                    <asp:ListItem>Darbhanga</asp:ListItem>
                    <asp:ListItem>Gurugram</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp; Selected Office:<asp:Label ID="LblResult" runat="server"></asp:Label>
            </p>

            <h4>
                Department
            </h4>

            <asp:RadioButton ID="RdoMarketing" runat="server" GroupName="Department" Text="Marketing" />
            <asp:RadioButton ID="RdoAccounting" runat="server" GroupName="Department" Text="Accounting" />
            <asp:RadioButton ID="RdoLegal" runat="server" GroupName="Department" Text="Legal" />

            <h4>
                Qualifications
            </h4>

            <asp:CheckBox ID="ChkBA" runat="server" Text="BA" />
            <asp:CheckBox ID="ChkMA" runat="server" Text="MA" />
            <asp:CheckBox ID="ChkPHD" runat="server" Text="PHD" />

            <br />
            <br />
            <asp:Button ID="BtnGo" runat="server" OnClick="BtnGo_Click" Text="Go" />
            <br />
            <br />
            <asp:Label ID="LblFullResult" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>

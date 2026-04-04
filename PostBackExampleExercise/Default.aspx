<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PostBackExampleExercise.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1 {
            width: 100%;
        }

        .style2 {
            width: 332%;
        }

        .style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>League of Greatest Singers
            <asp:Label ID="lblWelcome" runat="server"></asp:Label>
        </h1>

        <table class="style1">
            <tr>
                <td class="style2">Click below to choose a player...
                    <asp:Label ID="lblName" runat="server"></asp:Label>
                </td>
                <td class="style3" rowspan="2">
                    <asp:Image ID="img0" runat="server" Height="150px" Width="150px" ImageUrl="~/images/MusicGroup.jpg" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:DropDownList ID="ddlSingerName" runat="server" OnSelectedIndexChanged="DdlSingerName_Display" AutoPostBack="true">
                        <asp:ListItem Value="0" Selected="True">Select Singers</asp:ListItem>
                        <asp:ListItem Value="1">Mohammad Rafi</asp:ListItem>
                        <asp:ListItem Value="2">Lata Mangeshkar</asp:ListItem>
                        <asp:ListItem Value="3">Kishore Kumar</asp:ListItem>
                        <asp:ListItem Value="4">Sonu Nigam</asp:ListItem>
                        <asp:ListItem Value="5">Shreya Ghoshal</asp:ListItem>
                        <asp:ListItem Value="6">Arijit Singh</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <br />
        <br />
    </form>

</body>
</html>

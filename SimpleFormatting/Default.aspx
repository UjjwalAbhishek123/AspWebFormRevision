<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleFormatting.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formatting Eg</title>
    <style type="text/css">
        .newStyle1 {
            font-family: "Courier New", Courier, monospace;
        }
        .auto-style1 {
            color: #FF0066;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Text Formatting and other things<br />
            <br />
            In this line of text I will demonstrate on to change the <span class="newStyle1">font</span> and <span class="auto-style1">color</span>.<br />
            <br />
            Click here to go to <a href="http://cnn.com">CNN</a>.<br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="300px" ImageUrl="~/Images/pexels-harun-tan-3980364.jpg" Width="300px" />
        </div>
    </form>
    <p class="newStyle1">
    </p>
</body>
</html>

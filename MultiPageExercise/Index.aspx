<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MultiPageExercise.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome Page</title>
    <style type="text/css">
        .auto-style1 {
            width: 349px;
            height: 320px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to my Web Application</h1>
            <img alt="randomImage" class="auto-style1" src="Images/Screenshot%202025-04-17%20220003.png" />&nbsp;&nbsp;<asp:Label ID="LblWelcome" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            Click here to go to <a href="Page2.aspx">Page 2</a><br />
        </div>
    </form>
</body>
</html>

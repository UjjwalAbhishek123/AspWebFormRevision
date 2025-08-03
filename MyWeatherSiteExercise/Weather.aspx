<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weather.aspx.cs" Inherits="MyWeatherSiteExercise.Weather" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Weather Forecasts</h1>
            <p>
                <a href="Default.aspx">Home</a> <a href="Weather.aspx">Weather</a>
            </p>
            <hr />
            Enter your ZIP Code:<asp:TextBox ID="ZipCodeTxtBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Btn_GetForecast" runat="server" Text="Get Forecast" OnClick="Btn_GetForecast_Click" />
            <br />
            <br />
            <asp:Label ID="forecastLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

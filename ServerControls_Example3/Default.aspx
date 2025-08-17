<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ServerControls_Example3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>The Pizza Store</h1>
            <h3>Pizza Types:</h3>
            <p>
                <asp:RadioButton ID="RdoBabyRs10" runat="server" GroupName="PizzaType" Text="Baby ₹10" />
            </p>
            <p>
                <asp:RadioButton ID="RdoMamaRs13" runat="server" GroupName="PizzaType" Text="Mama ₹13" />
            </p>
            <p>
                <asp:RadioButton ID="RdoPapaRs16" runat="server" GroupName="PizzaType" Text="Papa ₹16" />
            </p>
            <h3>Favourite Crusts:</h3>
            <p>
                <asp:RadioButton ID="RdoThinCrust" runat="server" GroupName="PizzaCrust" Text="Thin Crust" />
            </p>
            <p>
                <asp:RadioButton ID="RdoDeepDish" runat="server" GroupName="PizzaCrust" Text="Deep Dish (+₹2.00)" />
            </p>
            <h3>Your Desired Toppings:</h3>
            <p>
                <asp:CheckBox ID="ChkPepperoni" runat="server" Text="Pepperoni ₹1.50" />
            </p>
            <p>
                <asp:CheckBox ID="ChkOnions" runat="server" Text="Onions ₹0.75" />
            </p>
            <p>
                <asp:CheckBox ID="ChkGreenPeppers" runat="server" Text="Green Peppers ₹0.50" />
            </p>
            <p>
                <asp:CheckBox ID="ChkRedPeppers" runat="server" Text="Red Peppers ₹0.75" />
            </p>
            <p>
                <asp:CheckBox ID="ChkAnchovies" runat="server" Text="Anchovies ₹2.00" />
            </p>
            <p>
                Special Deal: Save ₹2.00 when you add pepperoni, green peppers and anchovies OR pepperoni, red peppers and onions to your pizza.
            </p>
            <p>
                <asp:Button ID="BtnPurchase" runat="server" Text="Purchase" OnClick="BtnPurchase_Click" />
            </p>
            <p>
                Total:
                <asp:Label ID="lblTotal" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>

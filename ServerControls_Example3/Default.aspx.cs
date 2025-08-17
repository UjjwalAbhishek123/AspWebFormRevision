using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerControls_Example3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnPurchase_Click(object sender, EventArgs e)
        {
            double finalTotal = 0;
            double pizzaPrice = 0;
            double crustPrice = 0;
            double toppingsPrice = 0;

            if (RdoBabyRs10.Checked == true)
            {
                pizzaPrice += 10.00;
            }
            else if (RdoMamaRs13.Checked == true)
            {
                pizzaPrice += 13.00;
            }
            else if (RdoPapaRs16.Checked == true)
            {
                pizzaPrice += 16.00;
            }

            if (RdoThinCrust.Checked == true)
            {
                crustPrice += 0;
            }
            else if (RdoDeepDish.Checked == true)
            {
                crustPrice += 2.00;
            }

            if (ChkPepperoni.Checked == true)
            {
                toppingsPrice += 1.50;
            }
            if (ChkOnions.Checked == true)
            {
                toppingsPrice += 0.75;
            }
            if (ChkGreenPeppers.Checked == true)
            {
                toppingsPrice += 0.50;
            }
            if (ChkRedPeppers.Checked == true)
            {
                toppingsPrice += 0.75;
            }
            if (ChkAnchovies.Checked == true)
            {
                toppingsPrice += 2.00;
            }

            //Special deal calculation
            bool combination1 = ChkPepperoni.Checked == true && ChkGreenPeppers.Checked == true && ChkAnchovies.Checked == true;
            bool combination2 = ChkPepperoni.Checked == true && ChkRedPeppers.Checked == true && ChkOnions.Checked == true;

            if (combination1 || combination2)
            {
                finalTotal += pizzaPrice + crustPrice + toppingsPrice - 2.00;
                lblTotal.Text = "₹" + finalTotal.ToString();
            }
            else
            {
                finalTotal += pizzaPrice + crustPrice + toppingsPrice;
                lblTotal.Text = "₹" + finalTotal.ToString();
            }
        }
    }
}
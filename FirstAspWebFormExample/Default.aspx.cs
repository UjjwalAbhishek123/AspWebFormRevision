using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstAspWebFormExample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //on clicking Go button we are taking the contents of first textbox and second textbox, and then adding that with Hello, to display result in Label
        protected void BtnGo_Click(object sender, EventArgs e)
        {
            string first = TxtFirst.Text; //TxtFirst is Id of first textbox
            string last = TxtLast.Text; //TxtLast is Id of first textbox

            string result = "Hello there! " + first + " " + last + ".";

            //put result in label
            LblResult.Text = result;
        }
    }
}
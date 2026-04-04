using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBackExample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                txtBx.Text = "Hello World";
                myCalendar.SelectedDate = DateTime.Now.Date.AddDays(2);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblResult.Text = txtBx.Text + " " + myCalendar.SelectedDate.ToLongDateString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBackExample2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //without this condition, the items will be added to the list every time the page is loaded, which means that if you click the button, the items will be added again and again, which is not what we want. We only want to add the items once, when the page is first loaded.
            if (!IsPostBack)
            {
                CheckBoxList1.Items.Add("C#");
                CheckBoxList1.Items.Add("C++");
                CheckBoxList1.Items.Add("Java");
                CheckBoxList1.Items.Add("Python");
                CheckBoxList1.Items.Add("F#");
            }
        }

        
        protected void btnOK_Click(object sender, EventArgs e)
        {
            lblResult.Text = "You selected: <b> ";

            foreach (ListItem langs in CheckBoxList1.Items)
            {
                if (langs.Selected == true)
                {
                    lblResult.Text += " <br />" + langs.Text;
                }
            }

            lblResult.Text += "</b>";
        }
    }
}
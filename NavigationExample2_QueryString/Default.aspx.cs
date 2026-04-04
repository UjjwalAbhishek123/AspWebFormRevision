using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NavigationExample2_QueryString
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //navigation using Query string => for example http://abcd.com/abcd.aspx?username=abcd&password=abcd1, here "?username=abcd&password=abcd1" is query string

            string QueryString = "";
            QueryString = "?ID=" + txtLogin.Text; //here we are passing the value of txtLogin to query string with name "ID"
            Response.Redirect("Page2.aspx" + QueryString);
        }

        protected void btnLogin2_Click(object sender, EventArgs e)
        {
            //passing data without showing in query string, we can use "Session"
            Session["userId"] = txtLogin2.Text; //here we are passing the value of txtLogin2 to session with name "userId"

            Response.Redirect("Page2.aspx");
        }
    }
}
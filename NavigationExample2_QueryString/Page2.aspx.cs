using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NavigationExample2_QueryString
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Query String check
                if (Request.QueryString["ID"] != null)
                {
                    lblResult.Text = "Welcome " + Request.QueryString["ID"]; //here we are getting the value of query string with name "ID" and displaying it in lblResult
                }
                else
                {
                    lblResult.Text = "Welcome Guest (no query string)"; //if there is no query string with name "ID" then this message will be displayed in lblResult
                }

                //Session check
                if (Session["userId"] != null)
                {
                    //getting value in session will not be shown in query string, and we can get it using session name "userId"
                    lblResult2.Text = Session["userId"].ToString(); //here we are getting the value of session with name "userId" and displaying it in lblResult2
                }
                else
                {
                    lblResult2.Text = "No session value found";
                }
            }
        }
    }
}
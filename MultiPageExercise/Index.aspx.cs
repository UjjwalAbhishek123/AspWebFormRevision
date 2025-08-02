﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiPageExercise
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(DateTime.Now.Hour < 12)
            {
                LblWelcome.Text = "Good Morning !!";
            }
            else if(DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 17)
            {
                LblWelcome.Text = "Good Afternoon !!";
            }
            else
            {
                LblWelcome.Text = "Good Night !!";
            }
        }
    }
}
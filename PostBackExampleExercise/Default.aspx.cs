using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBackExampleExercise
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblWelcome.Text = "Welcome";
                //img0.ImageUrl = "images/MusicGroup.jpg";
            }
            else if (ddlSingerName.SelectedIndex != 0)
            {
                lblWelcome.Text = "Team Legends";
            }
        }

        protected void DdlSingerName_Display(object sender, EventArgs e)
        {
            if (ddlSingerName.SelectedIndex == 1)
            {
                lblName.Text = ddlSingerName.SelectedItem.Text;
                img0.ImageUrl = "images/Mohammad Rafi.jpg";
            }
            else if (ddlSingerName.SelectedIndex == 2)
            {
                lblName.Text = ddlSingerName.SelectedItem.Text;
                img0.ImageUrl = "images/Lata Mangeshkar.jpg";
            }
            else if (ddlSingerName.SelectedIndex == 3)
            {
                lblName.Text = ddlSingerName.SelectedItem.Text;
                img0.ImageUrl = "images/Kishore Kumar.jpg";
            }
            else if (ddlSingerName.SelectedIndex == 4)
            {
                lblName.Text = ddlSingerName.SelectedItem.Text;
                img0.ImageUrl = "images/Sonu Nigam.jpg";
            }
            else if (ddlSingerName.SelectedIndex == 5)
            {
                lblName.Text = ddlSingerName.SelectedItem.Text;
                img0.ImageUrl = "images/Shreya Ghoshal.jpg";
            }
            else if (ddlSingerName.SelectedIndex == 6)
            {
                lblName.Text = ddlSingerName.SelectedItem.Text;
                img0.ImageUrl = "images/Arijit Singh.jpg";
            }
        }
    }
}
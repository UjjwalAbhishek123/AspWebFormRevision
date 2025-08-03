using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeatherSiteExercise
{
    public partial class Weather : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_GetForecast_Click(object sender, EventArgs e)
        {
            //creating 3 random forecasts
            Random r = new Random();

            int val = r.Next(0, 3);

            //storing forecast
            string forecast = "";

            if(val == 0)
            {
                forecast = "warm and sunny.";
            }
            else if(val == 1)
            {
                forecast = "cold and windy.";
            }
            else if(val == 2)
            {
                forecast = "rain!";
            }

            //dynamically setting the Text value of label to new forecast
            forecastLabel.Text = "The weather forecast " + ZipCodeTxtBox.Text + " is " + forecast;
        }
    }
}
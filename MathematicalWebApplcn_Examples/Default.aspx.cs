using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MathematicalWebApplcn_Examples
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnArea_Click(object sender, EventArgs e)
        {
            double length;
            double width;
            double area;

            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            area = AreaCalculator(length, width);

            lblArea.Text = area.ToString() + " sq. unit";
        }

        private double AreaCalculator(double length, double width)
        {
            double area = length * width;

            return area;
        }
    }
}
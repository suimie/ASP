using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShapeAreaCalculator.UserControls
{
    public partial class Circle : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(txbRadius.Text);
            double area = Math.PI * radius * radius;
            lblArea.Text = area.ToString();
        }
    }
}
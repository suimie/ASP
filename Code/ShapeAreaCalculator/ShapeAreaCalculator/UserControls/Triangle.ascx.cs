using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShapeAreaCalculator.UserControls
{
    public partial class Triangle : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double baseT = double.Parse(txbBase.Text);
            double height = double.Parse(txbHeight.Text);
            double area = baseT * (1/2) * height;
            lblArea.Text = area.ToString();
        }
    }
}
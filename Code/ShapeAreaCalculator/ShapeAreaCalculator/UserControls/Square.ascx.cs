using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShapeAreaCalculator.UserControls
{
    public partial class Square : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculateS_Click(object sender, EventArgs e)
        {
            double width = double.Parse(txbWidth.Text);
            double area = width * width;
            lblArea.Text = area.ToString();
        }


    }


}
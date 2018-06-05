using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quotation_Builder
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double price = double.Parse(txtSalesPrice.Text);
            double percent = double.Parse(txtDiscountPercent.Text);
            double amount = price * (percent / 100);
            lblAmount.Text = "$" + amount.ToString();
            double total = price - amount;
            lblTotal.Text = "$" + total.ToString();
        }
    }
}
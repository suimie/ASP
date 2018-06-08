using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NothwindDB
{
    public partial class AdvancedSearchPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btSearch_Click(object sender, EventArgs e)
        {
            SQLdsCustomerDetail.SelectCommand =
                "SELECT * FROM [Customers] WHERE ([" + ddlSearchField.SelectedValue + "] = @CustomerID)";
        }
    }
}
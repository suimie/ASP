using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeExam1
{
    public partial class AdvancedSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SQLDSCustomerList.SelectCommand = 
                "SELECT * FROM[Customers] WHERE([" + ddlSearchField.SelectedValue + "] = @CustomerID) ORDER BY[CustomerID]";
        }
    }
}
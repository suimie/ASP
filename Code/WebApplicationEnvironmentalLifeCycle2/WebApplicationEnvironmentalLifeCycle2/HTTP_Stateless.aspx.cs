using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEnvironmentalLifeCycle
{
    public partial class HTTP_Stateless : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                tbxCounter.Text = "0";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["Clicks"] == null)
                ViewState["Clicks"] = 1;

            tbxCounter.Text = ViewState["Clicks"].ToString();
            ViewState["Clicks"] = (int)ViewState["Clicks"] + 1;

        }
    }
}
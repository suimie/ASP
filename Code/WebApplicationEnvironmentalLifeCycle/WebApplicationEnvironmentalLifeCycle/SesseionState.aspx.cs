using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEnvironmentalLifeCycle
{
    public partial class SesseionState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                tbxCounter.Text = "0";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Session["Clicks"] == null)
            {
                Session["Clicks"] = 1;
            }

            tbxCounter.Text = Session["Clicks"].ToString();
            Session["Clicks"] = (int)Session["Clicks"] + 1;
        }
    }
}
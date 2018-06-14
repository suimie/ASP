using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEnvironmentalLifeCycle
{
    public partial class Navigation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btInternal_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NavigationTarget.aspx");
        }

        protected void btExternal_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.google.com");
        }

        protected void tbTransferIn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/NavigationTarget.aspx");
        }

        protected void btTransferEx_Click(object sender, EventArgs e)
        {
            Server.Transfer("http://www.google.com");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Target.aspx");
            //Response.Redirect("~/Target.aspx");

            lblResult.Text = "You have successfully input the data";
        }

        public string name
        {
            get
            {
                return txbName.Text;
            }
        }

        public string email
        {
            get
            {
                return txbEmail.Text;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Execute("~/Target.aspx");
            lblResult.Text = "You have successfully input the data";
            txbEmail.Text = "";
            txbName.Text = "";
        }

    }
}
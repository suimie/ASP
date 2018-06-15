using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Environment_Life_Cycle
{
    public partial class Navigation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/9.1Navigation_Target.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.google.com");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/9.1Navigation_Target.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("http://www.google.com");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //9.2 target_2.aspx
            Server.Transfer("~/9.2target_2.aspx");
            lblResult.Text = "You have successfully input the data";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Server.Execute("~/9.2target_2.aspx");
            lblResult.Text = "You have successfully input the data";
            txtEmail.Text = "";
            txtName.Text = "";

        }
        public string name
        {
            get
            {
                return txtName.Text;
            }
        }

        public string email
        {
            get
            {
                return txtEmail.Text;
            }
        }
    }
}
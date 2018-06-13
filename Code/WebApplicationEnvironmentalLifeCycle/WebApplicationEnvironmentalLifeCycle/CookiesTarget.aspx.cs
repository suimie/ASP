using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEnvironmentalLifeCycle
{
    public partial class CookiesTarget : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["name"] != null && Request.QueryString["name"] != "")
            {
                lblTitle.Text = "Use Query String";
                lblName.Text = Request.QueryString["name"];
                lblEmail.Text = Request.QueryString["email"];

            }
            else
            {
                lblTitle.Text = "Use Cookie";
                HttpCookie cookie = Request.Cookies["UserInformation"];
                if (cookie != null)
                {
                    lblName.Text = cookie["name"];
                    lblEmail.Text = cookie["email"];
                }

            }
        }
    }
}
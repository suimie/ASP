using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEnvironmentalLifeCycle
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btSubmit_Click(object sender, EventArgs e)
        {
            // get the information fromthe form and add to a cookie
            HttpCookie cookie = new HttpCookie("UserInformation");
            cookie["name"] = txbName.Text;
            cookie["email"] = txbEmail.Text;
            cookie.Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("~/CookiesTarget.aspx");
        }
    }
}
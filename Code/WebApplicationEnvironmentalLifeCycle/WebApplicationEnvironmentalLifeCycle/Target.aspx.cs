using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEnvironmentalLifeCycle
{
    public partial class Target : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page previousPage = Page.PreviousPage;
            if(previousPage != null)
            {
                lblName.Text = ((TextBox)previousPage.FindControl("tbxName")).Text;
                lblEmail.Text = ((TextBox)previousPage.FindControl("tbxEmail")).Text;
            }
        }
    }
}
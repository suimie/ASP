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
            /*
             * // MEthod 1
            Page previousPage = Page.PreviousPage;
            if(previousPage != null)
            {
                lblName.Text = ((TextBox)previousPage.FindControl("txbName")).Text;
                lblEmail.Text = ((TextBox)previousPage.FindControl("txbEmail")).Text;
            }
            else
            {
                lblName.Text = "YOU DID NOT NAVIGATE FROM A PROPER PAGE";
            }
            */

            /*
            // Method 2
            lblName.Text = Request.Form["txbName"] + " -- Use Method2";
            lblEmail.Text = Request.Form["txbEmail"];
            */

            // Method 3 - strongly typed
            Navigation previousPage = (Navigation)Page.PreviousPage;

            lblName.Text = previousPage.name + " -- Use Method3(strongly typed)";
            lblEmail.Text = previousPage.email;
        }
    }
}
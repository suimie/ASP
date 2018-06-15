using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Environment_Life_Cycle
{
    public partial class target_2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            //Method 1
            Page previosPage = Page.PreviousPage;
            if(previosPage != null)
            {
                lblName.Text = ((TextBox)previosPage.FindControl("txtName")).Text;
                lblEmail.Text = ((TextBox)previosPage.FindControl("txtEmail")).Text;
            }
            else
            {
                lblName.Text = "YOU DID NOT NAVIGATE FROM A PROPER PAGE";
            }
            */
            /*
            //Method 2
            lblName.Text = Request.Form["txtName"];
            lblEmail.Text = Request.Form["txtEmail"];
            */
            //strongly typed
            
            Navigation previousPage = (Navigation)Page.PreviousPage;
            if(previousPage != null)
            {
                lblName.Text = previousPage.name;
                lblEmail.Text = previousPage.email;
                lblURL.Text = Request.UrlReferrer.ToString();
            }

        }
    }


}

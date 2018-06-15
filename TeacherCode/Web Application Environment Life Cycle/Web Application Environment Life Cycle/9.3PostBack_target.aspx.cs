using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_Environment_Life_Cycle
{
    public partial class PostBack_target : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page previous = Page.PreviousPage;
            if(previous != null && previous.IsCrossPagePostBack)
                Response.Write("This is the cross page post back..");
            else
                Response.Write("You have reached this page using the wrong means!!!");
        }
    }
}
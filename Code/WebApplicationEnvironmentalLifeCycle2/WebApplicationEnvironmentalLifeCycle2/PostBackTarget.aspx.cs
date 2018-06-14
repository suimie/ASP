using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEnvironmentalLifeCycle2
{
    public partial class PostBackTarget : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page previous = Page.PreviousPage;
            if (previous != null && previous.IsCrossPagePostBack)
                Response.Write("This is the cross page post back");
            else
                Response.Write("Yu have reached this page using the wrong means!!!");
        }
    }
}
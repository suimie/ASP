using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEnvironmentalLifeCycle
{
    public partial class ApplicationEvents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Application["NumberofApplications"] = 0;
            //Application["NumberofSessions"] = 0;
            Response.Write("Number of applications = " + Application["NumberofApplications"]);
            Response.Write("<br />");
            Response.Write("Number of session = " + Application["NumberofSessions"]);
        }
    }
}
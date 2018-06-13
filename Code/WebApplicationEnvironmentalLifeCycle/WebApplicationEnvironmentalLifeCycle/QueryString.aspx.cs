﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEnvironmentalLifeCycle
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect(
                "~/CookiesTarget.aspx?name=" + Server.UrlEncode(txbName.Text) + 
                "&email=" + Server.UrlEncode(txbEmail.Text)
                );
        }
    }
}
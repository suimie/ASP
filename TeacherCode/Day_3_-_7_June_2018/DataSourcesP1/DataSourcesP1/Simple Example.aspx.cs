using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataSourcesP1
{
    public partial class Simple_Example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                //Drop down list binding
                var answers = new string[] { "Yes", "No", "Maybe", "OK" };
                ddlBinding.DataBinding += this.ddlBinding_Event;
                //1- Source 2- Binding
                ddlBinding.DataSource = answers;
                ddlBinding.DataBind();

                //List Box Binding: array of towns, where each town has and ID and a name.
                var towns = new[]
                {
                    new{ID=1, Name = "Monteal"},
                    new{ID=2, Name = "Toronto"},
                    new{ID=3, Name = "Laval"},
                    new{ID=4, Name = "Ottawa"},
                    new{ID=5, Name = "Vancouver"}
                };
                //1-source 2-binding
                lbTowns.DataSource = towns;
                lbTowns.DataBind();

                //Bulleted List
                var searchEngines = new[]
                {
                    new{Name="Google", val ="http://www.google.com"},
                    new{Name="Bing!", val ="http://www.bing.com"},
                    new{Name="MSDN", val ="http://msdn.microsoft.com"},
                    new{Name="Yahoo", val ="http://www.yahoo.com"},
                    new{Name="DuckDuckGo", val ="http://www.DuckDuckGo.com"}
                };
                blURLs.DataSource = searchEngines;
                blURLs.DataBind();
                


            }
        }

        protected void ddlBinding_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDDLBinding.Text = "Your answer is " + ddlBinding.SelectedValue.ToString();
        }
        protected void ddlBinding_Event(object sender, EventArgs e)
        {
            lblBindingEvent.Text = "The DDL is now binded";
        }

        protected void lbTowns_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTowns.Text =
                "You have select: " +
                lbTowns.SelectedItem.ToString() +
                " - ID # " + lbTowns.SelectedValue.ToString();
        }
    }
}
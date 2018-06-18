using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
using Assignment2.Models;

namespace Assignment2
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                return;
            }

            hlGoRentMedia.Visible = false;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hlGoRentMedia.Visible = true;

            hlGoRentMedia.NavigateUrl = "~/RentMedia.aspx?customerId=" + gvCustomers.SelectedValue;
        }

        protected void dvCustomer_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            // update on detail view -> refresh gridview
            gvCustomers.DataBind();
        }

        protected void gvCustomers_RowCreated(object sender, GridViewRowEventArgs e)
        {
            gvCustomers.CellPadding = 50;
            gvCustomers.CellSpacing = 40;
        }
    }
}
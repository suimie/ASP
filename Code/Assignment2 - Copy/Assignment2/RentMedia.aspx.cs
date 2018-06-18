using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Assignment2.Models;

namespace Assignment2
{
    public partial class RentMedia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;

            // Check there is customerId in query string -> if isn't, show error msg and make <Rent Now> button disabled
            if (Request.QueryString["customerId"] == null || Request.QueryString["customerId"] == "")
            {
                btnRentNow.Enabled = false;
                lblMsg.Text = "YOU DID NOT NAVIGATE FROM A PROPER PAGE : Customer ID is necessary.";
            }
        }

        protected void btnRentNow_Click(object sender, EventArgs e)
        {
            int cId;
            // Check customerId in query string
            if (Request.QueryString["customerId"] != null && Request.QueryString["customerId"] != "") {
                cId = int.Parse(Request.QueryString["customerId"]);
                List<string> selectedMedias = ckblMedias.Items.Cast<ListItem>().Where(x => x.Selected).Select(li => li.Text).ToList();

                VideoRentalStoreRepository vrsr = new VideoRentalStoreRepository();
                vrsr.addRentalRecod(cId, selectedMedias);

                lblResult.Text = "New Rent record added successfully.";
            }
        }
    }
}
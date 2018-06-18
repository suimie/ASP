using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Assignment2.Models;

namespace Assignment2
{
    public partial class NewMedia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (Page.IsPostBack) return;

            txbTitle.Focus();
            rvYear.MaximumValue = DateTime.Now.Year.ToString();
            rvYear.ErrorMessage = "Production year between 1900 and " + DateTime.Now.Year.ToString();
            rvYear.Text = rvYear.ErrorMessage;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txbTitle.Text;
            MediaType type = (MediaType)(int.Parse(ddlType.SelectedValue));
            int year = int.Parse(txbYear.Text);

            VideoRentalStoreRepository vrsr = new VideoRentalStoreRepository();
            vrsr.addNewMedia(title, type, year);

            ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", "showMessage('New Media added successfully!')", true);
            Response.Redirect("~/Default.aspx");

        }
    }
}
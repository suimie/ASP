using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Assignment2.Models;
namespace Assignment2
{
    public partial class NewCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (Page.IsPostBack) return;

            txbFirstname.Focus();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string firstname = txbFirstname.Text;
            string lastname = txbLastname.Text;
            string address = txbAddress.Text;
            string phone = txbPhone.Text;

            VideoRentalStoreRepository vrsr = new VideoRentalStoreRepository();
            vrsr.addNewCustomer(firstname, lastname, address, phone);

            Response.Redirect("~/Default.aspx");
        }
    }
}
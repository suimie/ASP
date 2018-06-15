using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Exam1
{
    public partial class NewProductWithMaster : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (Page.IsPostBack) return;

            InitForm();

        }

        private void InitForm()
        {
            txbName.Text = "";
            txbQuantity.Text = "";
            txbPrice.Text = "0.0";

            txbInStock.Text = "0";
            txbOnOrder.Text = "0";
            txbOrderLevel.Text = "0";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string supplierId = Request.QueryString["supplierId"];

            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    string query =
                        "INSERT INTO Products VALUES ('" +
                        txbName.Text + "'," + supplierId + "," +
                        ddlCategories.SelectedValue + ",'" +
                        ((txbQuantity.Text=="")? "0" : txbQuantity.Text) + "'," +   // When user doesn't enter any value(delete default value), fill the default value
                        ((txbPrice.Text == "") ? "0" : txbPrice.Text) + "," +
                        ((txbInStock.Text == "") ? "0" : txbInStock.Text) + "," +
                        ((txbOnOrder.Text == "") ? "0" : txbOnOrder.Text) + "," +
                        ((txbOrderLevel.Text == "") ? "0" : txbOrderLevel.Text) + "," +
                        (ckbDiscontinued.Checked ? "1" : "0") +
                        ")";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    lblResult.Text = "Product added succesfully";
                    btnAdd.Enabled = false;
                }
                catch (Exception er)
                {
                    lblResult.Text = er.Message;
                }
            }

        }
    }
}
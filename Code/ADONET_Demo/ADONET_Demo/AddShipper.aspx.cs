using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// SETP 1 - ADD NAME SPACES
using System.Data;
using System.Data.SqlClient;
using System.Configuration; // This provides access to web.config

namespace ADONET_Demo
{
    public partial class AddShipper : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {

                try
                {
                    string sqlQuery = "INSERT INTO shippers (CompanyName, Phone) VALUES ('" +
                        txtName.Text + "', '" + txtPhone.Text + "')";

                    con.Open();

                    SqlCommand cmd = new SqlCommand(sqlQuery, con);


                    cmd.ExecuteNonQuery();

                    lblResult.Text = "Shipper added successfully!";
                    Response.Redirect("~/AllShippers.aspx");
                }
                catch (Exception er)
                {
                    lblResult.Text = er.Message;
                }
            }

        }
    }
}
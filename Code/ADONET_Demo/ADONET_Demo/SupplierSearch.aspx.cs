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
    public partial class SupplierSearch : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Page.IsPostBack) return;


            SqlConnection con = new SqlConnection(ConString);

            try
            {
                string sqlQuery = "SELECT * FROM suppliers";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataReader reader;

                con.Open();

                reader = cmd.ExecuteReader();

                ListItem selectItem = new ListItem();
                selectItem.Text ="Please select a supplier";
                selectItem.Value ="";

                ddlSuppliers.Items.Add(selectItem);

                while (reader.Read())
                {
                    ListItem newItem = new ListItem();
                    newItem.Text = reader["SupplierID"] + ". " + reader["CompanyName"];
                    newItem.Value = reader["SupplierID"].ToString();

                    ddlSuppliers.Items.Add(newItem);
                }
            }
            catch (Exception er)
            {
                lblConnection.ForeColor = System.Drawing.Color.Red;
                lblConnection.Text = "Connection ERROR..... :(";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);

            try
            {
                lbSuppliers.Items.Clear();
                string sqlQuery = "SELECT * FROM suppliers WHERE supplierId =" + tbxSupplierID.Text;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataReader reader;

                con.Open();
                //lblConnection.Text = "Connection establishes..... :)";

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbSuppliers.Items.Add("ID: " + reader["SupplierID"]);
                    lbSuppliers.Items.Add("Name: " + reader["CompanyName"]);
                    lbSuppliers.Items.Add("Address: " + reader["Address"]);
                    lbSuppliers.Items.Add("Phone: " + reader["Phone"]);
                }
                else
                {
                    lbSuppliers.Items.Add("NO RECORD ADDED");
                }
            }
            catch (Exception er)
            {
                lblConnection.ForeColor = System.Drawing.Color.Red;
                lblConnection.Text = "Connection ERROR..... :(";
            }
            finally
            {
                con.Close();
                //lblConnection.Text += "  ... Now the connection is closed..";
            }
        }

        protected void ddlSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);

            try
            {
                if (ddlSuppliers.SelectedIndex != 0)
                { 
                    string sqlQuery = "SELECT * FROM suppliers WHERE supplierID =" + ddlSuppliers.SelectedValue;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    SqlDataReader reader;

                    con.Open();

                    reader = cmd.ExecuteReader();

                    dvSupplier.DataSource = reader;
                    dvSupplier.DataBind();
                }
                else
                {
                    dvSupplier.DataSource = null;
                }
            }
            catch (Exception er)
            {
                lblConnection.ForeColor = System.Drawing.Color.Red;
                lblConnection.Text = "Connection ERROR..... :(";
            }

        }
    }
}


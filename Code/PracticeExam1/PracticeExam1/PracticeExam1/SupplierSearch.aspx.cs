using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration; // This provides access to web.config

namespace PracticeExam1
{
    public partial class SupplierSearch : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;

            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    string sqlQuery = "SELECT * FROM suppliers";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    SqlDataReader reader;

                    con.Open();

                    reader = cmd.ExecuteReader();

                    ListItem selectItem = new ListItem();
                    selectItem.Text = "Please select a supplier";
                    selectItem.Value = "";

                    ddlSupplierName.Items.Add(selectItem);

                    while (reader.Read())
                    {
                        ListItem newItem = new ListItem();
                        newItem.Text = reader["SupplierID"] + ". " + reader["CompanyName"];
                        newItem.Value = reader["SupplierID"].ToString();

                        ddlSupplierName.Items.Add(newItem);
                    }
                }
                catch (Exception er)
                {
                    lbxSuppliers.Items.Add("NO RECORD ADDED");
                }
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    string sqlQuery = "SELECT * FROM suppliers WHERE SupplierID=" + txbSupplierID.Text;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    SqlDataReader reader;

                    con.Open();

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lbxSuppliers.Items.Add("ID: " + reader["SupplierID"]);
                        lbxSuppliers.Items.Add("Name: " + reader["CompanyName"]);
                        lbxSuppliers.Items.Add("Address: " + reader["Address"]);
                        lbxSuppliers.Items.Add("Phone: " + reader["Phone"]);
                    }
                    else
                    {
                        lbxSuppliers.Items.Add("NO RECORD ADDED");
                    }
                }
                catch (Exception er)
                {
                    lbxSuppliers.Items.Add("NO RECORD ADDED");
                }
            }

        }


        protected void ddlSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    string sqlQuery = "SELECT * FROM suppliers WHERE SupplierID=" + ddlSupplierName.SelectedValue;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    SqlDataReader reader;

                    con.Open();

                    reader = cmd.ExecuteReader();

                    dvSupplier.DataSource = reader;
                    dvSupplier.DataBind();
                }
                catch (Exception er)
                {
                    lbxSuppliers.Items.Add("NO RECORD ADDED");
                }
            }
        }
    }
}
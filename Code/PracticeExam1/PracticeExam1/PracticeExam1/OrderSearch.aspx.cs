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
    public partial class OrderSearch : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            getOrderDetail();
           
            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    SqlDataReader reader;
                    string sqlQuery = "";

                    switch (ddlSelect.SelectedValue)
                    {
                        case "Customer Details":
                            string customerId = "";
                            for (int i = 0; i < dvDetail.Rows.Count; i++)
                            {
                                if(dvDetail.Rows[i].Cells[0].Text == "CustomerID")
                                {
                                    customerId = dvDetail.Rows[i].Cells[1].Text;
                                    break;
                                }
                            }
                            sqlQuery = "SELECT * FROM customers WHERE customerID='" + customerId + "'";
                            break;
                        case "Shipper Details":
                            string shipperId = "";
                            for (int i = 0; i < dvDetail.Rows.Count; i++)
                            {
                                if (dvDetail.Rows[i].Cells[0].Text == "ShipVia")
                                {
                                    shipperId = dvDetail.Rows[i].Cells[1].Text;
                                    break;
                                }
                            }
                            sqlQuery = "SELECT * FROM shippers WHERE ShipperID=" + shipperId;
                            break;
                    }

                    SqlCommand cmd = new SqlCommand(sqlQuery, con);

                    con.Open();

                    reader = cmd.ExecuteReader();
                    reader.Read();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        lbxInfo.Items.Add(reader.GetName(i) + ". " + reader[i].ToString());
                    }
                }
                catch (Exception er)
                {
                    throw;
                }
               
            }
        }

        private void getOrderDetail()
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    string sqlQuery = "SELECT * FROM orders WHERE orderID=" + txbOrderID.Text;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    SqlDataReader reader;
                    con.Open();

                    reader = cmd.ExecuteReader();

                    dvDetail.DataSource = reader;
                    dvDetail.DataBind();
                }
                catch (Exception er)
                {
                    throw;
                }
            }
        }
    }
}
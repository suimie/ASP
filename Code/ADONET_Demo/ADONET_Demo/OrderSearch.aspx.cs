﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration; // This provides access to web.config

namespace ADONET_Demo
{
    public partial class OrderSearch : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {

                try
                {
                    int customerShipper = ddlCustomerShipper.SelectedIndex;
                    int id = int.Parse(txbOrderID.Text);
                    string customerId = "";
                    int shipperId = 1;

                    
                    getOrderDetail(id);


                    for (int i = 0; i < dvDetail.Rows.Count; i++)
                    {
                        if (String.Equals(dvDetail.Rows[i].Cells[0].Text, "customerid", StringComparison.OrdinalIgnoreCase))
                            customerId = dvDetail.Rows[i].Cells[1].Text;
                        if (String.Equals(dvDetail.Rows[i].Cells[0].Text, "shipvia", StringComparison.OrdinalIgnoreCase))
                            shipperId = int.Parse(dvDetail.Rows[i].Cells[1].Text);
                    }

                    string sqlQuery = "";

                    switch (customerShipper)
                    {
                        case 0:
                            lblTitle2.Text = "Customer's Detail";
                            //sqlQuery = "SELECT * FROM customers WHERE customerid=(SELECT customerId FROM orders WHERE orderid=" + id + ")";
                            sqlQuery = "SELECT * FROM customers WHERE customerid='" + customerId + "'";
                            
                            break;
                        case 1:
                            lblTitle2.Text = "Shipper's Detail";
                            //sqlQuery = "SELECT * FROM shippers WHERE shipperid=(SELECT shipvia FROM orders WHERE orderid=" + id + ")";
                            sqlQuery = "SELECT * FROM shippers WHERE shipperid=" + shipperId;
                            break;
                    }


                    SqlCommand cmd = new SqlCommand(sqlQuery, con);

                    SqlDataReader reader;

                    con.Open();

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        switch (customerShipper)
                        {
                            case 0:
                                lbDetail2.Items.Add(reader["CustomerID"] + ". " + reader["CompanyName"]);
                                break;
                            case 1:
                                lbDetail2.Items.Add(reader["ShipperID"] + ". " + reader["CompanyName"]);

                                break;
                        }

                    }


                }
                catch (Exception er)
                {
                    lblTitle2.Text = "ERROR : " + er.Message;
                }

            }

        }

        private void getOrderDetail(int id)
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    string sqlQuery = "SELECT * FROM orders WHERE orderid=" + id;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    SqlDataReader reader;

                    con.Open();

                    reader = cmd.ExecuteReader();
                    dvDetail.DataSource = reader;
                    dvDetail.DataBind();

                    /*
                    if (reader.Read()) { 
                        lblTitle2.Text = reader["CustomerId"] + " - " + reader["ShipVia"];
                    }
                    */
                }
                catch (Exception er)
                {
                    lblTitle2.Text = "ERROR : " + er.Message;
                }

            }

        }
    }
}
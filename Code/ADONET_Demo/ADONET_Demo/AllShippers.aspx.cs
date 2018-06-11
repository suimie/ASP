using System;
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
    public partial class AllShippers : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    try
                    {
                        string sqlQuery = "SELECT * FROM shippers";
                        SqlCommand cmd = new SqlCommand(sqlQuery, con);
                        SqlDataReader reader;

                        con.Open();

                        reader = cmd.ExecuteReader();

                        gvShippers.DataSource = reader;
                        gvShippers.DataBind();
                    }
                    catch (Exception er)
                    {
                        lblResult.Text = er.Message;
                    }

                }

            }
        }
    }
}
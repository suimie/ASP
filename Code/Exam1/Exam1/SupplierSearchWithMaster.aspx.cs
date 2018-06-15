using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam1
{
    public partial class SupplierSearchWithMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect(
                            "~/NewProductWithMaster.aspx?supplierId=" +
                            Server.UrlEncode(ddlSuppliers.SelectedValue)
                            );

        }

        protected void gvSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvSuppliers.SelectedRow;
            string id = row.Cells[1].Text;
            Response.Redirect(
                            "~/NewProductWithMaster.aspx?supplierId=" +
                            Server.UrlEncode(id)
                            );
        }
    }
}
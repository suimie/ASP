using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Project
{
    public partial class Sequence_of_Events : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            eventLog.Items.Add("Page initialize event is called");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string msg = "Page load event is called";
            
            if(Page.IsPostBack)
                msg += "-PostBack";

            if(!Page.IsPostBack)
            {
                ddlTest.Items.Add("1");
                ddlTest.Items.Add("2");
                ddlTest.Items.Add("3");
            }
            this.addButtonToForm();
            eventLog.Items.Add(msg);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void addButtonToForm()
        {
            var btnDynamic = new Button();
            btnDynamic.Text = "Click me";
            btnDynamic.Click += this.btnDynamic_Click;
            btnDynamic.Click += this.btnDynamic2_Click;

            var lblDynamic = new Label();

            this.form1.Controls.Add(btnDynamic);
            this.form1.Controls.Add(lblDynamic);

        }
        protected void btnDynamic_Click(object sender, EventArgs e)
        {
            var lbltemp = (Label)this.form1.Controls[this.form1.Controls.Count - 1];
            lbltemp.Text += "Yaaay";
        }

        protected void btnDynamic2_Click(object sender, EventArgs e)
        {
            var lbltemp = (Label)this.form1.Controls[this.form1.Controls.Count - 1];
            lbltemp.Text += "WoooW";
        }
    }
}
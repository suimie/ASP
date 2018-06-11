using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LunchOrders
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;

            // Bind the ListBox
            string[] cities = { "Ottawa", "Montreal", "London", "Newyork", "Paris" };
            this.lbCities.DataSource = cities;
            this.lbCities.DataBind();
            this.lbCities.SelectedIndex = 1;

            // Bind the DropDownList
            string[] genders = { "Male", "Female" };
            this.ddlGender.DataSource = genders;
            this.ddlGender.DataBind();

            // Bind the CheckBoxList
            var food = new[]
            {
                new { ID=101, Text="Soup" },
                new { ID=102, Text="Salad" },
                new { ID=103, Text="Chicken" },
                new { ID=104, Text="Beef" },
                new { ID=105, Text="Fish" },
                new { ID=106, Text="Soft drink" },
                new { ID=107, Text="Water" },
                new { ID=108, Text="Coffee" },
                new { ID=109, Text="Tea" },
            };
            this.cblFood.DataSource = food;
            this.cblFood.DataBind();

            // Bind the RadioButtonList
            var paymentMethods = new[]
            {
                new { ID=1, Text="Cash" },
                new { ID=2, Text="Credit card" },
                new { ID=3, Text="Android Pay" },
                new { ID=4, Text="Apple Pay" }
            };
            this.rblPayment.DataSource = paymentMethods;
            this.rblPayment.DataBind();
            this.rblPayment.SelectedIndex = 1;


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string result =
                txtName.Text + ": Order#" + lblNumber.Text +
                "|City: " + lbCities.SelectedValue +
                "|" + ddlGender.SelectedValue +
                "|Payment: " + rblPayment.SelectedItem.Text + "(ID#" + rblPayment.SelectedItem.Value + ")" +
                "|Order:";

            for (int i = 0; i < cblFood.Items.Count; i++)
            {
                if (cblFood.Items[i].Selected)
                {
                    string food = cblFood.Items[i].Text;
                    string foodId = cblFood.Items[i].Value;
                    result += food + "(ID=" + foodId + ")";
                }
            }
            result += "|";
            lblNumber.Text = (int.Parse(lblNumber.Text)+1).ToString();
            lblOrder.Text = result;
            lbOrders.Items.Add(result);
        }
    }
}
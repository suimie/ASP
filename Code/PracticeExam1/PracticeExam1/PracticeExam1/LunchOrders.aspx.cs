using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeExam1
{
    public partial class LunchOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;

            lblOrderNumber.Text = "1";

            var towns = new[]
            {
                new {ID=1, Name="Montreal"},
                new {ID=2, Name="Quebec City"},
                new {ID=3, Name="Toronto"},
                new {ID=4, Name="Otawa"}
            };

            lbxCity.DataSource = towns;
            lbxCity.DataBind();

            var gender = new[] { "Male", "Femail" };
            ddlGender.DataSource = gender;
            ddlGender.DataBind();

            var meal = new[]
            {
                new {ID=1, Text="Burger"},
                new {ID=2, Text="Steak"},
                new {ID=3, Text="Salad"},
                new {ID=4, Text="Coke"}
            };

            cblMeal.DataSource = meal;
            cblMeal.DataBind();

            var payment = new[]
{
                new {ID=1, Text="Cash"},
                new {ID=2, Text="Credit Card"},
                new {ID=3, Text="Android Pay"},
                new {ID=4, Text="Apple Pay"}
            };

            rblPayment.DataSource = payment;
            rblPayment.DataBind();


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string selectedMeals = "";
            for (int i = 0; i < cblMeal.Items.Count; i++)
            {
                if (cblMeal.Items[i].Selected)
                {
                    if (selectedMeals != "")
                    {
                        selectedMeals += ", ";
                    }
                    selectedMeals += cblMeal.Items[i].Text;
                }
            }
            string record = lblOrderNumber.Text + ". " +
                lbxCity.SelectedValue + " | " +
                ddlGender.SelectedValue + " | " +
                selectedMeals + " | " +
                rblPayment.SelectedValue;

            lbxOrderList.Items.Add(record);
            lblOrderNumber.Text = (int.Parse(lblOrderNumber.Text) + 1).ToString();

            clearFields();
        }

        private void clearFields()
        {
            lbxCity.SelectedIndex = -1;
            ddlGender.SelectedIndex = -1;
            for (int i = 0; i < cblMeal.Items.Count; i++)
            {
                cblMeal.Items[i].Selected = false;
            }

            rblPayment.SelectedIndex = -1;
        }
    }
}
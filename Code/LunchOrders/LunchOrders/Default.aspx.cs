using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LunchOrders
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            lblOrderNu.Text = "1";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!Page.IsPostBack)
            {
                // City - ListBox
                var towns = new[]
                {
                    new{ID=1, Name="Montreal"},
                    new{ID=2, Name="Toronto"},
                    new{ID=3, Name="Laval"},
                    new{ID=4, Name="Ottawa"},
                    new{ID=5, Name="Vancouver"}
                };

                // 1- Source 
                lbCity.DataSource = towns;
                // 2- Binding
                lbCity.DataBind();

                // Gender - Drop Down List
                var gender = new string[] { "Male", "Female" };

                // 1- Source 2- Binding
                ddlGender.DataSource = gender;
                ddlGender.DataBind();

                // Meal Option - CheckBoxList
                var mealOptions = new[]
                {
                    new{ID=1, Name="Burger"},
                    new{ID=2, Name="Steak"},
                    new{ID=3, Name="Salad"},
                    new{ID=4, Name="Coke"}
                };

                cblMealOption.DataSource = mealOptions;
                cblMealOption.DataBind();


                // Payment Method - RadioButtonList
                var payment = new[]
                {
                    new{ID=1, Name="Cash"},
                    new{ID=2, Name="Credit Card"},
                    new{ID=3, Name="Android pay"},
                    new{ID=4, Name="Apple pay"}
                };

                rblPayment.DataSource = payment;
                rblPayment.DataBind();
            }
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            string order = "";
            string ordernumberStr = lblOrderNu.Text;
            string name = txName.Text;
            string city = lbCity.SelectedItem.ToString();
            string gender = ddlGender.SelectedValue;
            List<ListItem> selectedMealOption = cblMealOption.Items.Cast<ListItem>()
                            .Where(li => li.Selected)
                            .ToList();
            string payment = rblPayment.Text;


            order = ordernumberStr + " | " +
                name + " | " +
                city + " | " +
                gender + " | ";
            string meals = "";
            foreach (var meal in selectedMealOption)
            {
                if (meals == "")
                    meals = meal.ToString();
                else
                    meals += ", " + meal.ToString();
            }

            order += meals + " | " + payment;

            lbOrder.Items.Add(order);

            int orderNu = int.Parse(ordernumberStr);
            lblOrderNu.Text = (++orderNu).ToString();

            clearForm();
        }

        private void clearForm()
        {
            txName.Text = "";
            lbCity.ClearSelection();
            ddlGender.ClearSelection();
            cblMealOption.ClearSelection();
            rblPayment.ClearSelection();
        }
    }
}
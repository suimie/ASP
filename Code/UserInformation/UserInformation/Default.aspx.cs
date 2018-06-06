using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserInformation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (isFirst.Value == "true")
            {
                isFirst.Value = "false";
                txtBirthDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
                ddlProvence_SelectedIndexChanged(null, null);
            }
        }

        protected void ddlProvence_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCity.Items.Clear();
            ddlCity.Items.Add(new ListItem("Select city!", "0"));
            switch (ddlProvence.SelectedValue)
            {
                case "Ontario":
                    ddlCity.Items.Add(new ListItem("Toronto", "1"));

                    break;
                case "Quebec":
                    ddlCity.Items.Add(new ListItem("Quebec city", "1"));
                    ddlCity.Items.Add(new ListItem("Montreal", "2"));
                    break;
                case "Nova Scotia":
                    ddlCity.Items.Add(new ListItem("Halifax", "1"));
                    break;
                case "New Brunswick":
                    ddlCity.Items.Add(new ListItem("Fredericton", "1"));
                    ddlCity.Items.Add(new ListItem("Moncton", "2"));
                    break;
                case "Manitoba":
                    ddlCity.Items.Add(new ListItem("Winnipeg", "1"));
                    break;
                case "British Columbia":
                    ddlCity.Items.Add(new ListItem("Victoria", "1"));
                    ddlCity.Items.Add(new ListItem("Vancouver", "2"));
                    break;
                case "Prince Edward Island":
                    ddlCity.Items.Add(new ListItem("Charottetown", "1"));
                    break;
                case "Saskatchewan":
                    ddlCity.Items.Add(new ListItem("Regina", "1"));
                    ddlCity.Items.Add(new ListItem("Saskatoon", "2"));
                    break;
                case "Alberta":
                    ddlCity.Items.Add(new ListItem("Edmonton", "1"));
                    ddlCity.Items.Add(new ListItem("Calgary", "2"));
                    break;
                case "Newfoundland and Labrador":
                    ddlCity.Items.Add(new ListItem("St. Jonh's", "1"));
                    break;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();

            if (Page.IsValid)
            {
                lblInfo.Text = txtName.Text + "|" +
                    txtBirthDate.Text + "|" +
                    txtEmail.Text + "|" +
                    ddlProvence.SelectedValue + "|" +
                    ddlCity.SelectedValue;
                lbUsers.Items.Add(lblInfo.Text);

                clearForm();

                lblInfo.Text = "Submitted successfully! Number of record is " + updateCounter();
            }

        }

        private void clearForm()
        {
            txtName.Text = "";
            txtBirthDate.Text = "";
            txtEmail.Text = "";
            ddlProvence.ClearSelection();
            ddlProvence.SelectedIndex = 0;
            ddlProvence_SelectedIndexChanged(null, null);
            txtBirthDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            lblInfo.Text = "";
        }

        private int updateCounter()
        {
            int value = int.Parse(hidVal.Value);
            hidVal.Value = (++value).ToString();
            return value;
        }

        protected void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text = lbUsers.SelectedValue;
            String record = lbUsers.SelectedValue; ;
            string[] words = record.Split('|');
            txtName.Text = words[0];
            txtBirthDate.Text = words[1];
            txtEmail.Text = words[2];
            //ddlProvence.Items.FindByValue(words[3]).Selected = true;
            //ddlCity.Items.FindByValue(words[4]).Selected = true;
            ddlProvence.SelectedValue = words[3];
            ddlProvence_SelectedIndexChanged(null, null);
            ddlCity.SelectedValue = words[4];
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
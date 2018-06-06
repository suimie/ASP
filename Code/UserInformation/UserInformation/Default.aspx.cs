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
            if (ddlProvence.Items.Count <= 0)
            {
                ddlProvence.Items.Add("Ontario");
                ddlProvence.Items.Add("Quebec");
                ddlProvence.Items.Add("Nova Scotia");
                ddlProvence.Items.Add("New Brunswick");
                ddlProvence.Items.Add("Manitoba");
                ddlProvence.Items.Add("British Columbia");
                ddlProvence.Items.Add("Prince Edward Island");
                ddlProvence.Items.Add("Saskatchewan");
                ddlProvence.Items.Add("Alberta");
                ddlProvence.Items.Add("Newfoundland and Labrador");
            }
        }

        protected void ddlProvence_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCity.Items.Clear();
            switch (ddlProvence.SelectedIndex)
            {
                case 0:
                    ddlCity.Items.Add("Toronto");
                    break;
                case 1:
                    ddlCity.Items.Add("Quebec city");
                    ddlCity.Items.Add("Montreal");
                    break;
                case 2:
                    ddlCity.Items.Add("Halifax");
                    break;
                case 3:
                    ddlCity.Items.Add("Fredericton");
                    ddlCity.Items.Add("Moncton");
                    break;
                case 4:
                    ddlCity.Items.Add("Winnipeg");
                    break;
                case 5:
                    ddlCity.Items.Add("Victoria");
                    ddlCity.Items.Add("Vancouver");
                    break;
                case 6:
                    ddlCity.Items.Add("Charottetown");
                    break;
                case 7:
                    ddlCity.Items.Add("Regina");
                    ddlCity.Items.Add("Saskatoon");
                    break;
                case 8:
                    ddlCity.Items.Add("Edmonton");
                    ddlCity.Items.Add("Calgary");
                    break;
                case 9:
                    ddlCity.Items.Add("St. Jonh's");
                    break;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblInfo.Text = txtName.Text + " : " + txtBirthDate.Text + ", " + txtEmail.Text + ", " + ddlProvence.SelectedValue + ", " + ddlCity.SelectedValue;
            lbUsers.Items.Add(lblInfo.Text);
            txtName.Text = "";
            txtBirthDate.Text = "";
            txtEmail.Text = "";
            ddlProvence.SelectedIndex = 0;
        }


    }
}
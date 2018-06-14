using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeExam1
{
    public partial class UserInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!Page.IsPostBack) return;

            ddlCity.Items.Clear();
            switch (ddlProvince.SelectedValue)
            {
                case "Quebec":
                    ddlCity.Items.Add("Montreal");
                    ddlCity.Items.Add("Quebec City");
                    ddlCity.Items.Add("Laval");
                    break;
                case "Ontario":
                    ddlCity.Items.Add("Toronto");
                    ddlCity.Items.Add("Ottawa");
                    break;
                case "British Columbia":
                    ddlCity.Items.Add("Vancouber");
                    ddlCity.Items.Add("Columbia");
                    break;
                default:
                    break;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string info = "Name : " + txbName.Text +
                ", Email : " + txbEmail.Text +
                ", Date of Birth : " + txbDoB.Text +
                ", Province : " + ddlProvince.SelectedValue +
                ", City : " + ddlCity.SelectedValue;

            lblInfo.Text = info;
            lbUserInfo.Items.Add(info);

            clearForm();
        }

        private void clearForm()
        {
            txbName.Text = "";
            txbEmail.Text = "";
            txbDoB.Text = "";
            ddlProvince.SelectedIndex = 0;
            ddlCity.SelectedIndex = 0;            
        }

    }
}
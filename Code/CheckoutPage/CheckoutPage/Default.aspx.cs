using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckoutPage
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            summary.Visible = false;
            tbEmail.Focus();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (ckbSameAddress.Checked)
            {
                // put information in billing address part in textbox in shipping address part
                /*
                tbShipAddress.Text = tbAddress.Text;
                tbShipCity.Text = tbCity.Text;
                ddlShipProvince.SelectedValue = ddlProvence.SelectedValue;
                tbShipPostal.Text = tbPostal.Text;
                */
                tbShipAddress.Text = "";
                tbShipCity.Text = "";
                ddlShipProvince.SelectedIndex = 0;
                tbShipPostal.Text = "";

                // disable every textbox in shipping address part
                //shipAddress.Disabled = true;

                tbShipAddress.Enabled = false;
                tbShipCity.Enabled = false;
                ddlShipProvince.Enabled = false;
                tbShipPostal.Enabled = false;

                rfvShipAddress.Enabled = false;
                rfvShipCity.Enabled = false;
                rfvShipProvince.Enabled = false;
                cvShipPostal.Enabled = false;

                isCheckBoxClick.Value = "true";
            }
            else if (isCheckBoxClick.Value == "true")
            {
                // Clear textbox in shipping address part
                tbShipAddress.Text = "";
                tbShipCity.Text = "";
                ddlShipProvince.SelectedIndex = 0;
                tbShipPostal.Text = "";


                //shipAddress.Disabled = false;

                // enable every textbox in shipping address part
                tbShipAddress.Enabled = true;
                tbShipCity.Enabled = true;
                ddlShipProvince.Enabled = true;
                tbShipPostal.Enabled = true;

                rfvShipAddress.Enabled = true;
                rfvShipCity.Enabled = true;
                rfvShipProvince.Enabled = true;
                cvShipPostal.Enabled = true;


                isCheckBoxClick.Value = "false";
            }
        }



        protected void btCheckOut_Click(object sender, EventArgs e)
        {
            Page.Validate();

            if (!Page.IsValid)
            {
                summary.Visible = false;
                return;
            }

            summary.Visible = true;

            string email = tbEmail.Text;
            lblSumEmail.Text = email;

            string reemail = tbEmailReEntry.Text;
            lblSumReEmail.Text = reemail;

            string name = tbLastName.Text + ", " + tbFirstName.Text;
            lblSumName.Text = name;

            string phone = tbPhone.Text;
            lblSumPhon.Text = phone;

            string billAddr = tbAddress.Text;
            lblSumBillAddr.Text = billAddr;

            string billCity = tbCity.Text;
            lblSumBillCity.Text = billCity;

            string billState = ddlProvence.SelectedValue.ToString();
            lblSumBillState.Text = billState;

            string billZip = tbPostal.Text;
            lblSumBillZip.Text = billZip;

            // depending on selection of checkbox
            // if checked -> just show message
            if (ckbSameAddress.Checked)
            {
                divSame.Visible = true;
                divDiff.Visible = false;
            }
            else    // otherwise -> print out the information in shipping address
            {
                divSame.Visible = false;
                divDiff.Visible = true;


                string shipAddr = tbShipAddress.Text;
                lblSumShipAddress.Text = shipAddr;

                string shipCity = tbShipCity.Text;
                lblSumShipCity.Text = shipCity;

                string shipState = ddlShipProvince.SelectedValue.ToString();
                lblSumShipState.Text = shipState;

                string shipZip = tbShipPostal.Text;
                lblSumShipZip.Text = shipZip;

            }

            summary.Focus();
        }

    }
}
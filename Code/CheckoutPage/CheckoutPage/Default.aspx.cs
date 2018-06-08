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
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (ckbSameAddress.Checked)
            {
                // put information in billing address part in textbox in shipping address part
                tbShippingAddress.Text = tbAddress.Text;
                tbShippingCity.Text = tbCity.Text;
                tbShippingState.Text = tbState.Text;
                tbShippingZip.Text = tbZip.Text;


                // disable every textbox in shipping address part
                shippingAddress.Disabled = true;

                tbShippingAddress.Enabled = false;
                tbShippingCity.Enabled = false;
                tbShippingState.Enabled = false;
                tbShippingZip.Enabled = false;
            }
            else
            {
                // Clear textbox in shipping address part
                tbShippingAddress.Text = "";
                tbShippingCity.Text = "";
                tbShippingState.Text = "";
                tbShippingZip.Text = "";


                shippingAddress.Disabled = false;

                // enable every textbox in shipping address part
                tbShippingAddress.Enabled = true;
                tbShippingCity.Enabled = true;
                tbShippingState.Enabled = true;
                tbShippingZip.Enabled = true;
            }
        }



        protected void btCheckOut_Click(object sender, EventArgs e)
        {
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

            string billState = tbState.Text;
            lblSumBillState.Text = billState;

            string billZip = tbZip.Text;
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


                string shipAddr = tbShippingAddress.Text;
                lblSumShipAddress.Text = shipAddr;

                string shipCity = tbShippingCity.Text;
                lblSumShipCity.Text = shipCity;

                string shipState = tbShippingState.Text;
                lblSumShipState.Text = shipState;

                string shipZip = tbShippingZip.Text;
                lblSumShipZip.Text = shipZip;

            }
        }
    }
}
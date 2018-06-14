using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeExam1
{
    public partial class InvestmentCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!Page.IsPostBack)
            {
                for (int i = 50; i <= 500; i+=50)
                {
                    ddlInvestment.Items.Add(i.ToString());
                }
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            int.TryParse(ddlInvestment.SelectedValue, out int investment);
            decimal.TryParse(tbxRate.Text, out decimal rate);
            int.TryParse(tbxYears.Text, out int years);

            decimal result = CalculateValue(investment, rate, years);

            lblResult.Text = result.ToString("C");
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txbName.Text = "";
            ddlInvestment.SelectedIndex = 0;
            tbxRate.Text = "";
            tbxYears.Text = "";
            lblResult.Text = "";
        }

        protected decimal CalculateValue(int monthlyInvestment, decimal yearlyInterestRate, int years)
        {
            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 +
                monthlyInterestRate);
            }
            return futureValue;
        }
    }
}
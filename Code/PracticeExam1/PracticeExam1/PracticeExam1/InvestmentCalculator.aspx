<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InvestmentCalculator.aspx.cs" Inherits="PracticeExam1.InvestmentCalculator" %>

<%@ Register Src="~/Controlers/Header.ascx" TagPrefix="uc1" TagName="Header" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 131px;
        }
    </style>
</head>
<body>
    <uc1:Header runat="server" id="Header" />
    <form id="form1" runat="server" defaultButton="btnCalculate" defaultFocus="txbName">
        <div>
            <h1>Investment Calculator</h1>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Name</td>
                    <td>
                        <asp:TextBox ID="txbName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txbName" ErrorMessage="Name is Required." Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Monthly Investment</td>
                    <td>
                        <asp:DropDownList ID="ddlInvestment" runat="server">
                            <asp:ListItem Value="0">Please select amount</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvInvestment" runat="server" ControlToValidate="ddlInvestment" ErrorMessage="Please select monthly investment" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" InitialValue="0">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Interest Rate</td>
                    <td>
                        <asp:TextBox ID="tbxRate" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="tbxRate" ErrorMessage="Interest Range : 1.0-20.0" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" MaximumValue="20.0" MinimumValue="1.0" Type="Double">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Years</td>
                    <td>
                        <asp:TextBox ID="tbxYears" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="tbxYears" ErrorMessage="Years Range : 1-45" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" MaximumValue="45" MinimumValue="1" Type="Integer">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate" />
                    </td>
                    <td>
                        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
                    </td>
                </tr>
            </table>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#3333CC" />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

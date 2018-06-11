<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InvestmentCalculator.Default" %>

<%@ Register src="UserControls/Header.ascx" tagname="Header" tagprefix="uc1" %>
<%@ Register src="UserControls/Header.ascx" tagname="Header" tagprefix="uc2" %>

<%@ Register src="UserControls/Footer.ascx" tagname="Footer" tagprefix="uc3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 98%;
        }
        .auto-style2 {
            width: 238px;
        }
    </style>
</head>
<body>
            <uc2:Header ID="Header1" runat="server" />

    <form id="form1" runat="server" defaultbutton="btnCalculate" defaultfocus="txtName">
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Investment</td>
                <td>
                    <asp:DropDownList ID="ddlInvestment" runat="server" Width="130px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Annual Interest Rate </td>
                <td>
                    <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvRate" runat="server" ControlToValidate="txtRate" ErrorMessage="Interest Rate is Required!" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvRate" runat="server" ControlToValidate="txtRate" ErrorMessage="Interest rate between 1.0-20.0" ForeColor="#FF3300" MaximumValue="20" MinimumValue="1" Type="Integer" Display="Dynamic">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Number of years </td>
                <td>
                    <asp:TextBox ID="txtYears" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvYears" runat="server" ControlToValidate="txtYears" ErrorMessage="Years are required!" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvYears" runat="server" ControlToValidate="txtYears" ErrorMessage="Years between 1-50" ForeColor="Red" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                </td>
            </tr>
        </table>
        <div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Blue" />
            <br />
            <br />
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate" Width="100px" />
        &nbsp;&nbsp; &nbsp;
        <asp:Button ID="btnClear" runat="server" Text="Clear" Width="100px" OnClick="btnClear_Click" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server" Font-Size="X-Large"></asp:Label>
        <uc3:Footer ID="Footer1" runat="server" />
    </form>
</body>
</html>

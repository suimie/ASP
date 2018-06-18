<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="NewCustomer.aspx.cs" Inherits="Assignment2.NewCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 113px;
    }
    .auto-style2 {
        width: 160px;
    }
    .auto-style3 {
        width: 113px;
        height: 20px;
    }
    .auto-style4 {
        width: 160px;
        height: 20px;
    }
    .auto-style5 {
        height: 20px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <h1>New Customer</h1>
<p>
    &nbsp;</p>
<table class="nav-justified">
    <tr>
        <td class="auto-style1">First Name</td>
        <td class="auto-style2">
            <asp:TextBox ID="txbFirstname" runat="server" Width="150px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rvfFirstname" runat="server" ControlToValidate="txbFirstname" ErrorMessage="First name is required" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">First name is required</asp:RequiredFieldValidator>
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td class="auto-style1">Last Name</td>
        <td class="auto-style2">
            <asp:TextBox ID="txbLastname" runat="server" Width="150px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rvfFirstname0" runat="server" ControlToValidate="txbLastname" ErrorMessage="Last name is required" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">Last name is required</asp:RequiredFieldValidator>
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td class="auto-style1">Address</td>
        <td class="auto-style2">
            <asp:TextBox ID="txbAddress" runat="server" Width="150px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rvfFirstname1" runat="server" ControlToValidate="txbAddress" ErrorMessage="Address is required" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">Address is required is required</asp:RequiredFieldValidator>
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td class="auto-style1">Phone number</td>
        <td class="auto-style2">
            <asp:TextBox ID="txbPhone" runat="server" Width="150px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rvfFirstname2" runat="server" ControlToValidate="txbPhone" ErrorMessage="Phone number is required" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">Phone number is required</asp:RequiredFieldValidator>
            <br />
            <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txbPhone" ErrorMessage="Phone number format : 123-456-7890 or (123) 456-7890" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">Phone number format : 123-456-7890 or (123) 456-7890</asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3"></td>
        <td class="auto-style4"></td>
        <td class="auto-style5"></td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style2">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Customer" Width="152px" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

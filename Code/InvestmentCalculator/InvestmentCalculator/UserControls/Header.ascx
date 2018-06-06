<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="InvestmentCalculator.User_Controls.Header" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 300px;
        height: 168px;
    }
    .auto-style3 {
        width: 300px;
    }
    .auto-style4 {
        width: 525px;
        text-align: center;
    }
    .auto-style5 {
        text-align: center;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style3">
            <img alt="" class="auto-style2" src="../Images/investment.jfif" /></td>
        <td class="auto-style4">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="#3333CC" Text="Investment Calculator"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:Label ID="lblDate" runat="server"></asp:Label>
        </td>
    </tr>
</table>


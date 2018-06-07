<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Triangle.ascx.cs" Inherits="ShapeAreaCalculator.UserControls.Triangle" %>
<style type="text/css">
    .auto-style1 {
        width: 58%;
    }
    .auto-style3 {
        width: 221px;
    }
    .auto-style6 {
        width: 83px;
        text-align: center;
    }
    .auto-style5 {
        text-align: center;
    }
    .auto-style4 {
        width: 83px;
    }
    .auto-style7 {
        width: 238px;
        height: 212px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style3" rowspan="4">
            <img alt="" class="auto-style7" src="Images/triangle.png" /></td>
        <td class="auto-style6">
            <asp:Label ID="Label1" runat="server" Text="Base"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="txbBase" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="rfvBase" runat="server" ErrorMessage="Base is required" Font-Bold="True" ForeColor="Red">Base is required</asp:RequiredFieldValidator>
            <br />
            <asp:RangeValidator ID="rvBase" runat="server" ControlToValidate="txbWidth" ErrorMessage="Positive number only" Font-Bold="True" ForeColor="Red" MaximumValue="999999" MinimumValue="0" Type="Double">Positive number only</asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Label ID="Label2" runat="server" Text="Height"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="txbHeight" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="rfvHeight" runat="server" ErrorMessage="Height is required" Font-Bold="True" ForeColor="Red">Height is required</asp:RequiredFieldValidator>
            <br />
            <asp:RangeValidator ID="rvHeight" runat="server" ControlToValidate="txbWidth" ErrorMessage="Positive number only" Font-Bold="True" ForeColor="Red" MaximumValue="999999" MinimumValue="0" Type="Double">Positive number only</asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style5">
            <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate Area" />
        </td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Label ID="Label3" runat="server" Text="Area"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:Label ID="lblArea" runat="server"></asp:Label>
        </td>
    </tr>
</table>


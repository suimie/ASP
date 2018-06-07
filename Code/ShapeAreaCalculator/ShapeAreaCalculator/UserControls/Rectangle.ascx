<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Rectangle.ascx.cs" Inherits="ShapeAreaCalculator.UserControls.Rectangle" %>
<style type="text/css">
    .auto-style1 {
        width: 58%;
    }
    .auto-style2 {
        width: 259px;
        height: 194px;
    }
    .auto-style3 {
        width: 221px;
    }
    .auto-style4 {
        width: 83px;
    }
    .auto-style5 {
        text-align: center;
    }
    .auto-style6 {
        width: 83px;
        text-align: center;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style3" rowspan="4">
            <img alt="" class="auto-style2" src="Images/rectangle.png" /></td>
        <td class="auto-style6">
            <asp:Label ID="Label1" runat="server" Text="Width"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="txbWidth" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="rfvWidth" runat="server" ErrorMessage="Width is required" Font-Bold="True" ForeColor="Red">Width is required</asp:RequiredFieldValidator>
            <br />
            <asp:RangeValidator ID="rvWidth" runat="server" ControlToValidate="txbWidth" ErrorMessage="Positive number only" Font-Bold="True" ForeColor="Red" MaximumValue="999999" MinimumValue="0" Type="Double">Positive number only</asp:RangeValidator>
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


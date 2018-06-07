<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Circle.ascx.cs" Inherits="ShapeAreaCalculator.UserControls.Circle" %>
<style type="text/css">
    .auto-style1 {
        width: 49%;
    }
    .auto-style2 {
        width: 124px;
    }
    .auto-style8 {
        width: 195px;
        text-align: center;
    }
    .auto-style7 {
        text-align: center;
    }
    .auto-style4 {
        width: 203px;
        text-align: center;
    }
    .auto-style5 {
        text-align: left;
    }
    .auto-style9 {
        width: 225px;
        height: 225px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style2" rowspan="3">
            <img alt="" class="auto-style9" src="Images/circle.png" /></td>
        <td class="auto-style8" rowspan="2">
            <asp:Label ID="Label1" runat="server" Text="Radius"></asp:Label>
        </td>
        <td class="auto-style7" colspan="2">
            <asp:TextBox ID="txbRadius" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="rfvRadius" runat="server" ErrorMessage="Radius is required" Font-Bold="True" ForeColor="Red" ControlToValidate="txbRadius">Radius is required</asp:RequiredFieldValidator>
            <br />
            <asp:RangeValidator ID="rvRadius" runat="server" ControlToValidate="txbRadius" ErrorMessage="Positive number only" Font-Bold="True" ForeColor="Red" MaximumValue="999999" MinimumValue="0" Type="Double">Positive number only</asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style7" colspan="2">
            <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate Area" />
        </td>
    </tr>
    <tr>
        <td class="auto-style8">
            <asp:Label ID="Label2" runat="server" Text="Area"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:Label ID="lblArea" runat="server"></asp:Label>
        </td>
        <td class="auto-style5">&nbsp;</td>
    </tr>
</table>


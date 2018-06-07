<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Square.ascx.cs" Inherits="ShapeAreaCalculator.UserControls.Square" %>
<style type="text/css">
    .auto-style1 {
        width: 49%;
    }
    .auto-style2 {
        width: 124px;
    }
    .auto-style3 {
        width: 225px;
        height: 225px;
    }
    .auto-style4 {
        width: 203px;
        text-align: center;
    }
    .auto-style5 {
        text-align: left;
    }
    .auto-style7 {
        text-align: center;
    }
    .auto-style8 {
        width: 195px;
        text-align: center;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style2" rowspan="3">
            <img alt="" class="auto-style3" src="Images/square.png" /></td>
        <td class="auto-style8" rowspan="2">
            <asp:Label ID="Label1" runat="server" Text="Width"></asp:Label>
        </td>
        <td class="auto-style7" colspan="2">
            <asp:TextBox ID="txbWidth" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="rfvWidth" runat="server" ErrorMessage="Width is required" Font-Bold="True" ForeColor="Red" ControlToValidate="txbWidth">Width is required</asp:RequiredFieldValidator>
            <br />
            <asp:RangeValidator ID="rvWidth" runat="server" ControlToValidate="txbWidth" ErrorMessage="Positive number only" Font-Bold="True" ForeColor="Red" MaximumValue="999999" MinimumValue="0" Type="Double">Positive number only</asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style7" colspan="2">
            <asp:Button ID="btnCalculateS" runat="server" OnClick="btnCalculateS_Click" Text="Calculate Area" />
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


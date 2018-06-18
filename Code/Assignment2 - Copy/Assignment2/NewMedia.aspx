<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="NewMedia.aspx.cs" Inherits="Assignment2.NewMedia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 20px;
    }
    .auto-style2 {
        width: 189px;
    }
    .auto-style3 {
        height: 20px;
        width: 189px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Add New Media</h1>
<p>
    &nbsp;</p>
<table class="nav-justified">
    <tr>
        <td>Title</td>
        <td class="auto-style2">
            <asp:TextBox ID="txbTitle" runat="server" Width="180px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="txbTitle" ErrorMessage="Title is required" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">Title is required</asp:RequiredFieldValidator>
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td>Type</td>
        <td class="auto-style2">
            <asp:DropDownList ID="ddlType" runat="server" Width="180px">
                <asp:ListItem Value="-1">Please select media type</asp:ListItem>
                <asp:ListItem Value="0">Movies</asp:ListItem>
                <asp:ListItem Value="1">TV Show</asp:ListItem>
                <asp:ListItem Value="3">Others</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvType" runat="server" ControlToValidate="ddlType" ErrorMessage="Type is required." Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" InitialValue="-1">Type is required.</asp:RequiredFieldValidator>
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td>Production Year</td>
        <td class="auto-style2">
            <asp:TextBox ID="txbYear" runat="server" TextMode="Number" Width="180px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvYear" runat="server" ControlToValidate="txbYear" ErrorMessage="Production year is required" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">Production year is required</asp:RequiredFieldValidator>
            <br />
            <asp:RangeValidator ID="rvYear" runat="server" ControlToValidate="txbYear" ErrorMessage="Production year between 1900 and 2018" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" MaximumValue="2018" MinimumValue="1900" Type="Integer">Production year between 1900 and 2018</asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1"></td>
        <td class="auto-style3"></td>
        <td class="auto-style1"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add New Media" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

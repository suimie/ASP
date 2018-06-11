<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LunchOrders.Home" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>Binding List Controls - Demo</title>
    <link rel="Stylesheet" href="Site.css" type="text/css" />
</head>

<body>
    <form id="formMain" runat="server">

        <h1>Lunch Orders </h1>
        <table id="layoutTable">
            <tr>
                <td>Order #</td>
                <td>
                    <asp:Label ID="lblNumber" runat="server" Font-Bold="True" ForeColor="#3333FF" Text="1"></asp:Label>
                </td>
                <td rowspan="9">&nbsp;
                    <asp:ListBox ID="lbOrders" runat="server" Height="254px" Width="689px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td>Attendee&#39;s Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Choose town from the ListBox:</td>
                <td><asp:ListBox ID="lbCities" runat="server"></asp:ListBox></td>
            </tr>
            <tr>
                <td>Select your gender from the DropDownList:</td>
                <td><asp:DropDownList ID="ddlGender" runat="server" Height="16px"></asp:DropDownList></td>
            </tr>
            <tr>
                <td>Select your favourite food from the CheckBoxList:</td>
                <td><asp:CheckBoxList ID="cblFood" runat="server"
                    DataTextField="Text" DataValueField="ID"></asp:CheckBoxList></td>
            </tr>
            <tr>
                <td>Select how you will pay from the RadioButtonList:</td>
                <td><asp:RadioButtonList ID="rblPayment" runat="server"
                    DataTextField="Text" DataValueField="ID"></asp:RadioButtonList></td>
            </tr>
            <tr>
                <td colspan="2" id="submitButtonCell">
                    <asp:Button ID="btnSubmit" runat="server"
                        Text="Submit Orders" onclick="btnSubmit_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" id="submitButtonCell">
                    &nbsp;</td>
            </tr>
            <tr id="ResultsRow" runat="server" visible="false">
                <td colspan="2">
                    &nbsp;</td>
            </tr>
        </table>
        <p>
            <asp:Label ID="lblOrder" runat="server"></asp:Label>
        </p>
    </form>
</body>

</html>

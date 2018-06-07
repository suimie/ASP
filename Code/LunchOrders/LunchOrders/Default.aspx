<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LunchOrders.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/lunchorderStyle.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="XX-Large" Text="Lunch Order"></asp:Label>
        </p>
        <table id="orderTable" class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Order Number"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblOrderNu" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txName" ErrorMessage="Name is required" Font-Bold="True" ForeColor="Red">Name is required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>City</td>
                <td>
                    <br />
                    <asp:ListBox ID="lbCity" runat="server" DataTextField="Name" DataValueField="ID"></asp:ListBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:DropDownList ID="ddlGender" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Meal Options</td>
                <td>
                    <br />
                    <asp:CheckBoxList ID="cblMealOption" runat="server" DataTextField="Name" DataValueField="ID">
                    </asp:CheckBoxList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>Payment Method</td>
                <td>
                    <br />
                    <asp:RadioButtonList ID="rblPayment" runat="server" DataTextField="Name" ItemType="ID">
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>

        </table>

        <div>
        </div>
        <br />
        <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" Text="Order" />
        <br />
        <br />
        <strong>Order List</strong><br />
        <asp:ListBox ID="lbOrder" runat="server" Width="100%"></asp:ListBox>
    </form>
</body>
</html>

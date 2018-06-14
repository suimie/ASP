<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LunchOrders.aspx.cs" Inherits="PracticeExam1.LunchOrders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        table td{
            border:1px solid blue;
            padding:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Lunch Orders</h1>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td>Order Number</td>
                    <td>
                        <asp:Label ID="lblOrderNumber" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>City</td>
                    <td>
                        <asp:ListBox ID="lbxCity" runat="server" DataValueField="Name" Width="242px"></asp:ListBox>
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
                        <asp:CheckBoxList ID="cblMeal" runat="server" DataValueField="Text">
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>Payment Method</td>
                    <td>
                        <asp:RadioButtonList ID="rblPayment" runat="server" DataValueField="Text">
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <asp:ListBox ID="lbxOrderList" runat="server" Width="663px"></asp:ListBox>
        </div>
    </form>
</body>
</html>

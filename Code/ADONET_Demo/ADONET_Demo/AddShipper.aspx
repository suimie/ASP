<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddShipper.aspx.cs" Inherits="ADONET_Demo.AddShipper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 123px;
        }
        .auto-style3 {
            width: 174px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>New Shipper Form</h1>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Company Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Phone Number</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtPhone" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPhone" ErrorMessage="RequiredFieldValidator" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Insert" />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

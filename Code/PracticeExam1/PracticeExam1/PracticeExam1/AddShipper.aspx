<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddShipper.aspx.cs" Inherits="PracticeExam1.AddShipper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            New Shipper Form<br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td>Company Name</td>
                    <td>
                        <asp:TextBox ID="txbName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txbName" ErrorMessage="Company Name is required." Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">Company Name is required.</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Phone Number</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txbPhone" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName0" runat="server" ControlToValidate="txbPhone" ErrorMessage="Phone number is required." Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">Phone number is required.</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnInser" runat="server" OnClick="btnInser_Click" Text="Insert" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>

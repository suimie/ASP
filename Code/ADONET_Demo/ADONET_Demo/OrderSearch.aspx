<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderSearch.aspx.cs" Inherits="ADONET_Demo.OrderSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 160px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Orders Search</h1>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Order ID</td>
                    <td>
                        <asp:TextBox ID="txbOrderID" runat="server" TextMode="Number" Width="215px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Customer &amp; Shipper</td>
                    <td>
                        <asp:DropDownList ID="ddlCustomerShipper" runat="server">
                            <asp:ListItem>Customer</asp:ListItem>
                            <asp:ListItem>Shipper</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <br />
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#000066" Text="Order's Detail"></asp:Label>
        <br />
        <asp:DetailsView ID="dvDetail" runat="server" Height="50px" Width="498px">
        </asp:DetailsView>
        <p>
            <asp:Label ID="lblTitle2" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#000066"></asp:Label>
        </p>
        <p>
            <asp:ListBox ID="lbDetail2" runat="server" Width="492px"></asp:ListBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

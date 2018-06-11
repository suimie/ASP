<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierSearch.aspx.cs" Inherits="ADONET_Demo.SupplierSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: smaller;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            width: 107px;
        }
        .auto-style5 {
            width: 141px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style4">Supplier ID :</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbxSupplierID" runat="server" TextMode="Number" Width="318px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" CssClass="auto-style3" OnClick="btnSearch_Click" Text="Search" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        <asp:ListBox ID="lbSuppliers" runat="server" Width="325px"></asp:ListBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlSuppliers" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSuppliers_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlSuppliers" ErrorMessage="RequiredFieldValidator" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" InitialValue="Please select a supplier"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        <asp:DetailsView ID="dvSupplier" runat="server" Height="50px" Width="320px">
                        </asp:DetailsView>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblConnection" runat="server" CssClass="auto-style1" Font-Bold="True" ForeColor="#006600"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShapeAreaCalculator.Default" %>

<%@ Register src="UserControls/Header.ascx" tagname="Header" tagprefix="uc1" %>
<%@ Register src="UserControls/Footer.ascx" tagname="Footer" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style5 {
            width: 94px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            <uc1:Header ID="Header1" runat="server" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label4" runat="server" Text="Shape"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Select Shape</asp:ListItem>
                        <asp:ListItem>Square</asp:ListItem>
                        <asp:ListItem>Rectangle</asp:ListItem>
                        <asp:ListItem>Triangle</asp:ListItem>
                        <asp:ListItem>Circle</asp:ListItem>
                        <asp:ListItem>Ellipse</asp:ListItem>
                        <asp:ListItem>Trapezoid</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <br />
                    <br />
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
        <uc2:Footer ID="Footer1" runat="server" />
    </form>
</body>
</html>

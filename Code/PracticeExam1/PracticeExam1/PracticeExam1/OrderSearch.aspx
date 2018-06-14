<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderSearch.aspx.cs" Inherits="PracticeExam1.OrderSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Order Search</h1>
            <br />
            <br />
            Order ID :&nbsp;&nbsp;
            <asp:TextBox ID="txbOrderID" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:DropDownList ID="ddlSelect" runat="server">
                <asp:ListItem>Customer Details</asp:ListItem>
                <asp:ListItem>Shipper Details</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
            <br />
            <br />
            <asp:DetailsView ID="dvDetail" runat="server" Height="50px" Width="416px">
            </asp:DetailsView>
            <br />
            <br />
            <asp:ListBox ID="lbxInfo" runat="server" Width="415px"></asp:ListBox>
        </div>
    </form>
</body>
</html>

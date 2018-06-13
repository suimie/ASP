<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order Search.aspx.cs" Inherits="ObjectDS.Order_Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            Order Date<br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <br />
            <strong>Orders by date<br />
            </strong>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <strong>Products<br />
            </strong>
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>

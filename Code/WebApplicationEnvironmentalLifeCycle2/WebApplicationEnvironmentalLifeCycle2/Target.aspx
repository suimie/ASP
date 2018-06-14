<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Target.aspx.cs" Inherits="WebApplicationEnvironmentalLifeCycle.Target" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This is target page 2<br />
            <br />
            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/Navigation.aspx" Text="Button" />
        </div>
    </form>
</body>
</html>

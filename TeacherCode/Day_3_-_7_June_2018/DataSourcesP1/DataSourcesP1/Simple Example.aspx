<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Simple Example.aspx.cs" Inherits="DataSourcesP1.Simple_Example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Menu<asp:BulletedList ID="blURLs" runat="server" DataTextField="Name" DataValueField="val" DisplayMode="HyperLink">
            </asp:BulletedList>
            <br />
            Drop Down List Binding</strong><br />
            <br />
            <asp:DropDownList ID="ddlBinding" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlBinding_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblDDLBinding" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblBindingEvent" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <strong>List Box Binding</strong><br />
            <br />
            <asp:ListBox ID="lbTowns" runat="server" AutoPostBack="True" DataTextField="Name" DataValueField="ID" OnSelectedIndexChanged="lbTowns_SelectedIndexChanged"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="lblTowns" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Navigation.aspx.cs" Inherits="WebApplicationEnvironmentalLifeCycle.Navigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ASP Hyperlink control<br />
            <br />
            <asp:HyperLink ID="hlInternal" runat="server" NavigateUrl="~/NavigationTarget.aspx">ASP Control Hyperlink</asp:HyperLink>
            <br />
            <asp:HyperLink ID="hyExternal" runat="server" NavigateUrl="http://www.google.com">ASP External</asp:HyperLink>
            <br />
            <br />
            Response Redirect Demo<br />
            <br />
            <asp:Button ID="btInternal" runat="server" OnClick="btInternal_Click" Text="Redirect Internal" />
            <br />
            <br />
            <asp:Button ID="btExternal" runat="server" OnClick="btExternal_Click" Text="Redirect External" />
            <br />
            <br />
            Server Transfer<br />
            <asp:Button ID="tbTransferIn" runat="server" OnClick="tbTransferIn_Click" Text="Transfer Internal" />
            <br />
            <br />
            <asp:Button ID="btTransferEx" runat="server" OnClick="btTransferEx_Click" Text="Transfer External" />
            <br />
            <br />
            User Name:&nbsp;
            <asp:TextBox ID="txbName" runat="server"></asp:TextBox>
            <br />
            <br />
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Transfer(Target2)" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Server Excute(Target 2)" />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button2" runat="server" PostBackUrl="~/PostBackTarget.aspx" Text="Cross Page PostBack" />
        </div>
    </form>
</body>
</html>

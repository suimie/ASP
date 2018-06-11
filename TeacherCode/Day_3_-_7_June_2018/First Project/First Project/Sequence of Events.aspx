<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sequence of Events.aspx.cs" Inherits="First_Project.Sequence_of_Events" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="eventLog" runat="server">
            </asp:BulletedList>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
        <asp:DropDownList ID="ddlTest" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    </form>
</body>
</html>

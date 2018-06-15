<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllShippers.aspx.cs" Inherits="PracticeExam1.AllShippers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Shippers List</h1>
            <br />
            <br />
            <asp:GridView ID="gvShippers" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

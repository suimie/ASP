<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierSearch.aspx.cs" Inherits="PracticeExam1.SupplierSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Supplier Search Page</h1>
            <br />
            <br />
            Supplier ID :
            <asp:TextBox ID="txbSupplierID" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
            <br />
            <br />
            <asp:ListBox ID="lbxSuppliers" runat="server" Width="351px"></asp:ListBox>
            <br />
            <br />
            Supplier Name :&nbsp; <asp:DropDownList ID="ddlSupplierName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSupplierName_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:DetailsView ID="dvSupplier" runat="server" Height="50px" Width="343px">
            </asp:DetailsView>
        </div>
    </form>
</body>
</html>

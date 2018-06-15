<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SupplierSearchWithMaster.aspx.cs" Inherits="Exam1.SupplierSearchWithMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div style="width:800px;margin:auto;padding:10px">
        <h1>Supplier Search</h1>
        <br />
        <br />
        <br />
        <span class="auto-style1"><strong>Search by company name</strong></span><br /><br />
&nbsp;Suppliers :&nbsp;
        <asp:DropDownList ID="ddlSuppliers" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="ODSSuppliers" DataTextField="CompanyName" DataValueField="SupplierID" OnSelectedIndexChanged="ddlSuppliers_SelectedIndexChanged">
            <asp:ListItem Value="0">Please select a supplier.</asp:ListItem>
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ODSSuppliers" runat="server" SelectMethod="getSuppliersList" TypeName="Exam1.BAL.BAL_Northwind"></asp:ObjectDataSource>
        <br />
        <br />
        <span class="auto-style1"><strong>Search by city</strong></span><br /><br />
        <asp:Label ID="Label1" runat="server" Text="City"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txbCity" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search by City" />
        <br />
        <br />
        <span class="auto-style1"><strong>Suppliers List</strong></span><br />
        <br />
        <asp:GridView ID="gvSuppliers" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ODSSuppliersByCity" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="gvSuppliers_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="SupplierID" HeaderText="SupplierID" SortExpression="SupplierID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="ContactName" HeaderText="ContactName" SortExpression="ContactName" />
                <asp:BoundField DataField="ContactTitle" HeaderText="ContactTitle" SortExpression="ContactTitle" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Region" HeaderText="Region" SortExpression="Region" />
                <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" SortExpression="PostalCode" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax" />
                <asp:BoundField DataField="HomePage" HeaderText="HomePage" SortExpression="HomePage" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ODSSuppliersByCity" runat="server" SelectMethod="getSuppliersListByCity" TypeName="Exam1.BAL.BAL_Northwind">
            <SelectParameters>
                <asp:ControlParameter ControlID="txbCity" DefaultValue="null" Name="city" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>

</asp:Content>

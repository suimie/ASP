<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="Assignment2.Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }

        table th{
            padding:10px;
            text-align:center;
        }
        table td{
            padding:5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <input type="hidden" id="hvCustomerId" name="customerId" value="0" runat="server" />
    <h1>Customers Page</h1><br /><br />
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="gvCustomers" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ODSCustomers" DataKeyNames="ID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellSpacing="0" Width="80%" OnRowCreated="gvCustomers_RowCreated">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" CssClass=' Padding="10px"' />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ODSCustomers" runat="server" SelectMethod="getAllCustomers" TypeName="Assignment2.Models.VideoRentalStoreRepository"></asp:ObjectDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p class="auto-style1">
        <strong>Customer&#39;s Details</strong></p>
    <p>
        <asp:DetailsView ID="dvCustomer" runat="server" AutoGenerateEditButton="True" AutoGenerateRows="False" DataSourceID="ODSSelectedCustomer" Height="50px" OnItemUpdated="dvCustomer_ItemUpdated" Width="350px">
            <Fields>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
            </Fields>
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ODSSelectedCustomer" runat="server" SelectMethod="getCustomerById" TypeName="Assignment2.Models.VideoRentalStoreRepository" UpdateMethod="updateCustomer">
            <SelectParameters>
                <asp:ControlParameter ControlID="gvCustomers" DefaultValue="0" Name="id" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:ControlParameter ControlID="gvCustomers" DefaultValue="0" Name="id" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="dvCustomer" DefaultValue="null" Name="firstname" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="dvCustomer" DefaultValue="null" Name="lastname" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="dvCustomer" DefaultValue="null" Name="address" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="dvCustomer" DefaultValue="null" Name="phoneNumber" PropertyName="SelectedValue" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p style="width:80%;text-align:right;">
        <asp:HyperLink ID="hlGoRentMedia" runat="server" NavigateUrl="~/RentMedia.aspx" Font-Bold="True" Font-Size="Larger">Go Rent Media</asp:HyperLink>
    </p>
</asp:Content>

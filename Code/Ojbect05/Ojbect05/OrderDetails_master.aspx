<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderDetails_master.aspx.cs" Inherits="Ojbect05.OrderDetails_master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script src="scripts/demo.js"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    My content will be here
    <div>
        <h1>Order Search</h1>
        <br />
        <br />
        <span class="auto-style1"><strong>Select Order Date</strong></span><br />
        <asp:Calendar ID="CalendarOrderDate" runat="server" SelectedDate="1996-07-01" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" VisibleDate="1996-01-01" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <br />
        <span class="auto-style1"><strong>Orders List </strong></span>
        <br />
        <asp:Label ID="lblDate" runat="server" Font-Underline="True" ForeColor="#000066"></asp:Label>
        <br />
        <asp:GridView ID="gvOrdersByDate" runat="server" AutoGenerateColumns="False" DataSourceID="ODSOrders" DataKeyNames="OrderID">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="OrderID" HeaderText="OrderID" SortExpression="OrderID" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" SortExpression="EmployeeID" />
                <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" SortExpression="OrderDate" />
                <asp:BoundField DataField="RequiredDate" HeaderText="RequiredDate" SortExpression="RequiredDate" />
                <asp:BoundField DataField="ShippedDate" HeaderText="ShippedDate" SortExpression="ShippedDate" />
                <asp:BoundField DataField="ShipVia" HeaderText="ShipVia" SortExpression="ShipVia" />
                <asp:BoundField DataField="Freight" HeaderText="Freight" SortExpression="Freight" />
                <asp:BoundField DataField="ShipName" HeaderText="ShipName" SortExpression="ShipName" />
                <asp:BoundField DataField="ShipAddress" HeaderText="ShipAddress" SortExpression="ShipAddress" />
                <asp:BoundField DataField="ShipCity" HeaderText="ShipCity" SortExpression="ShipCity" />
                <asp:BoundField DataField="ShipRegion" HeaderText="ShipRegion" SortExpression="ShipRegion" />
                <asp:BoundField DataField="ShipPostalCode" HeaderText="ShipPostalCode" SortExpression="ShipPostalCode" />
                <asp:BoundField DataField="ShipCountry" HeaderText="ShipCountry" SortExpression="ShipCountry" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODSOrders" runat="server" SelectMethod="getOrdersByDate" TypeName="Ojbect05.BAL.BAL_Northwind">
            <SelectParameters>
                <asp:ControlParameter ControlID="CalendarOrderDate" DefaultValue="null" Name="orderDate" PropertyName="SelectedDate" Type="DateTime" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <span class="auto-style1"><strong>Products List</strong></span><br />
        <asp:GridView ID="gvOrdersByCustomer" runat="server" AutoGenerateColumns="False" DataSourceID="ODSOrdersByCustomer">
        </asp:GridView>
        <asp:ObjectDataSource ID="ODSOrdersByCustomer" runat="server" SelectMethod="getOrderDetailsByOrderID" TypeName="Ojbect05.BAL.BAL_Northwind">
            <SelectParameters>
                <asp:ControlParameter ControlID="gvOrdersByDate" DefaultValue="0" Name="orderid" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <br />
        <br />
        <br />
        <a href="OrderDetails_master.aspx?Print=true">Printable version</a>

    </div>
</asp:Content>

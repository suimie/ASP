﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderSearch.aspx.cs" Inherits="ObjectDS.OrderSearch" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Order Search</h1>
            <strong>
            <br class="auto-style1" />
            <br class="auto-style1" />
            </strong><span class="auto-style1"><strong>Select order date</strong></span><br />
            <asp:Calendar ID="Calendar1" runat="server" SelectedDate="1996-07-19" VisibleDate="1996-07-19"></asp:Calendar>
            <br />
            <br />
            <span class="auto-style1"><strong>Orders List</strong></span><br />
            <asp:GridView ID="gvOrderList" runat="server" AutoGenerateColumns="False" DataSourceID="ODSOrdersByOrderDate" DataKeyNames="OrderID">
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
            <asp:ObjectDataSource ID="ODSOrdersByOrderDate" runat="server" SelectMethod="getOrdersByOrderDate" TypeName="ObjectDS.BAL.BAL_Northwind">
                <SelectParameters>
                    <asp:ControlParameter ControlID="Calendar1" DefaultValue="null" Name="orderDate" PropertyName="SelectedDate" Type="DateTime" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <strong>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <span class="auto-style1">Order Details List</span></strong><br />
            <br />
            <asp:GridView ID="gvOrdersByID" runat="server" DataSourceID="ODSOrdersByID">
            </asp:GridView>
            <asp:ObjectDataSource ID="ODSOrdersByID" runat="server" SelectMethod="getOrderDetailsByOrderID" TypeName="ObjectDS.BAL.BAL_Northwind">
                <SelectParameters>
                    <asp:ControlParameter ControlID="gvOrderList" DefaultValue="0" Name="orderID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>

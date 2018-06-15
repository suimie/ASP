<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ObjectDS.Default" %>

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
            <h1>Northwind Database</h1>
            <br />
            <br />
            Countries :
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ODSCountries" AutoPostBack="True">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ODSCountries" runat="server" SelectMethod="getAllCountriesInCustomers" TypeName="ObjectDS.BAL.BAL_Northwind"></asp:ObjectDataSource>
            <br />
            <br />
            <span class="auto-style1"><strong>Customers List By Country</strong></span><br />
            <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="ODSCustomersByCountry">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
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
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ODSCustomersByCountry" runat="server" SelectMethod="getAllCustomersByCountry" TypeName="ObjectDS.BAL.BAL_Northwind">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" DefaultValue="null" Name="country" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <br />
            <br />
            <span class="auto-style1"><strong>Customer&#39;s Information</strong></span><br />
            <asp:DetailsView ID="dvCustomerInfo" runat="server" AutoGenerateRows="False" DataSourceID="ODSCustomerByID" Height="50px" Width="395px">
                <Fields>
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
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
                </Fields>
            </asp:DetailsView>
            <asp:ObjectDataSource ID="ODSCustomerByID" runat="server" SelectMethod="getCustomerByID" TypeName="ObjectDS.BAL.BAL_Northwind">
                <SelectParameters>
                    <asp:ControlParameter ControlID="gvCustomers" DefaultValue="null" Name="customerID" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>

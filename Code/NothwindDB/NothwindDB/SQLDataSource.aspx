<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SQLDataSource.aspx.cs" Inherits="NothwindDB.SQLDataSource" %>

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
            <h1>Customer by Country</h1>
            <br />
            <span class="auto-style1"><strong>Countries<br />
            </strong></span>
            <br />
            <asp:DropDownList ID="ddlCountries" runat="server" AutoPostBack="True" DataSourceID="SQLdsCountries" DataTextField="Country" DataValueField="Country" AppendDataBoundItems="True">
                <asp:ListItem Text="Please select a country" Value="" />
            </asp:DropDownList>
            <asp:SqlDataSource ID="SQLdsCountries" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" SelectCommand="SELECT DISTINCT [Country] FROM [Customers]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="CustomerID" DataSourceID="SQLdsCustomers" AllowPaging="True" AllowSorting="True">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ContactName" HeaderText="Name" SortExpression="ContactName" />
                    <asp:BoundField DataField="CompanyName" HeaderText="Company" SortExpression="CompanyName" />
                    <asp:BoundField DataField="ContactTitle" HeaderText="Title" SortExpression="ContactTitle" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                </Columns>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
            <asp:SqlDataSource ID="SQLdsCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" SelectCommand="SELECT [CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [Phone] FROM [Customers] WHERE ([Country] = @Country) ORDER BY [CompanyName]">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlCountries" DefaultValue="null" Name="Country" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <span class="auto-style1"><strong>Selected Customer<br />
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="CustomerID" DataSourceID="SQLdsCustomer" Height="50px" Width="335px">
                <EditRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <Fields>
                    <asp:BoundField DataField="ContactName" HeaderText="Name" SortExpression="ContactName" />
                    <asp:BoundField DataField="CompanyName" HeaderText="Company" SortExpression="CompanyName" />
                    <asp:BoundField DataField="ContactTitle" HeaderText="Title" SortExpression="ContactTitle" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="Region" HeaderText="Region" SortExpression="Region" />
                    <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" SortExpression="PostalCode" />
                    <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                    <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
            </asp:DetailsView>
            <asp:SqlDataSource ID="SQLdsCustomer" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" DeleteCommand="DELETE FROM [Customers] WHERE [CustomerID] = @CustomerID" InsertCommand="INSERT INTO [Customers] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax)" SelectCommand="SELECT * FROM [Customers] WHERE ([CustomerID] = @CustomerID)" UpdateCommand="UPDATE [Customers] SET [CompanyName] = @CompanyName, [ContactName] = @ContactName, [ContactTitle] = @ContactTitle, [Address] = @Address, [City] = @City, [Region] = @Region, [PostalCode] = @PostalCode, [Country] = @Country, [Phone] = @Phone, [Fax] = @Fax WHERE [CustomerID] = @CustomerID">
                <DeleteParameters>
                    <asp:Parameter Name="CustomerID" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="CustomerID" Type="String" />
                    <asp:Parameter Name="CompanyName" Type="String" />
                    <asp:Parameter Name="ContactName" Type="String" />
                    <asp:Parameter Name="ContactTitle" Type="String" />
                    <asp:Parameter Name="Address" Type="String" />
                    <asp:Parameter Name="City" Type="String" />
                    <asp:Parameter Name="Region" Type="String" />
                    <asp:Parameter Name="PostalCode" Type="String" />
                    <asp:Parameter Name="Country" Type="String" />
                    <asp:Parameter Name="Phone" Type="String" />
                    <asp:Parameter Name="Fax" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView1" DefaultValue="null" Name="CustomerID" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="CompanyName" Type="String" />
                    <asp:Parameter Name="ContactName" Type="String" />
                    <asp:Parameter Name="ContactTitle" Type="String" />
                    <asp:Parameter Name="Address" Type="String" />
                    <asp:Parameter Name="City" Type="String" />
                    <asp:Parameter Name="Region" Type="String" />
                    <asp:Parameter Name="PostalCode" Type="String" />
                    <asp:Parameter Name="Country" Type="String" />
                    <asp:Parameter Name="Phone" Type="String" />
                    <asp:Parameter Name="Fax" Type="String" />
                    <asp:Parameter Name="CustomerID" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
            </strong></span>
        </div>
    </form>
</body>
</html>

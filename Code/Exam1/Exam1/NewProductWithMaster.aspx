<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewProductWithMaster.aspx.cs" Inherits="Exam1.NewProductWithMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 139px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div style="width:500px;margin:auto;padding:10px">
        <h1>New Product</h1>
        <br />
        <span class="auto-style2"><strong>New Product Information</strong></span><br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Product Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txbName" runat="server" Width="150px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txbName" ErrorMessage="Name is required." Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">Name is required.</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Category</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="ddlCategories" runat="server" AppendDataBoundItems="True" DataSourceID="SQLDSCategories" DataTextField="CategoryName" DataValueField="CategoryID">
                        <asp:ListItem Value="0">Please select category</asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SQLDSCategories" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" SelectCommand="SELECT DISTINCT [CategoryID], [CategoryName] FROM [Categories]"></asp:SqlDataSource>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvCategories" runat="server" ControlToValidate="ddlCategories" ErrorMessage="Please select a category" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" InitialValue="0">Please select a category</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Quantity Per Unit</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txbQuantity" runat="server" Width="150px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvQuantity" runat="server" ControlToValidate="txbQuantity" ErrorMessage="Quantity per unit is required." Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">Quantity per unit is required.</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Unit Price</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txbPrice" runat="server" Width="150px"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="revPrice" runat="server" ControlToValidate="txbPrice" ErrorMessage="Digit(Integer, Double) only" Font-Bold="True" Font-Italic="True" Font-Size="Small" ForeColor="#CC0000" ValidationExpression="\d*\.?\d*">Digit(Integer, Double) only</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Units In Stock</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txbInStock" runat="server" TextMode="Number" Width="150px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Units On Order</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txbOnOrder" runat="server" TextMode="Number" Width="150px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Order Level</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txbOrderLevel" runat="server" TextMode="Number" Width="150px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:CheckBox ID="ckbDiscontinued" runat="server" Text="Discontinued" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add New Product" />
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SupplierSearchWithMaster.aspx">Supplier Search</asp:HyperLink>
                </td>
            </tr>
        </table>
        <br />
        <br />
    <asp:Label ID="lblResult" runat="server" ForeColor="Blue"></asp:Label>
        <br />
    </div>
    <br />

</asp:Content>

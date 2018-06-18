<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment2.Default1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Video Rental Store</h1>
    <br /><br />
        <div class="row" style="margin-top:30px;">
            <div class="col-sm-3">
&nbsp;<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/customers.png" PostBackUrl="~/Customers.aspx" Width="100%" />
&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
            <div class="col-sm-3">
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/rent_media.jpg" PostBackUrl="~/RentMedia.aspx" Width="100%" />
&nbsp;&nbsp;&nbsp;&nbsp;

            </div>
            <div class="col-sm-3">
    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/new_customer.png" PostBackUrl="~/NewCustomer.aspx" Width="100%" />
&nbsp;&nbsp;&nbsp;&nbsp;

            </div>
            <div class="col-sm-3">
    <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Images/new_medi.jpg" PostBackUrl="~/NewMedia.aspx" Width="100%" />
&nbsp;

            </div>
        </div>

</asp:Content>

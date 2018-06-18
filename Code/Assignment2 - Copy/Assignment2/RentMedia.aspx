<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="RentMedia.aspx.cs" Inherits="Assignment2.RentMedia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2"  ContentPlaceHolderID="mainContent" runat="server">
    <h1>Rent Media</h1>
    <p>
        &nbsp;</p>
    <h3>
        <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#3333FF"></asp:Label>
    </h3>
    <h3>Search by title</h3>
    <p>
        Title for search :
        <asp:TextBox ID="txbSearchKeyword" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search" />
    </p>
    <p>
        <asp:CheckBoxList ID="ckblMedias" runat="server" DataSourceID="ODSMediasByTitle" DataTextField="Title" DataValueField="ID">
        </asp:CheckBoxList>
        <asp:ObjectDataSource ID="ODSMediasByTitle" runat="server" SelectMethod="getMediasByTitle" TypeName="Assignment2.Models.VideoRentalStoreRepository">
            <SelectParameters>
                <asp:ControlParameter ControlID="txbSearchKeyword" DefaultValue="null" Name="title" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblResult" runat="server" ForeColor="#3333FF"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnRentNow" runat="server" OnClick="btnRentNow_Click" Text="Rent Now" />
    </p>
</asp:Content>

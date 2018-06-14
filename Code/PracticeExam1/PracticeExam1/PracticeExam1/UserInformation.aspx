<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInformation.aspx.cs" Inherits="PracticeExam1.UserInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style3 {
            width: 102px;
        }
        .auto-style4 {
            height: 30px;
            width: 102px;
        }
    </style>
</head>
<body>
    <form id="form1" defaultButton="btnSubmit" defaultFocus="txbName" runat="server">
        <div>
            <h1>User Information</h1>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Name</td>
                    <td>
                        <asp:TextBox ID="txbName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txbName" ErrorMessage="Name is requiered" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Date of Birth</td>
                    <td>
                        <asp:TextBox ID="txbDoB" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDoB" runat="server" ControlToValidate="txbDoB" ErrorMessage="Date of Birth is requiered" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revDoB" runat="server" ControlToValidate="txbDoB" ErrorMessage="Format : 2018-01-01" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" ValidationExpression="([12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01]))">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Email</td>
                    <td>
                        <asp:TextBox ID="txbEmail" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txbEmail" ErrorMessage="Email is requiered" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txbEmail" ErrorMessage="abc@company.com" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Province</td>
                    <td>
                        <asp:DropDownList ID="ddlProvince" runat="server" AutoPostBack="True">
                            <asp:ListItem Value="0">Please select province</asp:ListItem>
                            <asp:ListItem>Quebec</asp:ListItem>
                            <asp:ListItem>Ontario</asp:ListItem>
                            <asp:ListItem>British Columbia</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvProvince" runat="server" ControlToValidate="ddlProvince" ErrorMessage="Please select province" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" InitialValue="0">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">City</td>
                    <td>
                        <asp:DropDownList ID="ddlCity" runat="server">
                            <asp:ListItem Value="0">Please select city</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="ddlCity" ErrorMessage="Please select city" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" InitialValue="0">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnClear" runat="server" Text="Clear" />
                    </td>
                </tr>
            </table>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Blue" />
            <br />
            <br />
            <asp:Label ID="lblInfo" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Blue"></asp:Label>
            <br />
            <asp:ListBox ID="lbUserInfo" runat="server" Width="428px"></asp:ListBox>
        </div>
    </form>
</body>
</html>

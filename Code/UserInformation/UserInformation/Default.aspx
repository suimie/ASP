<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserInformation.Default" Title="User Information" ErrorPage="error.html" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            font-size: xx-large;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 169px;
        }
        .auto-style4 {
            text-decoration: underline;
            font-size: larger;
        }
        .auto-style5 {
            width: 169px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="btnSubmit" defaultfocus="txtName">
        <div>
        </div>
        <span class="auto-style1">User Information</span><table class="auto-style2">
            <input type="hidden" id="hidVal" name="hidVal" value="0" runat="server" />
            <input type="hidden" id="isFirst" name="isFirst" value="true" runat="server" />
            <tr>
                <td class="auto-style3">Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required!" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Date of Birth</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtBirthDate" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvBirthDate" runat="server" ControlToValidate="txtBirthDate" ErrorMessage="Date of Birth is required!" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvBirthDate" runat="server" ControlToValidate="txtBirthDate" ErrorMessage="Invalid Date type" ForeColor="Red" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"  Width="200px"></asp:TextBox>            
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is required!" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Provence</td>
                <td>
                    <asp:DropDownList ID="ddlProvence" runat="server" AutoPostBack="True" Height="25px" OnSelectedIndexChanged="ddlProvence_SelectedIndexChanged" Width="200px">
                        <asp:ListItem Value="Ontario">Ontario</asp:ListItem>
                        <asp:ListItem>Quebec</asp:ListItem>
                        <asp:ListItem>Nova Scotia</asp:ListItem>
                        <asp:ListItem>New Brunswick</asp:ListItem>
                        <asp:ListItem>Manitoba</asp:ListItem>
                        <asp:ListItem>British Columbia</asp:ListItem>
                        <asp:ListItem>Prince Edward Island</asp:ListItem>
                        <asp:ListItem>Saskatchewan</asp:ListItem>
                        <asp:ListItem>Alberta</asp:ListItem>
                        <asp:ListItem>Newfoundland and Labrador</asp:ListItem>
                        <asp:ListItem Selected="True" Value="10">Select Provence</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="cvProvence" runat="server" ControlToValidate="ddlProvence" ErrorMessage="Select Provence" ForeColor="Red" Operator="NotEqual" ValueToCompare="10">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">City</td>
                <td>
                    <asp:DropDownList ID="ddlCity" runat="server" Height="25px" Width="200px">
                    </asp:DropDownList>
                    <asp:CompareValidator ID="cvCity" runat="server" ControlToValidate="ddlCity" ErrorMessage="Select City" ForeColor="Red" Operator="NotEqual" ValueToCompare="0">*</asp:CompareValidator>
                </td>
            </tr>
        </table>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#0033CC" />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" Width="100px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" Width="100px" />
        <br />
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
        <br />
        <br />
        <span class="auto-style4"><strong>Submitted users</strong></span><br />
        <asp:ListBox ID="lbUsers" runat="server" Width="417px" AutoPostBack="True" OnSelectedIndexChanged="lbUsers_SelectedIndexChanged"></asp:ListBox>
    </form>
</body>
</html>

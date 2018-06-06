<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="Default.aspx.cs" Inherits="UserInformation.Default" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <span class="auto-style1">User Information</span><table class="auto-style2">
            <tr>
                <td class="auto-style3">Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Date of Birth</td>
                <td>
                    <asp:TextBox ID="txtBirthDate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Provence</td>
                <td>
                    <asp:DropDownList ID="ddlProvence" runat="server" AutoPostBack="true" Height="20px" OnSelectedIndexChanged="ddlProvence_SelectedIndexChanged" Width="130px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">City</td>
                <td>
                    <asp:DropDownList ID="ddlCity" runat="server" Height="20px" Width="130px">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
        <br />
        <br />
        <span class="auto-style4"><strong>Submitted users</strong></span><br />
        <asp:ListBox ID="lbUsers" runat="server" Width="417px"></asp:ListBox>
    </form>
</body>
</html>

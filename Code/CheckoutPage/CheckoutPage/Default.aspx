<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CheckoutPage.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="styles/style.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.0/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/js/bootstrap.min.js" ></script>
    <title>Checkout Page</title>
    
    <style type="text/css">
        .auto-style2 {
            left: 0px;
            top: 0px;
            width: 143px;
        }
        </style>
    
</head>
<body>
    <div class="container">
        <h1>Check Out Page</h1>
        <div class="top-info">
            <p>Please correct these entries.</p>
            <div style="margin-left:40px;margin-top:0px;">
            </div>            
        </div>
        <br />
        <br />
        <form id="form1" runat="server">
            <h3>Contact Information</h3>
            <div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbEmail" class="auto-style2">
                            Email Address:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbEmail" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-5" style="text-align: right">
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="tbEmail" ErrorMessage="Email address" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Must be a valid email address</asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-row ">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbEmailReEntry" class="auto-style2">
                            Email Re-entry:
                        </label>&nbsp;
                    </div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbEmailReEntry" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4" style="text-align: right">
                        <asp:CompareValidator ID="cvReEmail" runat="server" ControlToCompare="tbEmail" ControlToValidate="tbEmailReEntry" ErrorMessage="Email re-entry" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000">Must match first email address</asp:CompareValidator>                        
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbFirstName" class="auto-style2">
                            First Name:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbFirstName" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-5">
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbLastName" class="auto-style2">                        
                            Last Name:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbLastName" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-5">
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbPhone" class="auto-style2">
                            Phone Number:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbPhone" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4" style="text-align: right">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbPhone" ErrorMessage="Phone number" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" ValidationExpression="\d{3}-\d{3}-\d{4}">Use this format: 123-456-7890</asp:RegularExpressionValidator>
                        
                    </div>
                    <div class="form-group col-md-5">
                    </div>
                </div>
            </div>
            <h3>Billing Address</h3>
            <div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbAddress" class="auto-style2">
                            Address:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbAddress" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4" style="text-align: right">                        
                    </div>
                    <div class="form-group col-md-5">
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbCity" class="auto-style2">
                            City:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbCity" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4" style="text-align: right">                        
                    </div>
                    <div class="form-group col-md-5">
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbState" class="auto-style2">
                            State:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbState" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4" style="text-align: right">                        
                    </div>
                    <div class="form-group col-md-5">
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbZip" class="auto-style2">
                            Zip code:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbZip" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4" style="text-align: right">                        
                    </div>
                    <div class="form-group col-md-5">
                    </div>
                </div>
            </div>
            <h3>Shipping Address</h3>
            <div class="form-row">
                <div class="form-group col-md-3 text-right"></div>
                <div class="form-group col-md-4 text-left">
                    <asp:CheckBox ID="ckbSameAddress" runat="server" AutoPostBack="true" />
                    <asp:Label ID="Label1" runat="server" Text="Label">Same as billing address</asp:Label>
                </div>
            </div>
            <div id="shippingAddress"  runat="server">
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbShippingAddress" class="auto-style2">
                            Address:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbShippingAddress" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4" style="text-align: right">                        
                    </div>
                    <div class="form-group col-md-5">
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbShippingCity" class="auto-style2">
                            City:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbShippingCity" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4" style="text-align: right">                        
                    </div>
                    <div class="form-group col-md-5">
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbShippingState" class="auto-style2">
                            State:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbShippingState" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4" style="text-align: right">                        
                    </div>
                    <div class="form-group col-md-5">
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbShippingZip" class="auto-style2">
                            Zip code:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbShippingZip" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4" style="text-align: right">                        
                    </div>
                    <div class="form-group col-md-5">
                    </div>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-3 text-right"></div>
                <div class="form-group col-md-4 text-left">
                    <asp:Button ID="btCheckOut" runat="server" Text="Check Out" OnClick="btCheckOut_Click" />
                </div>
            </div>
        </form>
    </div>

    <br /><br />
    <div id="summary" runat="server">
        <h1 style="color:#dc3545">Summary</h1>
        <div class="summary">
            <h4 style="color:#e83e8c">Contact Information&nbsp;&nbsp;<i class="fa fa-address-card-o" style="font-size:30px;color:#e83e8c"></i></h4>
            <div style="margin-top:0px;">
                <ul>
                    <li><div class="row"><div class="col col-md-3">Email address</div><div class="col col-md-6"><asp:Label ID="lblSumEmail" runat="server"></asp:Label></div></div></li>
                    <li><div class="row"><div class="col col-md-3">Email re-entry</div><div class="col col-md-6"><asp:Label ID="lblSumReEmail" runat="server"></asp:Label></div></div></li>
                    <li><div class="row"><div class="col col-md-3">Name</div><div class="col col-md-6"><asp:Label ID="lblSumName" runat="server"></asp:Label></div></div></li>
                    <li><div class="row"><div class="col col-md-3">Phone number</div><div class="col col-md-6"><asp:Label ID="lblSumPhon" runat="server"></asp:Label></div></div></li>
                </ul>
            </div>            
            <div class="row">
                <div class="col col-md-6">
                    <h4 style="color:#e83e8c">Billing Address&nbsp;&nbsp;<i class="fa fa-credit-card" style="font-size:30px;color:#e83e8c"></i></h4>
                    <div style="margin-top:0px;">
                        <ul>
                            <li><div class="row">
                                <div class="col col-md-4">Address</div><div class="col col-md-5">
                                <asp:Label ID="lblSumBillAddr" runat="server"></asp:Label>
                                </div></div></li>
                            <li><div class="row">
                                <div class="col col-md-4">City</div><div class="col col-md-3"><asp:Label ID="lblSumBillCity" runat="server"></asp:Label></div></div></li>
                            <li><div class="row">
                                <div class="col col-md-4">State</div><div class="col col-md-4"><asp:Label ID="lblSumBillState" runat="server"></asp:Label></div></div></li>
                            <li><div class="row"><div class="col col-md-4">Zip code</div><div class="col col-md-4"><asp:Label ID="lblSumBillZip" runat="server"></asp:Label></div></div></li>
                        </ul>
                    </div>            
                </div>
                <div class="col col-md-6">
                    <h4 style="color:#e83e8c">Shipping Address&nbsp;&nbsp;<i class="fa fa-truck" style="font-size:30px;color:#e83e8c"></i></h4>
                    <div id="divDiff" style="margin-top:0px;" runat="server">
                        <ul>
                            <li><div class="row">
                                <div class="col col-md-4">Address</div><div class="col col-md-6"><asp:Label ID="lblSumShipAddress" runat="server"></asp:Label></div></div></li>
                            <li><div class="row">
                                <div class="col col-md-4">City</div><div class="col col-md-3"><asp:Label ID="lblSumShipCity" runat="server"></asp:Label></div></div></li>
                            <li><div class="row">
                                <div class="col col-md-4">State</div><div class="col col-md-4"><asp:Label ID="lblSumShipState" runat="server"></asp:Label></div></div></li>
                            <li><div class="row"><div class="col col-md-4">Zip code</div><div class="col col-md-4"><asp:Label ID="lblSumShipZip" runat="server"></asp:Label></div></div></li>
                        </ul>
                    </div>           
                    <div id="divSame" style="margin-top:0px;" runat="server">
                        <p style="color:#dc3545;font-weight:bold;font-size:large;">Shipping address is same as billing address.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>


</body>
</html>

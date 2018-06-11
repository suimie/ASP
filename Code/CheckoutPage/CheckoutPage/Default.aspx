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
    <script>
        function validateEmail(sender, args) {
            if (args.Value.length == 0) {
                args.IsValid = false;
            } else {
                var re = /\S+@\S+\.\S+/;
                if (re.test(args.Value) == false) {
                    args.IsValid = false;
                }
            }
        }

        function validateReEmail(sender, args) {
            var email = document.getElementById("tbEmail");
            if (args.Value.length == 0 || args.Value != email.value) {
                args.IsValid = false;
            } 
        }


        function validateName(sender, args) {
            if (args.Value.length == 0) {
                args.IsValid = false;
            } else {
                var re = /^[a-zA-Z ]+$/;
                if (re.test(args.Value) == false) {
                    args.IsValid = false;
                }
            }
        }

        function validatePhone(sender, args) {
            if (args.Value.length == 0) {
                args.IsValid = false;
            } else {
                var re = /\d{3}-\d{3}-\d{4}/;
                if (re.test(args.Value) == false) {
                    args.IsValid = false;
                }
            }
        }    

        function validatePostal(sender, args) {
            if (args.Value.length == 0) {
                args.IsValid = false;
            } else {
                var re = /[A-Za-z]\d[A-Za-z] ?\d[A-Za-z]\d/;
                if (re.test(args.Value) == false) {
                    args.IsValid = false;
                }
            }
        }
    </script>
    
</head>
<body>
    <div class="container">
        <h1>Check Out Page</h1>
        <form id="form1" runat="server">
        <div class="top-info">
            <p>Please correct these entries.</p>
            <div style="margin-left:40px;margin-top:0px;">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </div>            
        </div>
        <br />
        <br />
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
                    <div class="form-group col-md-5">
                        <asp:CustomValidator ID="cvEmail" runat="server" ClientValidationFunction="validateEmail" ControlToValidate="tbEmail" ErrorMessage="Email address" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" ValidateEmptyText="True" SetFocusOnError="True">Must be a valid email address</asp:CustomValidator>
                    </div>
                </div>
                <div class="form-row ">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbEmailReEntry" class="auto-style2">
                            Email Re-entry:
                        </label>&nbsp;
                    </div>
                    <div class="form-group col-md-4" style="left: 0px; top: 1px">
                        <asp:TextBox class="form-control"   ID="tbEmailReEntry" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4">
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="validateReEmail" ControlToValidate="tbEmailReEntry" ErrorMessage="Email re-entry" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" ValidateEmptyText="True" SetFocusOnError="True">Must match first email address</asp:CustomValidator>

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
                        <asp:CustomValidator ID="cvFirstName" runat="server" ClientValidationFunction="validateName" ControlToValidate="tbFirstName" ErrorMessage="First Name" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" ValidateEmptyText="True" SetFocusOnError="True">First Name is required.</asp:CustomValidator>
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
                        <asp:CustomValidator ID="cvLastName" runat="server" ClientValidationFunction="validateName" ControlToValidate="tbLastName" ErrorMessage="Last Name" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" ValidateEmptyText="True" SetFocusOnError="True">Last Name is required.</asp:CustomValidator>
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
                    <div class="form-group col-md-4">
                        <asp:CustomValidator ID="cvPhone" runat="server" ClientValidationFunction="validatePhone" ControlToValidate="tbPhone" ErrorMessage="Phone number" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" ValidateEmptyText="True" SetFocusOnError="True">Use this format: 123-456-7890</asp:CustomValidator>
                        
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
                    <div class="form-group col-md-5" style="left: 0px; top: 0px">
                        <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="tbAddress" ErrorMessage="Billing Address" Font-Bold="True" Font-Size="small" ForeColor="#CC0000" SetFocusOnError="True" >Billing Address is required.</asp:RequiredFieldValidator>
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
                    <div class="form-group col-md-5">
                        <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="tbCity" ErrorMessage="City in Billing Address" Font-Bold="True" Font-Size="small" ForeColor="#CC0000" SetFocusOnError="True" >City in Billing Address is required.</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbState" class="auto-style2">
                            Province:
                        </label>
                        &nbsp;</div>
                    <div class="form-group col-md-4">
                    <div class="dropdown">
                        <asp:DropDownList ID="ddlProvence" runat="server" class="btn btn-outline-dark dropdown-toggle" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" style="width:100%;">

                            <asp:ListItem Value="0">Select a province please</asp:ListItem>
                            <asp:ListItem>Ontario</asp:ListItem>
                            <asp:ListItem>Quebec</asp:ListItem>
                            <asp:ListItem>Nova Scotia</asp:ListItem>
                            <asp:ListItem>New Brunswick</asp:ListItem>
                            <asp:ListItem>Manitoba</asp:ListItem>
                            <asp:ListItem>British Columbia</asp:ListItem>
                            <asp:ListItem>Prince Edward Island</asp:ListItem>
                            <asp:ListItem>Saskatchewan</asp:ListItem>
                            <asp:ListItem>Alberta</asp:ListItem>
                        </asp:DropDownList>
                     </div>
                    
                    </div>
                    <div class="form-group col-md-5">
                        <asp:RequiredFieldValidator ID="rfvProvence" runat="server" ControlToValidate="ddlProvence" ErrorMessage="Province in Billing address" InitialValue="0" Display="Dynamic" Font-Bold="True" Font-Size="small" ForeColor="#CC0000" SetFocusOnError="True" >Select a province please</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbZip" class="auto-style2">
                            Postal code: </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbPostal" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-5">
                        <asp:CustomValidator ID="cvPostal" runat="server" ClientValidationFunction="validatePostal" ControlToValidate="tbPostal" ErrorMessage="Billing Postal code" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" ValidateEmptyText="True" SetFocusOnError="True">Use this format: A1B2C3</asp:CustomValidator>
                        
                    </div>
                </div>
            </div>
            <h3>Shipping Addressass</h3>
            <input type="hidden" id="isCheckBoxClick" name="isCheckBoxClick" runat="server" value="false" /> 
            <div class ="form-row">
                <div class="form-group col-md-3 text-right"></div>
                <div class="form-group col-md-4 text-left">
                    <asp:CheckBox ID="ckbSameAddress" runat="server" AutoPostBack="true" />
                    <asp:Label ID="Label1" runat="server" Text="Label">Same as billing address</asp:Label>
                </div>
            </div>
            <div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbAddress" class="auto-style2">
                            Address:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbShipAddress" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-5" style="left: 0px; top: 0px">
                        <asp:RequiredFieldValidator ID="rfvShipAddress" runat="server" ControlToValidate="tbShipAddress" ErrorMessage="Shipping Address" Font-Bold="True" Font-Size="small" ForeColor="#CC0000" SetFocusOnError="True" >Shipping Address is required.</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbCity" class="auto-style2">
                            City:
                        </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbShipCity" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-5">
                        <asp:RequiredFieldValidator ID="rfvShipCity" runat="server" ControlToValidate="tbShipCity" ErrorMessage="City in Shipping Address" Font-Bold="True" Font-Size="small" ForeColor="#CC0000" SetFocusOnError="True" >City in Shipping Address is required.</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbState" class="auto-style2">
                            Province:
                        </label>
                        &nbsp;</div>
                    <div class="form-group col-md-4">
                    <div class="dropdown">
                        <asp:DropDownList ID="ddlShipProvince" runat="server" class="btn btn-outline-dark dropdown-toggle" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" style="width:100%;">

                            <asp:ListItem Value="0">Select a province please</asp:ListItem>
                            <asp:ListItem>Ontario</asp:ListItem>
                            <asp:ListItem>Quebec</asp:ListItem>
                            <asp:ListItem>Nova Scotia</asp:ListItem>
                            <asp:ListItem>New Brunswick</asp:ListItem>
                            <asp:ListItem>Manitoba</asp:ListItem>
                            <asp:ListItem>British Columbia</asp:ListItem>
                            <asp:ListItem>Prince Edward Island</asp:ListItem>
                            <asp:ListItem>Saskatchewan</asp:ListItem>
                            <asp:ListItem>Alberta</asp:ListItem>
                        </asp:DropDownList>
                     </div>
                    
                    </div>
                    <div class="form-group col-md-5">
                        <asp:RequiredFieldValidator ID="rfvShipProvince" runat="server" ControlToValidate="ddlShipProvince" ErrorMessage="Province in Shipping address" InitialValue="0" Display="Dynamic" Font-Bold="True" Font-Size="small" ForeColor="#CC0000" SetFocusOnError="True" >Select a province please</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3 text-right">
                        <label for="tbZip" class="auto-style2">
                            Postal code: </label>&nbsp;</div>
                    <div class="form-group col-md-4">
                        <asp:TextBox class="form-control"   ID="tbShipPostal" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-5">
                        <asp:CustomValidator ID="cvShipPostal" runat="server" ClientValidationFunction="validatePostal" ControlToValidate="tbShipPostal" ErrorMessage="Postal code in Shipping address" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000" ValidateEmptyText="True" SetFocusOnError="True">Use this format: A1B2C3</asp:CustomValidator>
                        
                    </div>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-3 text-right"></div>
                <div class="form-group col-md-4 text-left">
                    <asp:Button  class="btn btn-info" ID="btCheckOut" runat="server" Text="Check Out" OnClick="btCheckOut_Click" />
                </div>
            </div>

        </form>
    </div>

    <br /><br />
    <div id="summary" class="summary" runat="server">
        <h1 style="color:#dc3545">Summary</h1>
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
</body>
</html>

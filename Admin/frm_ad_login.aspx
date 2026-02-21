<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frm_ad_login.aspx.cs" Inherits="Admin_frm_ad_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../BootStrap/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
            <div class="offset-4 col-lg-4 col-md-4 col-sm-4 col-xl-4 p-3 my-4" style="border-radius: 5px; background-color: rgba(255,255,255, 0.4);">
                <h2 class="h2">Login</h2>
                <div class="form-group">
                    <label for="txtEmaillogin" class="col-form-label">Email address</label>
                    <asp:TextBox CssClass="form-control p-2 shadow" ID="txtEmail" runat="server"/>
                </div>
                <div class="form-group ">
                    <label for="txtpasswordlogin" class="col-form-label">Password</label>
                    <asp:TextBox CssClass="form-control p-2 shadow" ID="txtpwd" runat="server" TextMode="Password" />
                </div>
                <asp:Button ID="btnlogin" runat="server" Text="Log in" CssClass="btn btn-success py-2 px-4 shadow" OnClick="btnlogin_Click" />                
            </div>
        </div>

        </div>
    </form>
</body>
</html>

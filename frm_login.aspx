<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frm_login.aspx.cs" Inherits="frm_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="offset-4 col-lg-4 col-md-4 col-sm-4 col-xl-4 p-3 my-4" style="border-radius: 5px; background-color: rgba(125,125,125, 0.4);">
            <h2 class="h2">Login</h2>
            <div class="alert alert-danger" role='alert' id="lblmsg" runat="server" />
            <div class="form-group">
                <label class="col-form-label">Email address</label>
                <asp:TextBox CssClass="form-control p-2 shadow" ID="txt_Email" runat="server" TextMode="Email" placeholder="example@gmail.com" />
            </div>
            <div class="form-group ">
                <label class="col-form-label">Password</label>
                <asp:TextBox CssClass="form-control p-2 shadow" ID="txt_password" runat="server" TextMode="Password" />
            </div>
            <asp:Button ID="btnLogin" runat="server" Text="Log in" CssClass="btn btn-success py-2 px-4 shadow" OnClick="btnLogin_Click" />
            <div class="dropdown-divider"></div>
            <a class="dropdown-item" href="frm_registration.aspx">User Register Here</a>
            <a class="dropdown-item" href="#">Forgot password?</a>
        </div>
    </div>
</asp:Content>


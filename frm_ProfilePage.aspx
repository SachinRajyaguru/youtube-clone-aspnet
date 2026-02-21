<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="frm_ProfilePage.aspx.cs" Inherits="frm_ProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="offset-4 col-lg-4 col-md-4 col-sm-4 col-xl-4 p-3 my-4" style="border-radius: 5px; background-color: rgba(125,125,125, 0.4);">
            <h2 class="h2">User profile</h2>
            <div class="form-group">
                <label class="col-form-label">User Name</label>
                <asp:TextBox ID="txtUser" runat="server" ReadOnly="true" Enabled="false" CssClass="form-control p-2 shadow" AutoCompleteType="FirstName" />
            </div>
            <div class="form-group">
                <label class="col-form-label">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" ReadOnly="true" Enabled="false" CssClass="form-control p-2 shadow" AutoPostBack="True" TextMode="Password" />

            </div>
            <div class="form-group">
                <label class="col-form-label">Email</label>
                <asp:TextBox ID="txtEmail" runat="server" ReadOnly="true" Enabled="false" CssClass="form-control p-2 shadow" />

            </div>
            <div class="form-group">
                <label class="col-form-label">Mobile Number</label>
                <asp:TextBox ID="txtMobile" runat="server" ReadOnly="true" Enabled="false" CssClass="form-control p-2 shadow" />

            </div>
            <div class="btn-group">
                <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn-outline-primary btn" OnClick="btnEdit_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn-outline-secondary btn" Enabled="False" OnClick="btnUpdate_Click" />
            </div>
        </div>
    </div>
</asp:Content>

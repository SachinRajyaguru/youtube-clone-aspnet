<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frm_registration.aspx.cs" Inherits="frm_registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="offset-4 col-lg-4 col-md-4 col-sm-4 col-xl-4 p-3 my-4" style="border-radius: 5px; background-color: rgba(125,125,125, 0.4);">
            <h2 class="h2">Registration</h2>
            <div class="form-group">
                <div class="row">
                    <div class="col-6">
                        <label class="col-form-label">First Name</label>
                        <asp:TextBox CssClass="form-control p-2 shadow" ID="txtFirstName" runat="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ErrorMessage="Enter first name" ControlToValidate="txtFirstName" runat="server" Display="Dynamic" ForeColor="Red" />
                    </div>
                    <div class="col-6">
                        <label class="col-form-label">Last Name</label>
                        <asp:TextBox CssClass="form-control p-2 shadow" ID="txtLastName" runat="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ErrorMessage="Enter last name" ControlToValidate="txtLastName" runat="server" Display="Dynamic" ForeColor="Red" />
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="row">
                    <div class="col-6">
                        <label class="col-form-label">Email address</label>
                        <asp:TextBox CssClass="form-control p-2 shadow" ID="txtEmail" runat="server" TextMode="Email" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ErrorMessage="Choose a Gmail addresss" ControlToValidate="txtEmail" runat="server" Display="Dynamic" ForeColor="Red" />
                    </div>
                    <div class="col-6">
                        <label class="col-form-label">Password</label>
                        <asp:TextBox CssClass="form-control p-2 shadow" ID="txtPassword" runat="server" TextMode="Password" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ErrorMessage="Enter a password" ControlToValidate="txtPassword" runat="server" Display="Dynamic" ForeColor="Red" />
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="row">
                    <div class="col-6">
                        <label class="col-form-label">Mobile Number</label>
                        <asp:TextBox CssClass="form-control p-2 shadow" ID="txtMobileNumber" runat="server" TextMode="Phone" />

                        <asp:RequiredFieldValidator CssClass="" ID="RequiredFieldValidator5" ErrorMessage="Enter Mobile Number" ControlToValidate="txtMobileNumber" runat="server" Display="Dynamic" ForeColor="Red" />

                    </div>
                    <div class="col-6">
                        <label class="col-form-label">Solve it</label>
                        <div class="align-items-center row">
                            <div class="col-1"><asp:Label ID="lblNO1" runat="server" CssClass="col-form-label-lg" /></div>
                            <div class="col-1">+</div>
                            <div class="col-1"><asp:Label ID="lblNO2" runat="server" CssClass="col-form-label-lg" /></div>
                            <div class="col-1">=</div>
                            <div class="col-3"><asp:TextBox runat="server" ID="txtans" CssClass="form-control shadow" MaxLength="2" /></div>
                        </div>
                    </div>
                </div>
            </div>
            <%--<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" CssClass="alert-danger alert form-group" />--%>
            <div class="form-group">
                <asp:Button ID="Submit" runat="server" Text="Submit" CssClass="btn btn-success py-2 px-4 shadow" OnClick="Submit_Click" />
            </div>
            <div class="dropdown-divider"></div>
            <a class="dropdown-item col-form-lg-label" href="frm_LoginUser.aspx">Already User? Go login</a>
        </div>
    </div>

</asp:Content>


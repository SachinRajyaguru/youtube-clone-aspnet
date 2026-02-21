<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/mstFrm_admin.master" AutoEventWireup="true" CodeFile="frm_profilelist.aspx.cs" Inherits="Admin_frm_profilelist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="offset-2 col-lg-8 col-md-8 col-sm-8 col-xl-8 p-3 my-4" style="border-radius: 5px; background-color: rgba(125,125,125, 0.4);">
            <h2 class="h2">Users Profiles</h2>            
            <div class="form-group">
                <asp:GridView ID="gvProfile" runat="server" CssClass="table-bordered table" OnRowDeleting="gvProfile_RowDeleting">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>


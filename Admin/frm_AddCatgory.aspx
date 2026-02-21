<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/mstFrm_admin.master" AutoEventWireup="true" CodeFile="frm_AddCatgory.aspx.cs" Inherits="Admin_frm_AddCatgory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="offset-4 col-lg-4 col-md-4 col-sm-4 col-xl-4 p-3 my-4" style="border-radius: 5px; background-color: rgba(125,125,125, 0.4);">
            <h2 class="h2">Add Category</h2>
            <div class="form-group">
                <label class="col-form-label">Category Name</label>
                <asp:TextBox CssClass="form-control p-2 shadow" ID="txt_Category_Name" runat="server" />
            </div>
            <div class="form-group">
                <asp:Button ID="btn_Add_Category" runat="server" Text="Add Category" CssClass="btn btn-success py-2 px-4 shadow" OnClick="btn_Add_Category_Click" />
            </div>
            <div class="form-group">
                <asp:GridView ID="gvCategory" runat="server" CssClass="table-bordered table" OnRowDeleting="gvCategory_RowDeleting">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>


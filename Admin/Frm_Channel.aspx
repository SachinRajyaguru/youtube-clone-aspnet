<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/mstFrm_admin.master" AutoEventWireup="true" CodeFile="Frm_Channel.aspx.cs" Inherits="AdminSite_adFrm_Channel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="offset-2 col-lg-8 col-md-8 col-sm-8 col-xl-8 p-3 my-4" style="border-radius: 5px; background-color: rgba(125,125,125, 0.4);">
            <asp:GridView ID="dgchannel" runat="server" CssClass="table-bordered table" OnRowDeleting="dgchannel_RowDeleting">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>


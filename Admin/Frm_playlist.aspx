<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/mstFrm_admin.master" AutoEventWireup="true" CodeFile="Frm_playlist.aspx.cs" Inherits="AdminSite_Frm_playlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="offset-2 col-lg-8 col-md-8 col-sm-8 col-xl-8 p-3 my-4" style="border-radius: 5px; background-color: rgba(125,125,125, 0.4);">

            <asp:DropDownList ID="ddlChannelName" CssClass="dropdown form-control offset-4 col-4 offset-4 px-2 my-4" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlChannelName_SelectedIndexChanged">
            </asp:DropDownList>

            <asp:GridView ID="gvPlaylist" runat="server" OnRowDeleting="gvPlaylist_RowDeleting">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

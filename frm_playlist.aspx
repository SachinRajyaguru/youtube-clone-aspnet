<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="frm_playlist.aspx.cs" Inherits="frm_playlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="offset-4 col-lg-4 col-md-4 col-sm-4 col-xl-4 p-3 my-4" style="border-radius: 5px; background-color: rgba(125,125,125, 0.4);">
            <h2 class="h2">Playlist Manager</h2>
            <div class="form-group">
                <label class="col-form-label">Channel Name</label>
                <asp:DropDownList ID="ddlChannelName" runat="server" CssClass="form-control" AutoPostBack="True" />
            </div>
            <div class="form-group">
                <label class="col-form-label">Playlist Name</label>
                <asp:TextBox ID="txtAlbName" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <asp:Button ID="btnAddPlaylist" Text="Add playlist" runat="server" CssClass="btn-outline-success btn" OnClick="btnAddPlaylist_Click" />
            </div>
            <div class="form-group">
                <asp:GridView ID="dgplaylist" runat="server" CssClass="table-bordered table" OnRowDeleting="dgplaylist_RowDeleting">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowHeader="true" />
                    </Columns>
                </asp:GridView>
            </div>

        </div>
    </div>
</asp:Content>

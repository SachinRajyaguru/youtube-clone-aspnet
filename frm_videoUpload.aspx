<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="frm_videoUpload.aspx.cs" Inherits="frm_videoUpload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="offset-4 col-lg-4 col-md-4 col-sm-4 col-xl-4 p-3 my-4" style="border-radius: 5px; background-color: rgba(125,125,125, 0.4);">
            <h2 class="h2">Video Manager</h2>
            <div class="form-group">
                <label class="col-form-label">Select Channel</label>
                <asp:DropDownList ID="ddlChannelName" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlChannelName_SelectedIndexChanged" AutoPostBack="True" />
            </div>
            <div class="form-group">
                <label class="col-form-label">Select playlist</label>
                <asp:DropDownList ID="ddlplaylist" runat="server" CssClass="form-control" AutoPostBack="True" />
            </div>
            <div class="form-group">
                <label class="col-form-label">Video Name</label>
                <asp:TextBox ID="txtvideoname" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label class="col-form-label">Video Description</label>
                <asp:TextBox ID="txtVideoDecription" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="form-group">
                <label class="col-form-label">video image</label>
                <asp:FileUpload ID="fldVideoImage" runat="server" CssClass="form-control-plaintext form-control-lg" />
            </div>
            <div class="form-group">
                <label class="col-form-label">Select Video</label>
                <asp:FileUpload ID="fldvideo" runat="server" CssClass="form-control-plaintext form-control-lg" />
            </div>
            <div class="form-group">
                <asp:Button ID="btnvideo" Text="Add video" runat="server" CssClass="btn btn-primary" OnClick="btnvideo_Click" />
            </div>
        </div>
    </div>
</asp:Content>

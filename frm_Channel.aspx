<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="frm_Channel.aspx.cs" Inherits="addchennel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="row">
        <div class="offset-2 col-lg-8 col-md-8 col-sm-8 col-xl-8 p-3 my-4" style="border-radius: 5px; background-color: rgba(125,125,125, 0.4);">
            <h2 class="h2">Channel Manager</h2>
            <div class="form-group">
                <label class="col-form-label">Channel Name</label>
                <asp:TextBox ID="txt_channel_name" runat="server" CssClass="form-control shadow p-2" />
            </div>
            <div class="form-group ">
                <label class="col-form-label">Channel About</label>
                <asp:TextBox ID="txt_About" runat="server" CssClass="form-control shadow p-2" TextMode="MultiLine" />
            </div>

            <div class="row">
                <div class="col-6">
                    <div class="form-group">
                        <label class="col-form-label">Channel Image</label>
                        <asp:FileUpload ID="fld_ChannelImg" runat="server" />
                    </div>
                </div>
                <div class="col-6">
                    <div class="form-group ">
                        <label class="col-form-label">Channel Category</label>
                        <asp:DropDownList ID="ddl_Category" runat="server" CssClass="form-control shadow p-2">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="form-group ">
                <asp:Button ID="btnsavechannel" OnClick="btnsavechannel_Click" runat="server" Text="Submit" CssClass="btn btn-success py-2 px-4 shadow" />
            </div>
            <div class="form-group ">
                <asp:GridView ID="dgchannel" runat="server" CssClass="table table-bordered " CellPadding="0" GridLines="Vertical" OnRowDeleting="dgchannel_RowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="Image" ControlStyle-CssClass="img-thumbnail">
                            <ItemTemplate>
                                <a href="ch_Images/<%# Eval("ch_image") %>" target="_blank">
                                    <img src="ch_Images/<%# Eval("ch_image") %>" alt='<%# Eval("ch_image") %>' width="200px" />
                                </a>
                            </ItemTemplate>

                            <ControlStyle CssClass="img-thumbnail"></ControlStyle>
                        </asp:TemplateField>
                        <asp:CommandField ButtonType="Button" HeaderText="DELETE" ShowDeleteButton="True" ControlStyle-CssClass="btn-outline-primary btn" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>

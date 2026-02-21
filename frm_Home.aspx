<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frm_Home.aspx.cs" Inherits="frm_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <video controls="controls" poster="video_thumb/1.jpg" width="400px" class="modal-open">
        <source src="videos/1.mp4" controls="controls" type="video/mp4" /><a href="1.mp4" download>Download</a>  
    </video>
    <video controls="controls" poster="video_thumb/2.jpg" width="400px" class="p-3 m-2">
        <source src="videos/2.mp4" type="video/mp4">
    </video>    
</asp:Content>


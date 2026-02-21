using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_playlist : System.Web.UI.Page
{
    string QRY;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindChannelName();
            bindgrid();
        }

    }
    protected void btnAddPlaylist_Click(object sender, EventArgs e)
    {
        QRY = "INSERT INTO tbl_playlist ";
        QRY += "SELECT MAX(plylist_id)+1, ";
        QRY += "'" + txtAlbName.Text + "', ";
        QRY += "'" + ddlChannelName.SelectedValue.ToString() + "',";
        QRY += "'True' ";
        QRY += "FROM tbl_playlist";
        if (!helper.crud(QRY))
        {
            Response.Write("<script>alert('Some problem here');</script>");
            bindgrid();
        }
        txtAlbName.Text = string.Empty;
        bindgrid();

    }
    private void BindChannelName()
    {
        QRY = "SELECT ch_id,ch_name FROM tbl_channel WHERE is_act=1 AND yt_id = '" + Session["id"] + "'";
        ddlChannelName.DataSource = helper.BindDropDown(QRY);
        ddlChannelName.DataTextField = "Value";
        ddlChannelName.DataValueField = "Key";
        ddlChannelName.DataBind();
    }
    private void bindgrid()
    {
        QRY = "SELECT plylist_id,pl_name FROM tbl_playlist WHERE is_act='True' AND ch_id = '" + ddlChannelName.SelectedValue.ToString() + "'";
        dgplaylist.DataSource = helper.mybind(QRY);
        dgplaylist.DataBind();
    }
    protected void dgplaylist_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (helper.crud("DELETE FROM tbl_playlist WHERE plylist_id=" + dgplaylist.Rows[e.RowIndex].Cells[1].Text)) bindgrid();
    }
}
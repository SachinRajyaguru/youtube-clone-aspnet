using System;

public partial class AdminSite_Frm_playlist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlChannelDropDown();
            bindgrid();
        }
    }    
    protected void ddlChannelName_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindgrid();
    }
    protected void gvPlaylist_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
    {
        if (helper.crud("DELETE FROM tbl_playlist WHERE plylist_id=" + gvPlaylist.Rows[e.RowIndex].Cells[1].Text)) bindgrid();
    }
    private void bindgrid()
    {
        //condition ? ref consequence : ref alternative
        if (ddlChannelName.SelectedIndex > 0)
        {
            /*query = "SELECT * FROM tbl_playlist WHERE is_act=1 AND ch_id=";
            query = (ddlChannelName.SelectedIndex == 0) ? query += "-1" : query += ddlChannelName.SelectedValue;*/
            gvPlaylist.DataSource = helper.mybind("SELECT * FROM tbl_playlist WHERE is_act=1 AND ch_id=" + ddlChannelName.SelectedValue);
            gvPlaylist.DataBind();
        }
    }
    private void ddlChannelDropDown()
    {
        ddlChannelName.DataSource = helper.BindDropDown("SELECT ch_id,ch_name FROM tbl_channel WHERE is_act=1");
        ddlChannelName.DataTextField = "Value";
        ddlChannelName.DataValueField = "Key";
        ddlChannelName.DataBind();
        ddlChannelName.Items.Insert(0, "--SELECT--");
    }
}
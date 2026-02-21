using System;
using System.Web.UI.WebControls;

public partial class AdminSite_adFrm_Channel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindgrid();
        }
    }

    private void bindgrid()
    {
        dgchannel.DataSource = helper.mybind("SELECT * FROM tbl_channel WHERE is_act=1");
        dgchannel.DataBind();
    }
    protected void dgchannel_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (helper.crud("DELETE FROM tbl_channel WHERE ch_id=" + dgchannel.Rows[e.RowIndex].Cells[1].Text)) bindgrid();
    }
}
        
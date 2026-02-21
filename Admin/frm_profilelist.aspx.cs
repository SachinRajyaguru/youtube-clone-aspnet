using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_frm_profilelist : System.Web.UI.Page
{
    private string query;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindgrid();
        }
        query = string.Empty;
    }

    private void bindgrid()
    {
        gvProfile.DataSource = helper.mybind("SELECT *FROM tbl_YouTuber WHERE is_act=1");
        gvProfile.DataBind();
    }
    protected void gvProfile_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (helper.crud("DELETE FROM tbl_YouTuber WHERE yt_id=" + gvProfile.Rows[e.RowIndex].Cells[1].Text)) bindgrid();
    }
}
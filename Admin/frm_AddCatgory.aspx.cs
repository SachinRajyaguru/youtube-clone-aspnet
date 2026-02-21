using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_frm_AddCatgory : System.Web.UI.Page
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
    protected void btn_Add_Category_Click(object sender, EventArgs e)
    {
        query = string.Empty;
        query = "INSERT INTO tbl_Category ";
        query += "SELECT MAX(cat_id)+1,";
        query += "'"+txt_Category_Name.Text+"',";
        query += "1 FROM tbl_Category";
        if (!helper.crud(query))
        {
            Response.Write("<script>alert('Can't Add '"+txt_Category_Name.Text+");</script>");
        }
        bindgrid();
        txt_Category_Name.Text = string.Empty;
    }
    private void bindgrid()
    {
        gvCategory.DataSource = helper.mybind("SELECT *FROM tbl_Category WHERE is_act=1");
        gvCategory.DataBind();
    }
    protected void gvCategory_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (helper.crud("DELETE FROM tbl_Category WHERE cat_id=" + gvCategory.Rows[e.RowIndex].Cells[1].Text)) bindgrid();
    }
}
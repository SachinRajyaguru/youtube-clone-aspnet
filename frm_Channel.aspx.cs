using System;
using System.Data.SqlClient;
using System.IO;

public partial class addchennel : System.Web.UI.Page
{
    private string query;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null) Response.Redirect("frm_Login.aspx");
        if (!IsPostBack)
        {
            bindMyGrid();
            bindMyCat();
        }
    }
    private void bindMyCat()
    {
        ddl_Category.DataSource = helper.BindDropDown("SELECT cat_id,cat_name FROM tbl_Category WHERE is_act=1");
        ddl_Category.DataTextField = "Value";
        ddl_Category.DataValueField = "Key";
        ddl_Category.DataBind();
        ddl_Category.Items.Insert(0, "--SELECT--");
    }
    private void bindMyGrid()
    {
        query = "SELECT ch_id,ch_name,ch_image,ch_about FROM tbl_channel WHERE yt_id='" + Session["id"] + "' AND is_act='True'";
        dgchannel.DataSource = helper.mybind(query);
        dgchannel.DataBind();
    }
    protected void btnsavechannel_Click(object sender, EventArgs e)
    {
        if (fld_ChannelImg.HasFile)
        {
            query = "SELECT ch_id FROM tbl_channel WHERE ch_name='" + txt_channel_name.Text + "' AND is_act=1";
            using (SqlConnection connection = new SqlConnection(helper.conStr.ToString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        string myID = "0";
                        string ch_name = string.Empty;
                        string[] ch_names = fld_ChannelImg.FileName.ToString().Split('.');

                        myID = helper.getMaxID("ch_id", "tbl_channel");

                        ch_name = myID + "." + ch_names[ch_names.Length - 1].ToString();
                        fld_ChannelImg.SaveAs(Server.MapPath(@"/ch_Images/") + ch_name.ToString());

                        query = "INSERT INTO tbl_channel ";
                        query += "SELECT MAX(ch_id)+1 ,";
                        query += "'" + txt_channel_name.Text.Trim() + "',";
                        query += "'" + ch_name + "',";
                        query += "'" + txt_About.Text.Trim() + "',";
                        query += "'" + Session["id"] + "',";
                        if(ddl_Category.SelectedIndex > 0) 
                             query += "'" + ddl_Category.SelectedValue + "',";
                        else query += "'1',";
                        query += "1 ";
                        query += "FROM tbl_channel";

                        if (helper.crud(query)) Response.Write("<script>alert('Your Channel sussessfully added');</script>");
                        else Response.Write("<script>alert('channel no created');</script>");
                    }
                    else Response.Write("<script>alert('Channel is already exist');</script>");
                }
                connection.Close();
            }
        }
        else Response.Write("<script>alert('select channel image first');</script>");
        bindMyGrid();
    }
    protected void dgchannel_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
    {
        Response.Write(dgchannel.Rows[e.RowIndex].Cells[2].Text.ToString());
    }
}
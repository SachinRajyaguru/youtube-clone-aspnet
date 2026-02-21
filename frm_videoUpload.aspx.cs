using System;

public partial class frm_videoUpload : System.Web.UI.Page
{
    string QRY = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null) Response.Redirect("frm_login.aspx");
        if (!IsPostBack)
        { 
            BindChannelName();
        }
    }
    private void BindChannelName()
    {
        QRY = "SELECT ch_id,ch_name FROM tbl_channel WHERE yt_id = '" + Session["id"] + "' AND is_act=1";
        ddlChannelName.DataSource = helper.BindDropDown(QRY);
        ddlChannelName.DataTextField = "Value";
        ddlChannelName.DataValueField = "Key";
        ddlChannelName.DataBind();
        ddlChannelName.Items.Insert(0, "--SELECT--"); 
    }
    private void DataBindplylistName()
    {
        QRY = "SELECT plylist_id,pl_name FROM tbl_playlist WHERE ch_id = '" + ddlChannelName.SelectedValue + "' AND is_act=1";
        ddlplaylist.DataSource = helper.BindDropDown(QRY);
        ddlplaylist.DataTextField = "Value";
        ddlplaylist.DataValueField = "Key";
        ddlplaylist.DataBind();
        ddlplaylist.Items.Insert(0, "--SELECT--"); 
    }
    protected void ddlChannelName_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataBindplylistName();
    }
    protected void btnvideo_Click(object sender, EventArgs e)
    {
        //save image for video
        
        string[] arrVdoThumb = fldVideoImage.FileName.ToString().Split('.');
        string[] arrVideoName = fldvideo.FileName.ToString().Split('.');

        string myimgID = helper.getMaxID("vdo_id", "tbl_video");

        string thb = myimgID + "." + arrVdoThumb[arrVdoThumb.Length - 1].ToString();
        string videoName = myimgID + "." + arrVideoName[arrVideoName.Length - 1].ToString();

        fldVideoImage.SaveAs(Server.MapPath(@"/video_thumb/") + thb);
        fldvideo.SaveAs(Server.MapPath(@"/videos/") + videoName);

        QRY = "INSERT INTO tbl_video ";
        QRY += "SELECT MAX(vdo_id)+1 ,";
        QRY += "'" + videoName + "',";
        QRY += "'" + thb + "',";
        QRY += "'" + DateTime.Now.ToShortDateString()+ "',";
        QRY += "'" + txtVideoDecription.Text.Trim() + "',";
        QRY += "'" + ddlplaylist.SelectedValue + "',";
        QRY += "'True' ";
        QRY += "FROM tbl_video";

        Response.Write(QRY);
        /*if (!helper.crud(QRY))
            Response.Write("<script>alert('" + QRY.ToString() + "');</script>");            */
    }
}
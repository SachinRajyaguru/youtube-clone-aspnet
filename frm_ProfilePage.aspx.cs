using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_ProfilePage : System.Web.UI.Page
{
    private string QRY;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null) Response.Redirect("frm_Login.aspx");
        if (!IsPostBack) getProfile();
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        txtUser.Enabled = !txtUser.Enabled;
        txtEmail.Enabled = !txtEmail.Enabled;
        txtMobile.Enabled = !txtMobile.Enabled;
        txtPassword.Enabled = !txtPassword.Enabled;

        txtUser.ReadOnly = !txtUser.ReadOnly;
        txtEmail.ReadOnly = !txtEmail.ReadOnly;
        txtMobile.ReadOnly = !txtMobile.ReadOnly;
        txtPassword.ReadOnly = !txtPassword.ReadOnly;

        
        btnEdit.Enabled = btnUpdate.Enabled;
        btnUpdate.Enabled = !btnEdit.Enabled;
    }
    private void getProfile()
    {
        if (Session["id"] != null)
        {
            QRY = "SELECT * FROM tbl_Youtuber WHERE yt_id ='" + Session["id"].ToString() + "'";
            try
            {
                using (var connection = new System.Data.SqlClient.SqlConnection(helper.conStr.ToString()))
                {
                    var command = new System.Data.SqlClient.SqlCommand(QRY, connection);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtUser.Text = reader.GetValue(1).ToString();
                            txtEmail.Text = reader.GetValue(2).ToString();
                            txtPassword.Text = reader.GetValue(3).ToString();
                            txtMobile.Text = reader.GetValue(4).ToString();
                        }
                        else
                        {
                            Response.Write("<script>alert('Seesion closed');</script>");
                            Response.Write("<script>alert('Relogin');</script>");
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Response.Write("ErrorCode: " + ex.ErrorCode);
                Response.Write("<br>line: " + ex.LineNumber);
            }
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        
        if (Session["id"] != null)
        {
            QRY = "UPDATE tbl_Youtuber SET ";
            QRY += "Name = '" + txtUser.Text + "',";
            QRY += "Email_ID = '" + txtEmail.Text + "',";
            QRY += "Password='" + txtPassword.Text + "',";
            QRY += "Mnumber = '" + txtMobile.Text + "' ";
            QRY += "WHERE yt_id ='" + Session["id"].ToString() + "' ";
            QRY += "AND ";
            QRY += "is_act = 'True' ";
            if (helper.crud(QRY))
            {
                Response.Write("<script>alert('Profile Updated');</script>");
            }
            else
            {
                Response.Write("<script>alert('Some Thing Error');</script>");
            }
        }
        btnUpdate.Enabled = !btnUpdate.Enabled;
        btnEdit.Enabled = !btnEdit.Enabled;
    }
    protected void txtPassword_TextChanged(object sender, EventArgs e)
    {

    }
}

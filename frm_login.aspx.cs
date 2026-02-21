using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_login : System.Web.UI.Page
{
    private string query;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        LoginUser();
    }
    protected void LoginUser()
    {
        try
        {
            query = "SELECT yt_id FROM tbl_Youtuber WHERE ";
            query += "Email_ID = '" + txt_Email.Text + "' AND Password = '" + txt_password.Text + "' AND is_act = 'True'";

            SqlConnection connection = new SqlConnection(helper.conStr);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Session["id"] = reader.GetValue(0).ToString();
                Response.Redirect("frm_Home.aspx");
            }
            else lblmsg.InnerHtml = "Invalid Email or Password";
        }
        catch (SqlException ex)
        {
            Response.Write("<div class='alert alert-danger' role='alert'>ErrorCode: " + ex.Errors + "<br>line: " + ex.LineNumber + "</div>");
        }
    }
}
using System;
public partial class frm_registration : System.Web.UI.Page
{
    private string query;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Random rndm = new Random();
            lblNO1.Text = rndm.Next(1, 9).ToString();
            lblNO2.Text = rndm.Next(1, 9).ToString();
        }
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        if (txtans.Text.Length == 0)
        {
            Response.Write("<script>alert('Plaese Fill The Right Answer');</script>");
            txtans.Focus();
        }
        else if (txtans.Text.Length > 0 && int.Parse(txtans.Text) == (int.Parse(lblNO1.Text) + int.Parse(lblNO2.Text)))
        {
            insertUser();
            clearTextBox();
        }
        else
        {
            Response.Write("<script>alert('Plaese Fill The Right Answer');</script>");
            txtans.Focus();
        }
    }

    private void clearTextBox()
    {
        txtans.Text = string.Empty;
        txtEmail.Text = string.Empty;
        txtFirstName.Text = string.Empty;
        txtLastName.Text = string.Empty;
        txtMobileNumber.Text = string.Empty;
        txtPassword.Text = string.Empty;
    }
    protected void insertUser()
    {
        query = "INSERT INTO tbl_Youtuber ";
        query += "SELECT MAX(yt_id)+1 ,";
        query += "'" + txtFirstName.Text + " " + txtLastName.Text + "', ";
        query += "'" + txtEmail.Text + "', ";
        query += "'" + txtPassword.Text + "', ";
        query += "'" + txtMobileNumber.Text + "', ";
        query += "'True' ";
        query += "FROM tbl_Youtuber";
        if (!helper.crud(query))
        {
            Response.Write("<script>confirm('User can't Register please try again');</script>");
        }
    }
}
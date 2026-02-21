using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_frm_ad_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtEmail.Text) || !string.IsNullOrEmpty(txtpwd.Text))
        {
            if (txtEmail.Text.Equals("admin") && txtpwd.Text.Equals("admin"))
            {
                Response.Redirect("Frm_Channel.aspx");
            }
        }
        else
            Response.Write("Fill Text boxes");
    }
}
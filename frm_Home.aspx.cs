using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_Home : System.Web.UI.Page
{
    void Page_PreInit(Object sender, EventArgs e)
    {
        if (Session["id"] == null)
        {
            Page.MasterPageFile = "~/MasterPage.master";
        }
        else
        {
            Page.MasterPageFile = "~/User.master";
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null) Response.Redirect("frm_Login.aspx");
    }
}
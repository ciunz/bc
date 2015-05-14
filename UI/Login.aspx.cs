using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Convert.ToString(Session["username"]);
            if(username != null )
            {
                //Response.Redirect("home.aspx");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = usr.Value;
            string pwd = pwds.Value;
            UserBAL bal = new UserBAL();
            Response.Write("<script>alert('Wrong Username Or Password')</script>");

            if (bal.CekLogin(username, pwd))
            {
                int lvl = bal.getLevel(username);
                Session["username"] = username;
                Session["lvl"] = lvl;
                Response.Redirect("home.aspx");
            }
            else
            {
                Label1.Visible = true;
                Response.Write("<script>alert('Wrong Username Or Password')</script>");
            }
        }
    }
}
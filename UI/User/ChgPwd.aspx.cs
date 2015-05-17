using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace UI
{
    public partial class ChgPwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null || Session["lvl"] == null)
            { Response.Redirect("/home.aspx"); }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string uid = Request.QueryString["uid"];
            string newPass = newP.Value;
            string rePass = reP.Value;
            string oldPass = oldP.Value;
            UserBAL bal = new UserBAL();
            MsUserBAL ubal = new MsUserBAL();
            ubal = bal.GetUserById(uid);
            if (oldPass == ubal.pwd)
            {
                if (newPass == rePass)
                {
                    ubal.pwd = newPass;
                    bal.UpdateUser(ubal);
                }
                else
                {
                    Label1.Visible = true;
                }
            }
            else
            {
                Label2.Visible = true;
            }
        }
    }
}
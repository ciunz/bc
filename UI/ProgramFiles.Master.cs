using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace UI
{
    public partial class ProgramFiles : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null || Session["lvl"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            else
            {
                int lvl = 1;//Convert.ToInt32(Session["lvl"]);
                TopLinksDAL d = new TopLinksDAL();
                List<TopLink> tl = new List<TopLink>();
                tl = d.GetLink(lvl);
                menuAtas.InnerHtml = "<li></li>";
                menuMobile.InnerHtml = "<li></li>";
                int panjang = tl.Count; int count = 1;
                foreach (TopLink a in tl)
                {
                    menuAtas.InnerHtml += "<li><a href='" + a.links + "'>" + a.name + "</a></li>";
                    if (count != panjang) { menuAtas.InnerHtml += "|"; }
                    menuMobile.InnerHtml += "<li class='nav-item'><a href='" + a.links + "'>" + a.name + "</a></li>";
                    count++;
                }

                //if (Session["lvl"] == null)
                //{
                //    menuAtas.InnerHtml = "<li>&nbsp;</li>";
                //    menuMobile.InnerHtml = "<li>&nbsp;</li>";
                //}

                //else 
                //{

                //}
            }
            
            
        }
    }
}
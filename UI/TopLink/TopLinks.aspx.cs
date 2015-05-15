using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace UI
{
    public partial class TopLinks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TopLinksDAL top = new TopLinksDAL();
            List<TopLink> tl = new List<TopLink>();
            tl = top.GetLinkList();
            string contents = "";
            foreach(TopLink t in tl)
            {
                contents += "<div>";
				contents +=	"<span><label>Nama</label></span>";
				contents +=	"<span><input type='text' class='textbox' value='"+ t.name +"' /></span>";
                contents += "</div><div>";
                contents += "<span><label>Link Address</label></span>";
                contents += "<span><input type='text' class='textbox' value='" + t.links + "' /></span>";
                contents += "</div><div>";
                contents += "<span><label>Level</label></span>";
                contents += "<span><input type='text' class='textbox' value='" + t.level + "' /></span>";
                contents += "</div><div>";
                contents += "<span><label>Status</label></span>";
                contents += "<span><input type='text' class='textbox' value='" + t.status + "' /></span>";
                contents += "</div><div>";
                contents += "<a href='AddTopLink.aspx?type=u&id=" + Convert.ToString(t.idLink) + "'>Update</a>";
				contents +=	"</div>";
            }
            isi.InnerHtml = contents;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddTopLink.aspx?type=i");
        }
    }
}
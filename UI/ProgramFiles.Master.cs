using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BAL;

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
                if(Session["order"]==null)
                {
                    cart.InnerHtml="<li><h3>shopping cart empty</h3></li>";
					cart.InnerHtml+="<li><p>To Shop, Click Program at the Menu</p></li>";
                    total.InnerText = "0MB";
                }
                else
                {
                    cart.InnerHtml = "<li><h3>Your Cart</h3></li>";
                    List<string> order = new List<string>();
                    order = (List<string>)Session["order"];
                    int totalSize = 0;
                    foreach (string o in order)
                    {
                        ProgramBAL bal = new ProgramBAL();
                        MsProgramBAL probal = new MsProgramBAL();
                        probal = bal.getProgramById(o);
                        cart.InnerHtml += "<li><p>"+ probal.title + " "+ probal.size + " MB" +"</p></li>";
                        totalSize += probal.size;
                        cart.InnerHtml += "<li><h3>Total : " + totalSize + " MB</h3></li>";
                    }
                    total.InnerText = totalSize + "MB";
                    cart.InnerHtml += "<input type='submit' value='Cek Out' id='cekOut'>";
                }
                
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
            }
            
            
        }
    }
}
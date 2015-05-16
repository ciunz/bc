using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace UI
{
    public partial class details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];       
            //User Autentifikasi 
            if (id != null)
            {
                ProgramBAL probal = new ProgramBAL();
                MsProgramBAL b = new MsProgramBAL();
                b = probal.getProgramById(id);
                Session["produk"] = b;  
                string title = b.title;
                Label1.Text = "<h3>" + title + "</h3>";
                keterangan.InnerText = b.descr;
                ukuran.InnerText = b.size + " MB";
                gambar.Src = "/"+b.img;
                gambar.Alt = title;
                descr.InnerHtml += b.descr;
                rating.InnerHtml += b.rating;
            }
            else
            {
                Response.Redirect("AllProgram.aspx");
            }           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            ProgramBAL probal = new ProgramBAL();
            MsProgramBAL b = new MsProgramBAL();
            b = probal.getProgramById(id);

            List<string> order = new List<string>();
            if (Session["order"] != null)
            {
                order = (List<string>)Session["order"];
            }           
            order.Add(b.idProgram);
            Session["order"] = order;

            Response.Redirect("AllProgram.aspx");
        }
    }
}
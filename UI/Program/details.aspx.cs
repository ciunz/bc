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
            SingleProgramBAL b = new SingleProgramBAL(id);
            Session["produk"] = b;
            //User Autentifikasi 
            if (id != null)
            {            
                string title = b.getTitle(id);
                Label1.Text = "<h3>" + title + "</h3>";
                keterangan.InnerText = b.getDesc(id);
                ukuran.InnerText = b.getSize(id) + " MB";
                gambar.Src = "/" + b.getPic(id);
                gambar.Alt = title;
            }
            else
            {
                //Redirect
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            MsProgramBAL b = new MsProgramBAL();          
            b = (MsProgramBAL) Session["produk"];

            MsPenjualanBAL penj = new MsPenjualanBAL();
            penj = (MsPenjualanBAL)Session["order"];
            penj.detail += b.idProgram+";";
            Session["order"] = penj;
        }
    }
}
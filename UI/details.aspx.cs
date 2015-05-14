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

            //User Autentifikasi 

            string id = Request.QueryString["id"];

            if (id != null)
            {
                SingleProgramBAL b = new SingleProgramBAL(id);
                string title = b.getTitle(id);
                Label1.Text = "<h3>" + title + "</h3>";
                keterangan.InnerText = b.getDesc(id);
                ukuran.InnerText = b.getSize(id) + " MB";
                gambar.Src = b.getPic(id);
                gambar.Alt = title;
            }
            else
            {
                //Redirect
            }
            
        }
    }
}
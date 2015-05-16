using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace UI
{
    public partial class CekOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["order"] != null)
            {
                List<string> order = new List<string>();
                order = (List<string>)Session["order"];
                int totalSize = 0;
                cekout.InnerHtml += "<table>";
                foreach (string o in order)
                {
                    ProgramBAL bal = new ProgramBAL();
                    MsProgramBAL probal = new MsProgramBAL();
                    probal = bal.getProgramById(o);
                    cekout.InnerHtml += "<tr>";
                    cekout.InnerHtml += "<td>" + probal.title + "</td>";
                    cekout.InnerHtml += "<td>" + probal.size + "</td>";
                    cekout.InnerHtml += "</tr>";
                    totalSize += probal.size;
                }
                cekout.InnerHtml += "</table>";
                cekout.InnerHtml += "<h1> Total : " + totalSize + "</h1>";
                //cekout.InnerHtml += "<a class='tombol' href='/CekOut.aspx' >Cek Out</a>";
            }
            else
            {
                Response.Redirect("/home.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MsUserBAL ubal = new MsUserBAL();
            UserBAL user = new UserBAL();
            PenjualanBAL pbal = new PenjualanBAL();
            MsPenjualanBAL jual = new MsPenjualanBAL();
            ubal = user.getUserByUsername(Convert.ToString(Session["username"]));
            jual.idCustomer = ubal.idCustomer;
            //jual.detail = (List<string>) Session["order"];
            foreach (string det in (List<string>)Session["order"])
            {
                jual.detail += det + ";";
            }
            jual.idPenjualan = pbal.GetNextId().ToString();
            jual.tglTrans = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                pbal.AddPenjualan(jual);
                Response.Write("<script>alert('berhasil')</script>");
                Session["order"] = null;
                cekout.InnerHtml = "";
                Response.Redirect("/home.aspx");
            }
            catch
            {
                Response.Write("<script>alert('gagal')</script>");
            }
        }
    }
}
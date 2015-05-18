using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace UI
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int perPage = 10;
            int pa = 0;
            if (Request.QueryString["page"] != null || Request.QueryString["page"] != "")
            { pa = perPage * Convert.ToInt32(Request.QueryString["page"]); }
                               
            PenjualanBAL pbal = new PenjualanBAL();
            List<MsPenjualanBAL> lb = new List<MsPenjualanBAL>();
            lb = pbal.GetPenjualanList();
            tbJual.InnerHtml += "<table border='1' style='width:100%; font-family:Source Sans Pro, sans-serif;'>";
            tbJual.InnerHtml += "<tr><td>Tanggal</td><td>Nama</td><td>Judul</td><td>Size</td></tr>";
            foreach (MsPenjualanBAL mp in lb.Skip(pa).Take(perPage))
            {
                string[] result = mp.detail.Split(new char[] { ';' });
                UserBAL ub = new UserBAL();

                foreach (string s in result)
                {
                    if (s == null || s == "")
                    { break; }
                    ProgramBAL pb = new ProgramBAL();
                    MsProgramBAL probal = new MsProgramBAL();
                    probal = pb.getProgramById(s);
                    tbJual.InnerHtml += "<tr>";
                    tbJual.InnerHtml += "<td>" + mp.tglTrans.Substring(0, 10) + "</td>";
                    tbJual.InnerHtml += "<td>" + ub.GetUserById(mp.idCustomer).nama + "</td>";
                    tbJual.InnerHtml += "<td>" + probal.title + "</td>";
                    tbJual.InnerHtml += "<td>" + probal.size + " MB</td>";
                    tbJual.InnerHtml += "</tr>";
                }
            }
            tbJual.InnerHtml += "</table>";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace UI
{
    public partial class AllProgram : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {          
            ProgramBAL bal = new ProgramBAL();
            List<MsProgramBAL> lb = new List<MsProgramBAL>();
            lb = bal.GetProgramList();
            int counter = 0;
            if (lb != null)
            {
                string isi = "<div class='grids_of_3'>";
                foreach (MsProgramBAL probal in lb)
                {
                    //cetak
                    isi += "<div class='grid1_of_3'>";
                    isi += "<a href='details.aspx?id=" + probal.idProgram + "'>";
                    isi += "<img src='" + probal.img + "' alt=''/>";
                    isi += "<h3>" + probal.title + "</h3>";
                    isi += "<div class='price'>";
                    isi += "<h4>" + probal.size + "MB <span>Buy</span></h4>";
                    isi += "</div>";
                    isi += "<span class='b_btm'></span>";
                    isi += "</a>";
                    isi += "</div>";
                    counter++;
                    if (counter % 3 == 0 && counter != 0 && lb.Count() != counter)
                    {
                        isi += "</div>" + "<div class='clear'></div>" + "<div class='grids_of_3'>";
                    }
                }

                isi += "</div>";
                isi += "<div class='clear'></div>";

                pro.InnerHtml = isi;
            }
            else
            {
                pro.InnerHtml = "<h2>Data Not Found</h2>";
            }
           
        }
    }
}
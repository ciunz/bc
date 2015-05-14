using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace UI
{
    public partial class AllUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserBAL bal = new UserBAL();

            List<MsUserBAL> lb = new List<MsUserBAL>();
            lb = bal.GetUserList();
            int counter = 0;
            if (lb != null)
            {
                string isi = "<div class='grids_of_3'>";
                foreach (MsUserBAL ub in lb)
                {
                    //cetak
                    isi += "<div class='grid1_of_3'>";
                    isi += "<a href='details.aspx?id=" + ub.idCustomer + "'>";
                    isi += "<img src='" + ub.img + "' alt=''/>";
                    isi += "<h3>" + ub.nama + "</h3>";
                    isi += "<div class='price'>";
                    isi += "<h4>" + ub.username + " <span>Buy</span></h4>";
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
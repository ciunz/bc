using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace UI
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProgramBAL bal = new ProgramBAL(); int counter = 1;
            string texthtml = "<div class='grids_of_3'>";
            foreach (MsProgramBAL b in bal.GetProgramList())
            {
                texthtml += "<div class='grid1_of_3'>";
                texthtml += "<a href='/Program/details.aspx?id=" + b.idProgram + "'>";
                texthtml += "<img src='/images/" + b.img + "' alt=''/>";
                texthtml += "<h3>"+b.title+"</h3>";
                if (Session["username"] != null || Session["lvl"] != null)
                { texthtml += "<div class='price'><h4>" + b.descr + "</h4></div>"; }
                texthtml += "<div class='price'><h4>" + b.date.Substring(0,10) + "</h4></div>";
                texthtml += "<div class='price'><h4>Rating : " + b.rating + "</h4></div>";
                texthtml += "<div class='price'><h4>"+ b.size +"MB<span>BUY</span></h4></div>";
                texthtml += "<span class='b_btm'></span></a></div>";               
                if (counter % 3 == 0 && counter != 0)
                { texthtml += "</div><div class='clear'></div><div class='grids_of_3'>"; }
                counter++;
            }
            texthtml += "</div><div class='clear'></div>";
            pr.InnerHtml = texthtml;

            //pagination
        }
    }
}
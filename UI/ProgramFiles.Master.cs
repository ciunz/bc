﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace UI
{
    public partial class ProgramFiles : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int lvl = Convert.ToInt32(Session["lvl"]);
            TopLinksDAL d = new TopLinksDAL();
            List<TopLink> tl = new List<TopLink>();
            tl = d.GetLink(lvl);

            menuAtas.InnerHtml = "";
            menuMobile.InnerHtml = "";

            if (Session["lvl"] == null)
            {
                menuAtas.InnerHtml = "<li>&nbsp;</li>";
                menuMobile.InnerHtml = "<li>&nbsp;</li>";
            }

            else 
            {
                foreach (TopLink a in tl)
                {
                    menuAtas.InnerHtml += "<li><a href='" + a.links + "'>" + a.name + "</a></li> |";
                    menuMobile.InnerHtml += "<li class='nav-item'><a href='" + a.links + "'>" + a.name + "</a></li>";
                }
            }
            
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BAL
{
    public class MsProgramBAL
    {
        public string idProgram
        { get; set; }
        public string title
        { get; set; }
        public string descr
        { get; set; }
        public int size
        { get; set; }
        public int rating
        { get; set; }
        public string img
        { get; set; }
        public string date
        { get; set; }
        public string technology
        { get; set; }


        public MsProgramBAL ConvertToMsProgramBAL(MsProgram pro)
        {
            MsProgramBAL baru = new MsProgramBAL()
            {
                idProgram = pro.idProgram,
                title = pro.title,
                descr = pro.descr,
                size = pro.size,
                rating = Convert.ToInt32(pro.rating),
                img = pro.img,
                date = pro.date.ToString(),
                technology = pro.technology
            };
            return baru;
        }

        public MsProgram ConvertToMsProgram(MsProgramBAL pro)
        {
            MsProgram baru = new MsProgram()
            {
                idProgram = pro.idProgram,
                title = pro.title,
                descr = pro.descr,
                size = pro.size,
                rating = Convert.ToInt32(pro.rating),
                img = pro.img,
                date = Convert.ToDateTime(pro.date),
                technology = pro.technology
            };
            return baru;
        }

    }
}

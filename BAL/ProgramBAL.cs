﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BAL
{
    public class ProgramBAL
    {

        public bool AddProgram(MsProgramBAL pro)
        {
            ProgramDAL dal = new ProgramDAL();
            return dal.AddProgram(pro.ConvertToMsProgram(pro));
        }

        public bool DeleteProgram(string id)
        {
            ProgramDAL dal = new ProgramDAL();
            return dal.DeleteProgram(id);
        }

        public bool UpdateProgram(MsProgramBAL probal)
        {
            ProgramDAL dal = new ProgramDAL();
            return dal.UpdateProgram(probal.ConvertToMsProgram(probal));
        }

        public List<MsProgramBAL> GetProgramList()
        {
            ProgramDAL dal = new ProgramDAL();
            List<MsProgramBAL> liste = new List<MsProgramBAL>();
            foreach (MsProgram pro in dal.GetProgramList())
            {
                MsProgramBAL baru = new MsProgramBAL();
                liste.Add(baru.ConvertToMsProgramBAL(pro));
            }

            return liste;
        }

        public string getLastId()
        {
            ProgramDAL dal = new ProgramDAL();
            return dal.getLastID();
        }

        public MsProgramBAL getProgramById(string id)
        {
            ProgramDAL dal = new ProgramDAL();
            MsProgram pro = new MsProgram();
            MsProgramBAL probal = new MsProgramBAL();
            pro = dal.GetProgramById(id);
            probal = probal.ConvertToMsProgramBAL(pro);
            return probal;
        }

    }
}

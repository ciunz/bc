using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class PenjualanDAL
    {

        public bool AddPenjualan(MsPenjualan baru)
        {
            dbDataContext db = new dbDataContext();
            
            db.MsPenjualans.InsertOnSubmit(baru);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<MsPenjualan> GetPenjualanList()
        {
            dbDataContext db = new dbDataContext();

            var hasil = from baris in db.MsPenjualans
                        select baris;

            return hasil.ToList();
        }

        public MsPenjualan GetPenjualanById(string id)
        {
            dbDataContext db = new dbDataContext();

            var hasil = (from baris in db.MsPenjualans
                         where baris.idPenjualan == id
                         select baris).SingleOrDefault();

            return hasil;
        }


        public bool UpdatePenjualan(MsPenjualan p)
        {
            dbDataContext db = new dbDataContext();

            var hasil = (from baris in db.MsPenjualans
                         where baris.idPenjualan == p.idPenjualan
                         select baris).SingleOrDefault();
            if (hasil != null)
            {
                hasil.idPenjualan = p.idPenjualan;
                hasil.idCustomer = p.idCustomer;
                hasil.idProgram = p.idProgram;
                hasil.tglTrans = p.tglTrans;
                hasil.qty = p.qty;
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }


        public bool DeletePenjualan(string id)
        {
            dbDataContext db = new dbDataContext();
            var hapus = (from baris in db.MsPenjualans
                         where baris.idPenjualan == id
                         select baris).SingleOrDefault();

            if (hapus != null)
            {
                db.MsPenjualans.DeleteOnSubmit(hapus);
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BAL
{
    public class MsPenjualanBAL
    {
        public string idPenjualan
        { get; set; }
        public string idCustomer
        { get; set; }
        public string idProgram
        { get; set; }
        public string tglTrans
        { get; set; }
        public int qty
        { get; set; }


        public MsPenjualan ConvertToMsPenjualan(MsPenjualanBAL b)
        { 
            MsPenjualan jual = new MsPenjualan();
            jual.idPenjualan = b.idPenjualan;
            jual.idCustomer = b.idCustomer;
            jual.idProgram = b.idProgram;
            jual.tglTrans = Convert.ToDateTime(b.tglTrans);
            jual.qty = b.qty;

            return jual;
        }

        public MsPenjualanBAL ConvertToMsPenjualanBAL(MsPenjualan jual)
        {
            MsPenjualanBAL b = new MsPenjualanBAL();
            
            b.idPenjualan = jual.idPenjualan;
            b.idCustomer = jual.idCustomer;
            b.idProgram = jual.idProgram;
            b.tglTrans = Convert.ToString(jual.tglTrans);
            b.qty = jual.qty;

            return b;
        }


    }
}

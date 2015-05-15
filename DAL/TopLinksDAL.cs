using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class TopLinksDAL 
    {
        public List<TopLink> GetLink(int level)
        {
            dbDataContext db = new dbDataContext();
            
            //TopLink top = new TopLink();

            var hasil = from baris in db.TopLinks
                        //where baris.status <= level
                        select baris;
            
            return hasil.ToList();
        }

        public List<TopLink> GetLinkList()
        {
            dbDataContext db = new dbDataContext();

            //TopLink top = new TopLink();

            var hasil = from baris in db.TopLinks
  
                        select baris;

            return hasil.ToList();
        }
        
        public TopLink GetSingleLink(string url)
        {
            dbDataContext db = new dbDataContext();

            //TopLink top = new TopLink();

            var hasil = (from baris in db.TopLinks
                         where baris.links == url
                        select baris).SingleOrDefault();

            return hasil;
        }





        public bool AddLink(TopLink top)
        {
            dbDataContext db = new dbDataContext();

            db.TopLinks.InsertOnSubmit(top);
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

        public bool DeleteLink(string name)
        {
            dbDataContext db = new dbDataContext();

            var hapus = (from baris in db.TopLinks
                         where baris.name == name
                         select baris).SingleOrDefault();
            db.TopLinks.DeleteOnSubmit(hapus);

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

        public bool UpdateLink(TopLink top)
        {
            dbDataContext db = new dbDataContext();
            var update = (from baris in db.TopLinks
                          where baris.name == top.name
                          select baris).SingleOrDefault();

            if (update != null)
            {
                update.name = top.name;
                update.links = top.links;
                update.status = top.status;
                update.level = top.level;

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

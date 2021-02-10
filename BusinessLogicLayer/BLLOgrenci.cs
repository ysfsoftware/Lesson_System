using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer1;
using EntityLayer1;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if(p.AD==null && p.SOYAD==null && p.NUMARA==null && p.SİFRE==null && p.FOTO == null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
    }
}

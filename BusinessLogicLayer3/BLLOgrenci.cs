using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer3;
using DataAccessLayer3;

namespace BusinessLogicLayer3
{
  public  class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.SİFRE != null && p.FOTOGRAF != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public  static List<EntityOgrenci> BLLListele()
        {
            return DALOgrenci.OgrenciListesi();
        }
        public static bool OgrenciSilBll(int p2)
        {
            if (p2 >=0)
            {
                return DALOgrenci.OgrenciSil(p2);
            }
            return false;
        }
        public static List<EntityOgrenci> BLLDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }
        
        public static bool OgrenciGuncelleBll(EntityOgrenci p)
        {
            if (p.AD != null && p.AD!="" && p.SOYAD != null && p.SOYAD!="" && p.NUMARA != null && p.NUMARA!="" && p.SİFRE != null && p.SİFRE!="" && p.FOTOGRAF != null && p.ID>0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer3;
using DataAccessLayer3;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer3
{
     public class BLLDers
    {
        public static List<EntityDers> BLLListele()
        {
            return DALDers.DersListesi();
        }
        public static int TalepEkleBLL(EntityBasvuru p)
        {
            if (p.BSVROGRID != null && p.BSVRDERSID!=null)
            {
                return DALDers.TalepEkle(p);

            }
            return -1;
        }
    }
}

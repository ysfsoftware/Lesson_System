using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer1;
using EntityLayer1;

namespace DataAccessLayer1
{
  public  class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand cmd = new SqlCommand("insert into TabloOgrenci (OgrAd,OgrSoyad,OgrNumara,OgrFoto,OgrSifre) values (@p1,@p2,@p3,@p4,@p5)", Connection.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", parametre.AD);
            cmd.Parameters.AddWithValue("@p2", parametre.SOYAD);
            cmd.Parameters.AddWithValue("@p3", parametre.NUMARA);
            cmd.Parameters.AddWithValue("@p4", parametre.FOTO);
            cmd.Parameters.AddWithValue("@p5", parametre.SİFRE);
            return cmd.ExecuteNonQuery();

        }
    }
}

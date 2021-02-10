using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer3;

namespace DataAccessLayer3
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand cmd2 = new SqlCommand("Select * from TabloDers", Connection.bgl);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.ID = Convert.ToInt32(dr["DersID"].ToString());
                ent.DERSAD = dr["DersAd"].ToString();
                ent.MİN = int.Parse( dr["DersMinKontenjan"].ToString());
                ent.MAX = int.Parse(dr["DersMaxKontenjan"].ToString());
                
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuru parametre)
        {
            SqlCommand cmd3 = new SqlCommand("insert into TabloBasvuru (OgrID,DersID) values (@p1,@p2)", Connection.bgl);
            cmd3.Parameters.AddWithValue("@p1", parametre.BSVROGRID);
            cmd3.Parameters.AddWithValue("@p2", parametre.BSVRDERSID);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            return cmd3.ExecuteNonQuery();

        }
    }
}

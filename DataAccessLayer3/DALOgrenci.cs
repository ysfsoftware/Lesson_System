using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer3;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer3
{
    public class DALOgrenci
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
            cmd.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            cmd.Parameters.AddWithValue("@p5", parametre.SİFRE);
            return cmd.ExecuteNonQuery();

        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand cmd2 = new SqlCommand("Select * from TabloOgrenci",Connection.bgl);
            if(cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(dr["OgrID"].ToString());
                ent.AD = dr["OgrAd"].ToString();
                ent.SOYAD = dr["OgrSoyad"].ToString();
                ent.NUMARA = dr["OgrNumara"].ToString();
                ent.FOTOGRAF = dr["OgrFoto"].ToString();
                ent.SİFRE = dr["OgrSifre"].ToString();
                ent.BAKİYE = Convert.ToDouble(dr["OgrBakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciSil(int parametre2)
        {
            SqlCommand cmd3 = new SqlCommand("Delete  from TabloOgrenci where OGRID=@p1 ", Connection.bgl);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@p1", parametre2);
            return cmd3.ExecuteNonQuery()>0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand cmd4 = new SqlCommand("Select * from TabloOgrenci where OGRID=@p1", Connection.bgl);
            cmd4.Parameters.AddWithValue("@p1", id);
            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            SqlDataReader dr = cmd4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(dr["OgrID"].ToString());
                ent.AD = dr["OgrAd"].ToString();
                ent.SOYAD = dr["OgrSoyad"].ToString();
                ent.NUMARA = dr["OgrNumara"].ToString();
                ent.FOTOGRAF = dr["OgrFoto"].ToString();
                ent.SİFRE = dr["OgrSifre"].ToString();
                ent.BAKİYE = Convert.ToDouble(dr["OgrBakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand cmd5 = new SqlCommand("Update TabloOgrenci set OgrAd=@p1,OgrSoyad=@p2,OgrNumara=@p3,OgrFoto=@p4,OgrSifre=@p5 where OgrID=@p6",Connection.bgl);
            if (cmd5.Connection.State != ConnectionState.Open)
            {
                cmd5.Connection.Open();
            }
            cmd5.Parameters.AddWithValue("@p1", deger.AD);
            cmd5.Parameters.AddWithValue("@p2", deger.SOYAD);
            cmd5.Parameters.AddWithValue("@p3", deger.NUMARA);
            cmd5.Parameters.AddWithValue("@p4", deger.FOTOGRAF);
            cmd5.Parameters.AddWithValue("@p5", deger.SİFRE);            
            cmd5.Parameters.AddWithValue("@p6", deger.ID);
            return cmd5.ExecuteNonQuery() > 0;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer3;
using EntityLayer3;
using BusinessLogicLayer3;



namespace YazOkuluDers
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
            EntityOgrenci ent = new EntityOgrenci();
            ent.AD = TextBox1.Text;
            ent.SOYAD = TextBox2.Text;
            ent.NUMARA = TextBox3.Text;
            ent.SİFRE = TextBox4.Text;
            ent.FOTOGRAF = TextBox5.Text;

            BLLOgrenci.OgrenciEkleBLL(ent);
            Response.Write("<script> alert('Öğrenci Ekleme Başarıyla Gerçekleşmiştir.') </script>");
        }
    }
}
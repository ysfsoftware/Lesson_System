using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer3;
using BusinessLogicLayer3;
using DataAccessLayer3;

namespace YazOkuluDers
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            TextBox0.Text = x.ToString();
            TextBox0.Enabled = false;

            if (Page.IsPostBack == false)
            {

            
            List<EntityOgrenci> OgrList = BLLOgrenci.BLLDetay(x);
            TextBox1.Text = OgrList[0].AD.ToString();
            TextBox2.Text = OgrList[0].SOYAD.ToString();
            TextBox3.Text = OgrList[0].NUMARA.ToString();
            TextBox5.Text = OgrList[0].FOTOGRAF.ToString();
            TextBox4.Text = OgrList[0].SİFRE.ToString();
            
        }
        }
     

        protected void Button1_Click1(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.AD = TextBox1.Text;
            ent.SOYAD = TextBox2.Text; 
            ent.NUMARA = TextBox3.Text;
            ent.FOTOGRAF = TextBox4.Text;
            ent.SİFRE = TextBox5.Text;
            ent.ID = Convert.ToInt32(TextBox0.Text);
            BLLOgrenci.OgrenciGuncelleBll(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using EntityLayer3;
using DataAccessLayer3;
using BusinessLogicLayer3;

namespace YazOkuluDers
{
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> ogrlist = BLLOgrenci.BLLListele();
            Repeater1.DataSource = ogrlist;
            Repeater1.DataBind();
        }
    }
}
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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

            
            List<EntityDers> ent = BLLDers.BLLListele();
            DropdownList1.DataSource = BLLDers.BLLListele();
            DropdownList1.DataTextField = "DersAd";
            DropdownList1.DataValueField = "ID";
            DropdownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuru ent = new EntityBasvuru();
            ent.BSVROGRID = int.Parse(TextBox1.Text);
            ent.BSVRDERSID = int.Parse(DropdownList1.SelectedValue.ToString());
            BLLDers.TalepEkleBLL(ent);
        }
    }
}
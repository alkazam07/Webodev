using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayerr;
using DataAccessLayer;
using BusinessLogicLayer;


namespace yazokulukatmanlı
{
    public partial class Dersler1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDers> DersList = BLLDers.BllListele();
            Repeater1.DataSource = DersList;
            Repeater1.DataBind();
        }
    }
}
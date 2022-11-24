using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectComplaint.User
{
    public partial class Home : System.Web.UI.Page
    {
        BAL.ProductBAL obj = new BAL.ProductBAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = obj.viewProduct();
                GridView1.DataBind();
            }
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectComplaint.Admin
{
    public partial class ViewQuery : System.Web.UI.Page
    {
        BAL.QueryBAL obj = new BAL.QueryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = obj.viewQuery();
                GridView1.DataBind();
            }
        }       
    }
}
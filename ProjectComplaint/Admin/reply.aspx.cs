using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectComplaint.Admin
{
    public partial class reply : System.Web.UI.Page
    {
        BAL.QueryBAL obj = new BAL.QueryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            obj.Qid = Convert.ToInt32(Request.QueryString["ID"]);
            obj.Replay = TextBox1.Text;
            int i=obj.giveReplay();
            if (i == 1)
            {
                Response.Write("<script>alert('Replied')</script>");
                Response.Redirect("ViewQuery.aspx");
            }
        }
    }
}
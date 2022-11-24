using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectComplaint.User
{
    public partial class Query : System.Web.UI.Page
    {
        BAL.QueryBAL objque = new BAL.QueryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            objque.Lid = Convert.ToInt32(Session["lid"]);
            if (!IsPostBack)
            {
                GridView1.DataSource = objque.viewUserQuery();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            objque.Pid = int.Parse(DropDownList1.SelectedItem.Value);
            objque.Desc = TextBox1.Text;
            objque.Lid = Convert.ToInt32(Session["lid"]);

            int i = objque.queryInsert();

            if (i == 1)
            {
                Response.Write("<script>alert('Query Submitted Successfully')</script>");
                GridView1.DataSource = objque.viewUserQuery();
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Error Submitting Query')</script>");

            }
        }

       
    }
}
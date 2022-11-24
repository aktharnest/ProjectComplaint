using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectComplaint.Guest
{
    public partial class UserReg : System.Web.UI.Page
    {
        BAL.ComplaintBAL objreg = new BAL.ComplaintBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objreg.Name = TextBox1.Text;
            objreg.email = TextBox2.Text;
            objreg.phone = TextBox3.Text;
            objreg.username = TextBox4.Text;
            objreg.password = TextBox5.Text;

            int i= objreg.userInsert();
            
            if (i == 1)
            {
                Response.Write("<script>alert('Success')</script>");
                Response.Redirect("/Guest/Home.aspx");
            }
            else
            {
                Response.Write("<script>alert('Failed')</script>");
            }
        }
    }
}
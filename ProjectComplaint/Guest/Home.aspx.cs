using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectComplaint.Guest
{
    
    public partial class Home : System.Web.UI.Page
    {
        BAL.ComplaintBAL objlog = new BAL.ComplaintBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objlog.username = TextBox1.Text;
            objlog.password = TextBox2.Text;

            if(TextBox1.Text.Equals("admin") && TextBox2.Text.Equals("admin"))
            {
                Response.Write("<script>alert('Welcome Admin')</script>");
                Response.Redirect("/Admin/Product.aspx");
            }
            DataTable dt = objlog.checklogin();
            if (dt.Rows.Count>0)
            {
                string status = Convert.ToString(dt.Rows[0][3]);
                
                if (status.Equals("Confirmed") ){
                    Session["lid"] = dt.Rows[0][0];
                    Response.Write("<script>alert('Login Successfull')</script>");
                    Response.Redirect("/User/Home.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Not Confirmed')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Username or Password')</script>");
            }
           
        }
    }
}
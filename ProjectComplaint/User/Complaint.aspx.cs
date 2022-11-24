using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectComplaint.User
{
    
    public partial class Complaint : System.Web.UI.Page
    {
        BAL.ComplaintBoxBAL objcom = new BAL.ComplaintBoxBAL();


        protected void Page_Load(object sender, EventArgs e)
        {
            objcom.Lid = Convert.ToInt32(Session["lid"]);
            if (!IsPostBack)
            {
                GridView1.DataSource = objcom.viewUserComplaints();
                GridView1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objcom.Pid = int.Parse(DropDownList1.SelectedItem.Value);
            objcom.Desc = TextBox1.Text;
            objcom.Lid = Convert.ToInt32(Session["lid"]);

            int i = objcom.compInsert();

            if (i == 1)
            {
                Response.Write("<script>alert('Complaint Submitted Successfully')</script>");
                Response.Redirect("Complaint.aspx");

            }
            else
            {
                Response.Write("<script>alert('Error Submitting Complaint')</script>");

            }
        }
    }
}
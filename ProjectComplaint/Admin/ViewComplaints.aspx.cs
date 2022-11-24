using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectComplaint.Admin
{
    public partial class ViewComplaints : System.Web.UI.Page
    {
        BAL.ComplaintBoxBAL objcom = new BAL.ComplaintBoxBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objcom.viewComplaint();
                GridView1.DataBind();
                GridView2.DataSource = objcom.viewPending();
                GridView2.DataBind();
                GridView3.DataSource = objcom.viewCompleted();
                GridView3.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objcom.Cid = id;
            int i = objcom.complaintConfirm();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objcom.viewComplaint();
            GridView1.DataBind();
            GridView2.DataSource = objcom.viewPending();
            GridView2.DataBind();
            GridView3.DataSource = objcom.viewCompleted();
            GridView3.DataBind();
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            objcom.Cid = id;
            int i = objcom.complaintComplete();
            GridView2.EditIndex = -1;
            GridView1.DataSource = objcom.viewComplaint();
            GridView1.DataBind();
            GridView2.DataSource = objcom.viewPending();
            GridView2.DataBind();
            GridView3.DataSource = objcom.viewCompleted();
            GridView3.DataBind();
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    objcom.From = TextBox1.Text;
        //    objcom.To = TextBox2.Text;
        //    GridView1.DataSource = objcom.viewDateComplaint();
        //    GridView1.DataBind();
        //}
    }
}
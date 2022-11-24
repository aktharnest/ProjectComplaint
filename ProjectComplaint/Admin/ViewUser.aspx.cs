using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectComplaint.Admin
{
    public partial class ViewUser : System.Web.UI.Page
    {
        BAL.ComplaintBAL obj = new BAL.ComplaintBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = obj.viewUser();
                GridView1.DataBind();
                GridView2.DataSource = obj.viewUserDetails();
                GridView2.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            obj.Lid = id.ToString();
            int i = obj.User_confirm();
            GridView1.EditIndex = -1;
            GridView1.DataSource = obj.viewUser();
            GridView1.DataBind();
            GridView2.DataSource = obj.viewUserDetails();
            GridView2.DataBind();
        }

        
    }
}
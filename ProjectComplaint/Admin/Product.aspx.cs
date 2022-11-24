using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectComplaint.Admin
{
    public partial class Product : System.Web.UI.Page
    {
        BAL.ProductBAL objpro = new BAL.ProductBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objpro.viewProduct();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objpro.Name = TextBox1.Text;

            int i = objpro.productInsert();

            if (i == 1)
            {
                Response.Write("<script>alert('Product Added Successfully')</script>");
                Response.Redirect("Product.aspx");
            }
            else
            {
                Response.Write("<script>alert('Failed')</script>");

            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex; //set edit index
            GridView1.DataSource = objpro.viewProduct(); //taking val from tbl
            GridView1.DataBind();//bind to gridview
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1; //set edit index
            GridView1.DataSource = objpro.viewProduct(); //taking val from tbl
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txt = new TextBox();
            txt = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            objpro.ID = id;
            objpro.Name = txt.Text;
            int i = objpro.updateProduct();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objpro.viewProduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objpro.ID = Id;
            int i = objpro.deleteProduct();
            GridView1.DataSource = objpro.viewProduct();
            GridView1.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectComplaint.DAL
{
    public class ProductDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public ProductDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["complaint"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }

        public SqlConnection GetCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int ProductInsert(BAL.ProductBAL obj)
        {
            string qry = "insert into Product values('" + obj.Name + "')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
            
        }
        public DataTable ViewProduct()
        {
            string s = "select * from Product";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ProductEdit(BAL.ProductBAL obj)
        {
            string qry = "update Product set pname= '" + obj.Name + "'where pId='" + obj.ID + "'";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public int DeleteProduct(BAL.ProductBAL obj)
        {
            string qry = "Delete from Product where pId = '" + obj.ID + "'";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectComplaint.DAL
{
    public class ComplaintBOXDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public ComplaintBOXDAL()
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
        public int CompInsert(BAL.ComplaintBoxBAL obj)
        {
            string qry = "insert into ComplaintBox values('" + obj.Pid + "','" + obj.Lid + "','" + obj.Desc + "',GETDATE(),'NotVerified')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable ViewComplaint()
        {
            string s = "SELECT Login.username,Product.pname, ComplaintBox.cId,ComplaintBox.complaint,ComplaintBox.cur_date FROM Product CROSS JOIN Login INNER JOIN ComplaintBox ON Product.pId = ComplaintBox.pid AND Login.LId = ComplaintBox.lid Where ComplaintBox.Status='NotVerified'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //public DataTable ViewDateComplaint(BAL.ComplaintBoxBAL obj)
        //{
        //    string s = "SELECT Login.username,Product.pname, ComplaintBox.cId,ComplaintBox.complaint,ComplaintBox.cur_date FROM Product CROSS JOIN Login INNER JOIN ComplaintBox ON Product.pId = ComplaintBox.pid AND Login.LId = ComplaintBox.lid Where ComplaintBox.Status='NotVerified' BETWEEN '"+obj.From+"' and '"+obj.To+"'";
        //    SqlCommand cmd = new SqlCommand(s, GetCon());
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}
        public DataTable ViewPending()
        {
            string s = "SELECT Login.username,Product.pname, ComplaintBox.cId,ComplaintBox.complaint,ComplaintBox.cur_date FROM Product CROSS JOIN Login INNER JOIN ComplaintBox ON Product.pId = ComplaintBox.pid AND Login.LId = ComplaintBox.lid Where ComplaintBox.Status='Pending'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ViewUserComplaints(BAL.ComplaintBoxBAL obj)
        {
            string s = "SELECT DISTINCT Product.pname, ComplaintBox.cId,ComplaintBox.complaint,ComplaintBox.Status FROM Product CROSS JOIN Login INNER JOIN ComplaintBox ON Product.pId = ComplaintBox.pid AND ComplaintBox.LId='"+obj.Lid+"'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ViewCompleted()
        {
            string s = "SELECT Login.username,Product.pname, ComplaintBox.complaint,ComplaintBox.cur_date FROM Product CROSS JOIN Login INNER JOIN ComplaintBox ON Product.pId = ComplaintBox.pid AND Login.LId = ComplaintBox.lid Where ComplaintBox.Status='Completed'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ComplaintConfirm(BAL.ComplaintBoxBAL obj)
        {
            string s = "update ComplaintBox set Status = 'Pending' where cId = '" + obj.Cid + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public int ComplaintComplete(BAL.ComplaintBoxBAL obj)
        {
            string s = "update ComplaintBox set Status = 'Completed' where cId = '" + obj.Cid + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }
    }
}
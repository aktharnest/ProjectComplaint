using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectComplaint.DAL
{
    public class QueryDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public QueryDAL()
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
        public int QueryInsert(BAL.QueryBAL obj)
        {
            string qry = "insert into Query values('" + obj.Pid + "','" + obj.Lid + "','" + obj.Desc + "',GETDATE(),'Not Replied')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable ViewQuery()
        {
            string s = "SELECT Login.username,Product.pname, Query.query,Query.cur_date,Query.qId FROM Product CROSS JOIN Login INNER JOIN Query ON Product.pId = Query.pid AND Login.LId = Query.lid WHERE Replay='Not Replied'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ViewUserQuery(BAL.QueryBAL obj)
        {
            string s = "SELECT DISTINCT Product.pname, Query.qId, Query.query,Query.Replay FROM Product CROSS JOIN Login INNER JOIN Query ON Product.pId = Query.pid AND Query.LId='" + obj.Lid + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int GiveReplay(BAL.QueryBAL obj)
        {
            string s = "UPDATE Query SET Replay='"+obj.Replay+"' WHERE qId='"+obj.Qid+"'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }
    }
}

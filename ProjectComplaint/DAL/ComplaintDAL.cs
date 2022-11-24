using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectComplaint.DAL
{
    public class ComplaintDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public ComplaintDAL()
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
        public int UserInsert(BAL.ComplaintBAL obj)
        {
            string qry = "insert into UserReg values('" + obj.Name + "','" + obj.email + "','Not Confirmed','" + obj.phone + "','" + obj.username + "')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            cmd.ExecuteNonQuery();
            qry = "insert into Login values('" + obj.username + "','" + obj.password + "','Not Confirmed')";
            cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable ViewUser()
        {
            string s = "select * from Login where Status = 'Not Confirmed'";
            SqlCommand cmd = new SqlCommand(s,GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ViewUserDetails()
        {
            string s = "select * from UserReg ";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int user_confirm(BAL.ComplaintBAL obj)
        {
            string s = "update Login set Status = 'Confirmed' where Lid = '"+obj.Lid+"'";
            string q = "UPDATE UserReg SET Status='Confirmed' FROM Login,UserReg WHERE Login.Lid='" + obj.Lid + "' AND Login.username=UserReg.Username";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(q, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable CheckLogin(BAL.ComplaintBAL obj)
        {
            string s = "SELECT * FROM Login WHERE username='"+obj.username+"' AND password='"+obj.password+"'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        
    }
}
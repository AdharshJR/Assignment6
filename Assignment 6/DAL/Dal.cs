using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Assignment_6.DAL
{
    public class Dal
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Dal()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection GetCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public DataTable Getdeprt(BAL.Bal obj)
        {
            string s = "SELECT * FROM dept";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int InsertDesig(BAL.Bal obj)
        {
          
            string qry = "insert into des values('" + obj.Desgination + "','" + obj.DepId + "')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public int Insertdept(BAL.Bal obj)
        {

            string qry = "insert into dept values('" + obj.Deptname + "')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable desigview(BAL.Bal obj)
        {
            string s = "select * from des td inner join Dept dt on td.des_id=dt.dept_id";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public int desgUpdate(BAL.Bal obj)
        {
            string s = "update des set des_name='" + obj.Desgination + "' where des_id='" + obj.DesgId + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public int Deletedesig(BAL.Bal obj)
        {
            string s = "delete from des where des_id='" + obj.DesgId + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }
    }
}
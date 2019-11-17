using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CN_Business
{
    public class LoginService
    {
        public MySqlConnection Connection;
        MySqlDataAdapter adapter;
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cinema_simd;  uid=root; pwd=;convert zero datetime=True");
        string query;
        public static string LoginServices(String Name, String Password)
        {
            MySqlDataAdapter adapter;
            MySqlCommand cmd;
            DBConnection DBCon;
            DataTable dt;
            string sql;
            int i = 0;

            DBCon = new DBConnection();
            sql = string.Format(@"select*from User where Name='" + Name + "' and Password='" + Password + "'");
            dt = new DataTable();
            DBCon.ConnectionOpen();
            cmd = new MySqlCommand(sql, DBCon.Connection);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            string result = (i == 1) ? "Login Success" : "Error";
            return result;
        }
        public string get_isemployee(string result, string name)
        {
            DataSet datasetprice = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT isemployee from user where name= '" + name + "'");
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(datasetprice);
                conn.Close();
                result = datasetprice.Tables[0].Rows[0]["isemployee"].ToString();
                return result;
            }

            conn.Close();
            return null;
        }

    }
}

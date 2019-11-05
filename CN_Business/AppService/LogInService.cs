using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CN_Business
{
    public class LoginService
    {
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
        

    }
}

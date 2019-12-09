using MySql.Data.MySqlClient;
using System.Data;


namespace CN_Business
{
    public class DBConnection
    {
        public MySqlConnection Connection;
        string constring = "server=localhost;port=3307; database=cinema_simd;  uid=root; pwd=;convert zero datetime=True";
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3307; database=cinema_simd;  uid=root; pwd=;convert zero datetime=True");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;


        public void ConnectionOpen()
        {
            Connection = new MySqlConnection(constring);
            Connection.Open();
        }
        public void ConnectionClose()
        {
            Connection = new MySqlConnection(constring);
            Connection.Close();
        }

        public bool query_command(string query)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }

            conn.Close();
            return false;
        }

        public DataTable table_get_data(string query)
        {
            DataTable tab = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(tab);
                conn.Close();
                return tab;
            }

            conn.Close();
            return null;
        }

    }
}

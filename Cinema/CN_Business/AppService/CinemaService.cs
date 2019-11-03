using MySql.Data.MySqlClient;
using System.Data;

namespace CN_Business
{
   public class CinemaService
    {
        public MySqlConnection Connection;
        MySqlDataAdapter adapter;
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cinema_simd;  uid=root; pwd=;convert zero datetime=True");
        string query;

        public DataSet get_movies_data(DataSet ds)
        {
            DataSet DS = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT movie_name from movies");
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(DS);
                conn.Close();
                return DS;
            }

            conn.Close();
            return null;
        }

        public DataSet get_cinemas_data(DataSet ds, string Movie_Names)
        {
            DataSet DS = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT cinema_name from cinemas where movie_name= '" + Movie_Names + "'");
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(DS);
                conn.Close();
                return DS;
            }

            conn.Close();
            return null;
        }

        public DataSet get_dates_data(DataSet ds,string Cinema_Name)
        {
            DataSet DS = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT date from cinemas where movie_name= '" + Cinema_Name + "'");
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(DS);
                conn.Close();
                return DS;
            }

            conn.Close();
            return null;
        }
    }
}

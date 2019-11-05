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
            DataSet DataSetMovie = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT movie_name from movies");
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(DataSetMovie);
                conn.Close();
                return DataSetMovie;
            }

            conn.Close();
            return null;
        }

        public DataSet get_duration_data(DataSet ds, string movie_name)
        {
            DataSet DataSetDuration = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT duration from movies where movie_name= '" + movie_name + "'");
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(DataSetDuration);
                conn.Close();
                return DataSetDuration;
            }

            conn.Close();
            return null;
        }

        public DataSet get_cinemas_data(DataSet dataset, string Movie_Names)
        {
            DataSet DataSetCinema = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT cinema_name from cinemas where movie_name= '" + Movie_Names + "'");
                adapter = new MySqlDataAdapter(query, conn);
                DataSetCinema.Clear();
                adapter.Fill(DataSetCinema);
                conn.Close();
                return DataSetCinema;
            }
            conn.Close();
            return null;
        }

        public DataSet get_dates_data(DataSet dataset,string Cinema_Name,string Movie_Name)
        {
            DataSet DSDate = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT date from cinemas where cinema_name= '" + Cinema_Name + "'and movie_name='" + Movie_Name +"'");
                adapter = new MySqlDataAdapter(query, conn);
                DSDate.Clear();
                adapter.Fill(DSDate);
                conn.Close();
                return DSDate;
            }

            conn.Close();
            return null;
        }

        public DataSet get_times_data(DataSet dataset, string Cinema_Name, string Movie_Name,string date)
        {
            DataSet DSTimes = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT time from cinemas where cinema_name= '" + Cinema_Name + "'and movie_name='" + Movie_Name + "'and date='" + date + "'");
                adapter = new MySqlDataAdapter(query, conn);
                DSTimes.Clear();
                adapter.Fill(DSTimes);
                conn.Close();
                return DSTimes;
            }

            conn.Close();
            return null;
        }

        public DataSet get_theater_data(DataSet dataset, string Cinema_Name, string Movie_Name, string date,string time)
        {
            DataSet DStheather = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT theather from cinemas where cinema_name= '" + Cinema_Name + "'and movie_name='" + Movie_Name + "'and date='" + date + "'and time='" + time + "'");
                adapter = new MySqlDataAdapter(query, conn);
                DStheather.Clear();
                adapter.Fill(DStheather);
                conn.Close();
                return DStheather;
            }

            conn.Close();
            return null;
        }

        public DataSet get_class_data(DataSet dataset, string Cinema_Name, string Movie_Name, string date, string time, string theather)
        {
            DataSet DSClass = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT class from cinemas where cinema_name= '" + Cinema_Name + "'and movie_name='" + Movie_Name + "'and date='" + date + "'and time='" + time + "'and theather='" + theather + "'");
                adapter = new MySqlDataAdapter(query, conn);
                DSClass.Clear();
                adapter.Fill(DSClass);
                conn.Close();
                return DSClass;
            }

            conn.Close();
            return null;
        }
    }
}

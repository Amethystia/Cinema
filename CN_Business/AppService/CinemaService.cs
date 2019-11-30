using MySql.Data.MySqlClient;
using System.Data;
using System;
using CN_Modeling;

namespace CN_Business
{
   public class CinemaService
    {
        public MySqlConnection Connection;
        DBConnection DBCon;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cinema_simd;  uid=root; pwd=;convert zero datetime=True");
        string query;

        public DataSet get_cinemas_data(DataSet dataset)
        {
            DataSet DataSetCinema = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT cinema_name from cinemas ");
                adapter = new MySqlDataAdapter(query, conn);
                DataSetCinema.Clear();
                adapter.Fill(DataSetCinema);
                conn.Close();
                return DataSetCinema;
            }
            conn.Close();
            return null;
        }
        public DataTable get_ALLMovies(DataTable dataTable)
        {
            DataTable DataTableCinema = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select * from movies ");
                adapter = new MySqlDataAdapter(query, conn);
                DataTableCinema.Clear();
                adapter.Fill(DataTableCinema);
                conn.Close();
                return DataTableCinema;
            }
            conn.Close();
            return null;
        }
        public DataSet get_movies_data(DataSet ds, string cinema_name)
        {
            DataSet DataSetMovie = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT movie_name from cinemas where cinema_name= '"+ cinema_name + "'");
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(DataSetMovie);
                conn.Close();
                return DataSetMovie;
            }

            conn.Close();
            return null;
        }

        public DataSet get_class_data(DataSet ds, string cinema_name)
        {
            DataSet datasetclass = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT class from cinemas where cinema_name= '" + cinema_name + "'");
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(datasetclass);
                conn.Close();
                return datasetclass;
            }

            conn.Close();
            return null;
        }

        public string get_price_data(string result, string classes,string Daycode)
        {
            DataSet datasetprice = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT price from ticket where type= '" + classes + "'and DayCode='" + Daycode + "'");
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(datasetprice);
                conn.Close();
                result = datasetprice.Tables[0].Rows[0]["price"].ToString();
                return result;
            }

            conn.Close();
            return null;
        }
        public DataSet get_moviedetail_data(DataSet ds, string movie_name)
        {
            DataSet DataSetMovie = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT cinema_name from cinemas where movie_name= '" + movie_name + "'");
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
        public DataSet get_times_data(DataSet dataset, string Cinema_Name, string Movie_Name)
        {
            DataSet DSTimes = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT time from cinemas where cinema_name= '" + Cinema_Name + "'and movie_name='" + Movie_Name + "'");
                adapter = new MySqlDataAdapter(query, conn);
                DSTimes.Clear();
                adapter.Fill(DSTimes);
                conn.Close();
                return DSTimes;
            }

            conn.Close();
            return null;
        }
        public DataSet get_theater_data(DataSet dataset, string Cinema_Name, string Movie_Name, string time)
        {
            DataSet DStheather = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT theather from cinemas where cinema_name= '" + Cinema_Name + "'and movie_name='" + Movie_Name + "'and time='" + time + "'");
                adapter = new MySqlDataAdapter(query, conn);
                DStheather.Clear();
                adapter.Fill(DStheather);
                conn.Close();
                return DStheather;
            }

            conn.Close();
            return null;
        }
        public DataSet get_class_data(DataSet dataset, string Cinema_Name, string Movie_Name, string time, string theather)
        {
            DataSet DSClass = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT class from cinemas where cinema_name= '" + Cinema_Name + "'and movie_name='" + Movie_Name + "'and time='" + time + "'and theather='" + theather + "'");
                adapter = new MySqlDataAdapter(query, conn);
                DSClass.Clear();
                adapter.Fill(DSClass);
                conn.Close();
                return DSClass;
            }
            conn.Close();
            return null;
        }
        public DataSet get_cinemaid_data(DataSet dataset, string Cinema_Name, string Movie_Name,  string time, string theather)
        {
            DataSet DSClass = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT cinema_id from cinemas where cinema_name= '" + Cinema_Name + "'and movie_name='" + Movie_Name +  "'and time='" + time + "'and theather='" + theather + "'");
                adapter = new MySqlDataAdapter(query, conn);
                DSClass.Clear();
                adapter.Fill(DSClass);
                conn.Close();
                return DSClass;
            }
            conn.Close();
            return null;
        }

        public DataSet get_slide_data(DataSet dataset)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT slide_image,movie_name from movies where isreleased=0 and slide_image is not null");
                adapter = new MySqlDataAdapter(query, conn);
                dataset.Clear();
                adapter.Fill(dataset);
                conn.Close();
                return dataset;
            }
            conn.Close();
            return null;
        }

        public DataSet get_promo_slide_data(DataSet dataset)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT picture_url,name from promotion");
                adapter = new MySqlDataAdapter(query, conn);
                dataset.Clear();
                adapter.Fill(dataset);
                conn.Close();
                return dataset;
            }
            conn.Close();
            return null;
        }
        public DataSet get_release_data(DataSet dataset)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select movie_name,movie_image from movies where  isreleased=0 and release_date <= '" + DateTime.Today.ToString("yyyy-MM-dd") + "' order by(release_date)");
                adapter = new MySqlDataAdapter(query, conn);
                dataset.Clear();
                adapter.Fill(dataset);
                conn.Close();
                return dataset;
            }
            conn.Close();
            return null;
        }
        public DataTable get_seats_data(DataTable dataTable, string theather)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select seats from theather where theather_name = '" + theather + "'");
                adapter = new MySqlDataAdapter(query, conn);
                dataTable.Clear();
                adapter.Fill(dataTable);
                conn.Close();
                return dataTable;
            }
            conn.Close();
            return null;
        }
        public DataTable get_booked_data(DataTable dataTable, string theather, string cinema_name, string movie_name, string time)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select seat_number from bookedtickets where theather = '" + theather + "'and cinema_name='" + cinema_name + "'and movie_name='" + movie_name + "'and time='" + time + "'");
                adapter = new MySqlDataAdapter(query, conn);
                dataTable.Clear();
                adapter.Fill(dataTable);
                conn.Close();
                return dataTable;
            }
            conn.Close();
            return null;
        }
        public DataTable get_bookedtickets_data(DataTable dataTable,string username)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select `cinema_name`,`theather`,`movie_name`,`time`,`seat_number`,`price` from bookedtickets  where book_by = '"+username+"'");
                adapter = new MySqlDataAdapter(query, conn);
                dataTable.Clear();
                adapter.Fill(dataTable);
                conn.Close();
                return dataTable;
            }
            conn.Close();
            return null;
        }
        public DataTable get_bookingcinema_data(DataTable dataTable,string username)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select `requeststatus`,`cinema_name`,`theather`,`movie_name`,`class`,`date`,`price` from bookingcinema where book_by = '" + username + "'order by `date`,`requeststatus` desc");
                adapter = new MySqlDataAdapter(query, conn);
                dataTable.Clear();
                adapter.Fill(dataTable);
                conn.Close();
                return dataTable;
            }
            conn.Close();
            return null;
        }

        [Obsolete]
        public bool Insert(Movie_Model movie_model)
        {
            bool result = false;
            //{
            //    DBCon = new DBConnection();
            //    query = string.Format(@"INSERT INTO `movies`(`movie_name`,`movie_imdb`,`movie_description`,`slide_image`,`movie_image`,`Duration`,`Release_Date`,`isReleased`)
            //                                VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');",movie_model.MovieName,movie_model.MovieIMDB,movie_model.MovieDescription,movie_model.SlideImage,movie_model.MovieImage,movie_model.Duration,movie_model.ReleasedDate,movie_model.IsReleased);
            //    DBCon.ConnectionOpen();
            //    cmd = new MySqlCommand(query, DBCon.Connection);
            //    cmd.BeginExecuteNonQuery();
            //    DBCon.ConnectionClose();
            //}
            //catch (Exception ex) { Console.WriteLine(ex); }
            //return result;
            query = "INSERT INTO `movies`(`movie_name`,`movie_imdb`,`movie_description`,`slide_image`,`movie_image`,`Duration`,`Release_Date`,`isReleased`)" +
                                    "VALUES(@movie_name,@movie_imdb,@movie_description,@slide_image,@movie_image,@Duration,@Release_Date,@isReleased)";
                                   
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.Add("@movie_name", movie_model.MovieName);
                cmd.Parameters.Add("@movie_imdb", movie_model.MovieIMDB);
                cmd.Parameters.Add("@movie_description", movie_model.MovieDescription);
                cmd.Parameters.Add("@slide_image", movie_model.SlideImage);
                cmd.Parameters.Add("@movie_image", movie_model.MovieImage);
                cmd.Parameters.Add("@Duration", movie_model.Duration);
                cmd.Parameters.Add("@Release_Date", movie_model.ReleasedDate);
                cmd.Parameters.Add("@isReleased", movie_model.IsReleased);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return result;
                }
            }
        }
    }
}

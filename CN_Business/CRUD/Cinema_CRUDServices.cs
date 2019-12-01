using System;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using CN_Modeling;

namespace CN_Business
{
    public class Cinema_CRUD_Service
    {
        public MySqlConnection Connection;
        DBConnection DBCon;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cinema_simd;  uid=root; pwd=;convert zero datetime=True");
        string query;
        public DataTable get_AllCinemas(DataTable dataTable)
        {
            DataTable DataTableCinema = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select * from cinemas ");
                adapter = new MySqlDataAdapter(query, conn);
                DataTableCinema.Clear();
                adapter.Fill(DataTableCinema);
                conn.Close();
                return DataTableCinema;
            }
            conn.Close();
            return null;
        }

        [Obsolete]
        public bool Insert(Cinema_Model cinema_Model)
        {
            bool result = false;
            query = "INSERT INTO `cinemas`(`cinema_name`,`movie_name`,`theather`,`time`,`class`)" +
                                    "VALUES(@cinema_name,@movie_name,@theather,@time,@class)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.Add("@cinema_name", cinema_Model.Cinema_Name);
                cmd.Parameters.Add("@movie_name", cinema_Model.Movie_name);
                cmd.Parameters.Add("@theather", cinema_Model.Theather);
                cmd.Parameters.Add("@time", cinema_Model.Time);
                cmd.Parameters.Add("@class", cinema_Model.Class);
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

        public bool GetDeleteByID(string cinemaid)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                query = string.Format(@"DELETE
                                    FROM `cinemas`
                                    WHERE `cinema_id` = '{0}';", cinemaid);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(query, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            return result;
        }


        public bool Update(Cinema_Model cinema_Model)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                query = string.Format(@"UPDATE `cinemas`
                                        SET 
                                            `cinema_name` = '{0}',
                                            `movie_name` = '{1}',
                                            `theather` = '{2}',
                                            `time` = '{3}',
                                            `class` = '{4}'
                                        WHERE `cinema_id` = '{5}';",
                                                    cinema_Model.Cinema_Name,
                                                    cinema_Model.Movie_name,
                                                    cinema_Model.Theather,
                                                    cinema_Model.Time,
                                                    cinema_Model.Class,
                                                    cinema_Model.Cinema_Id);

                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(query, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }
    }
}
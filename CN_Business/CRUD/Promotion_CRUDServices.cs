using System;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using CN_Modeling;

namespace CN_Business
{
    public class Promotion_CRUDService
    {
        public MySqlConnection Connection;
        DBConnection DBCon;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cinema_simd;  uid=root; pwd=;convert zero datetime=True");
        string query;
        public DataTable get_AllPromotion(DataTable dataTable)
        {
            DataTable DataTableCinema = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select * from promotion ");
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
        public bool Update(Promotion_Model promotion_Model)
        {
            bool result = false;
            query = @"UPDATE `promotion` SET `Name` = @movie_name,`Picture_URL` = @movie_URL WHERE `promotion_id` =@Promotion_Id '{2}'";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.Add("@movie_name", promotion_Model.Movie_name);
                cmd.Parameters.Add("@movie_URL", promotion_Model.Movie_URL);
                cmd.Parameters.Add("@Promotion_Id", promotion_Model.Promotion_ID);
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
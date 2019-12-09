using System;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using CN_Modeling;

namespace CN_Business
{
    public class Theather_CRUDService
    {
        public MySqlConnection Connection;
        DBConnection DBCon;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3307; database=cinema_simd;  uid=root; pwd=;convert zero datetime=True");
        string query;
        public DataTable get_AllTheather(DataTable dataTable)
        {
            DataTable DataTableCinema = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select * from theather ");
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
        public bool Insert(Theather_Model theather_Model)
        {
            bool result = false;
            query = "INSERT INTO `Theather`(`Cinema`,`theather_name`,`seats`)" +
                                    "VALUES(@Cinema,@theather_name,@seats)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.Add("@Cinema", theather_Model.cinema);
                cmd.Parameters.Add("@theather_name", theather_Model.theather_name);
                cmd.Parameters.Add("@seats", theather_Model.seats);
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

        public bool GetDeleteByID(string theather_id)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                query = string.Format(@"DELETE
                                    FROM `theather`
                                    WHERE `theather_id` = '{0}';", theather_id);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(query, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            return result;
        }


        public bool Update(Theather_Model theather_Model)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                query = string.Format(@"UPDATE `theather`
                                        SET 
                                            `cinema` = '{0}',
                                            `theather_name` = '{1}',
                                            `seats` = '{2}'
                                        WHERE `theather_id` = '{3}';",
                                                    theather_Model.cinema,
                                                    theather_Model.theather_name,
                                                    theather_Model.seats,
                                                    theather_Model.theather_id);

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
using System;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using CN_Modeling;

namespace CN_Business
{
    public class Ticket_CRUDService
    {
        public MySqlConnection Connection;
        DBConnection DBCon;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cinema_simd;  uid=root; pwd=;convert zero datetime=True");
        string query;
        public DataTable get_AllTickets(DataTable dataTable)
        {
            DataTable DataTableCinema = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select * from ticket ");
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
        public bool Insert(Ticket_Model ticket_Model)
        {
            bool result = false;
            query = "INSERT INTO `ticket`(`type`,`daycode`,`price`)" +
                                    "VALUES(@type,@daycode,@price)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.Add("@type", ticket_Model.Type);
                cmd.Parameters.Add("@daycode", ticket_Model.DayCode);
                cmd.Parameters.Add("@price", ticket_Model.Price);
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


        public bool GetDeleteByID(string ticket_id)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                query = string.Format(@"DELETE
                                    FROM `ticket`
                                    WHERE `code` = '{0}';", ticket_id);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(query, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            return result;
        }


        public bool Update(Ticket_Model ticket_Model)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                query = string.Format(@"UPDATE `ticket`
                                        SET 
                                            `Type` = '{0}',
                                            `DayCode` = '{1}',
                                            `Price` = '{2}'
                                        WHERE `Code` = '{3}';",
                                                    ticket_Model.Type,
                                                    ticket_Model.DayCode,
                                                    ticket_Model.Price,
                                                    ticket_Model.ticketid);

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
using System;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using CN_Modeling;

namespace CN_Business
{
    public class BookingTicket_CRUDService
    {
        public MySqlConnection Connection;
        DBConnection DBCon;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cinema_simd;  uid=root; pwd=;convert zero datetime=True");
        string query;
        public DataTable get_AllBooking(DataTable dataTable)
        {
            DataTable DataTableCinema = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select * from bookedtickets ");
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
        public bool Insert(BookingTicket_Model bookingTicket_Model)
        {
            bool result = false;
            query = "INSERT INTO `bookedtickets`(`Book_By`,`Cinema_name`,`Theather`,`Movie_Name`,`time`,`seat_number`,`price`,`bookedon`)" +
                                    "VALUES(@Book_By,@Cinema_name,@Theather,@Movie_Name,@time,@seat_number,@price,@bookedon)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.Add("@Book_By", bookingTicket_Model.Book_By);
                cmd.Parameters.Add("@Cinema_name", bookingTicket_Model.Cinema_Name);
                cmd.Parameters.Add("@Theather", bookingTicket_Model.Theather);
                cmd.Parameters.Add("@Movie_Name", bookingTicket_Model.Movie_Name);
                cmd.Parameters.Add("@time", bookingTicket_Model.Time);
                cmd.Parameters.Add("@seat_number", bookingTicket_Model.Seat_Number);
                cmd.Parameters.Add("@price", bookingTicket_Model.Price);
                cmd.Parameters.Add("@bookedon", bookingTicket_Model.BookOn);
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


        public bool GetDeleteByID(string bookingticketid)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                query = string.Format(@"DELETE
                                    FROM `bookedtickets`
                                    WHERE `Ticket_bookid` = '{0}';", bookingticketid);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(query, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            return result;
        }


        public bool Update(BookingTicket_Model bookingTicket_Model)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                query = string.Format(@"UPDATE `bookedtickets`
                                        SET 
                                            `Book_By` = '{0}',
                                            `cinema_name` = '{1}',
                                            `theather` = '{2}',
                                            `movie_name` = '{3}',
                                            `time` = '{4}',
                                            `seat_number` = '{5}',
                                            `price` = '{6}',
                                            `bookedon` = '{7}'
                                        WHERE `ticket_bookid` = '{8}';",
                                                    bookingTicket_Model.Book_By,
                                                    bookingTicket_Model.Cinema_Name,
                                                    bookingTicket_Model.Theather,
                                                    bookingTicket_Model.Movie_Name,
                                                    bookingTicket_Model.Time,
                                                    bookingTicket_Model.Seat_Number,
                                                    bookingTicket_Model.Price,
                                                    bookingTicket_Model.BookOn,
                                                    bookingTicket_Model.Ticket_bookId);

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
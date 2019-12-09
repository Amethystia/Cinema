using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace CN_Business
{
    public class BookingService
    {
        public MySqlConnection Connection;
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3307; database=cinema_simd;  uid=root; pwd=;convert zero datetime=True");
        DataTable dataTable = new DataTable();
        string query;
        public string get_ticket_data(string result, string type,string Daycode)
        {
            MySqlDataAdapter adapter;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT price from ticket where type= '" + type + "'and Daycode='" + Daycode + "'");
                adapter = new MySqlDataAdapter(query, conn);
                dataTable.Clear();
                adapter.Fill(dataTable);
                conn.Close();
                result =dataTable.Rows[0]["price"].ToString();
                return result;
            }
            conn.Close();
            return null;
        }

        public bool buytickets(string username,string cinema_name,string theather,string movie_name,string time,string seat_number,string price)
        {
            MySqlDataAdapter adapter;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"insert into bookedtickets(book_by,cinema_name,theather,movie_name,time,seat_number,price) values('" + username + "','" +cinema_name+ "','" + theather + "','" + movie_name + "','" + time + "','" +seat_number + "','" + price + "')");
                adapter = new MySqlDataAdapter(query, conn);
                dataTable.Clear();
                adapter.Fill(dataTable);
                conn.Close();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool requestcinema(string username, string cinema_name, string movie_name, string classes,string date,string price)
        {
            MySqlDataAdapter adapter;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"insert into bookingcinema(book_by,cinema_name,movie_name,class,date,requeststatus,price) values('" + username + "','" + cinema_name + "','"+ movie_name + "','" + classes + "','" + date + "','" + "waiting" + "','" + price + "')");
                adapter = new MySqlDataAdapter(query, conn);
                dataTable.Clear();
                adapter.Fill(dataTable);
                conn.Close();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

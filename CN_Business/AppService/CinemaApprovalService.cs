using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace CN_Business
{
    public class CinemaApprovalService
    {
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        DBConnection DBCon;
        DataTable dt;
        string sql;
        public MySqlConnection Connection;
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3307; database=cinema_simd;  uid=root; pwd=;convert zero datetime=True");
        string query;
        public DataTable getrequestdata()
        {
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"SELECT Cinema_bookId,book_by,cinema_name,movie_name,class,date,price,RequestStatus FROM `bookingcinema`");
                dt = new DataTable();
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            DBCon.ConnectionClose();
            return dt;
        }

        public DataSet gettheatherdata(DataSet ds,string cinema_name,string kelas,string movie_name)
        {
            DataSet datasettheather = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                query = string.Format(@"select DISTINCT theather from cinemas where cinema_name= '" + cinema_name + "'and class='" + kelas+ "'and movie_name='" + movie_name + "'");
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(datasettheather);
                conn.Close();
                return datasettheather;
            }

            conn.Close();
            return null;
        }

        public DataTable gettheatherdata()
        {
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"SELECT bookingid,requestor,cinema,movie_name,class,date,price,RequestStatus FROM `bookingcinema` where requeststatus is null");
                dt = new DataTable();
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            DBCon.ConnectionClose();
            return dt;
        }

        public void approvedata(string bookingid)
        {
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"UPDATE `bookingcinema` SET requeststatus= 'APPROVED' where cinema_bookid='" + bookingid + "'");
                dt = new DataTable();
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            DBCon.ConnectionClose();
        }
        public void rejectdata(string bookingid)
        {
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"UPDATE `bookingcinema` SET RequestStatus= 'REJECTED' where cinema_bookid='" + bookingid + "'");
                dt = new DataTable();
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            DBCon.ConnectionClose();
        }
    }
}

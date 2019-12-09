using System;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using CN_Modeling;

namespace CN_Business
{
    public class User_CRUD
    {
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        DBConnection DBCon;
        DataTable dt;

        string sql;

        public bool Insert(Users_Model usr)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"INSERT INTO `cinema_simd`.`user`
                                                        (`Name`,
                                                         `Password`,
                                                         `Status`,
                                                         `Sex`,
                                                         `BirthDate`,
                                                         `Address`,
                                                         `IsEmployee`)
                                            VALUES ('{0}',
                                                    '{1}',
                                                    '{2}',
                                                    '{3}',
                                                    '{4}',
                                                    '{5}',
                                                    '{6}');",
                                                    usr._Name,
                                                    usr._Password,
                                                    usr._Status,
                                                    usr._Sex,
                                                    usr._BirthDate.ToString("yyyy-MM-dd"),
                                                    usr._Address,
                                                    usr._IsActive);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            return result;
        }
        public bool GetDeleteByID(string id)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"DELETE
                                    FROM `user`
                                    WHERE `USer_id` = '{0}';", id);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            return result;
        }
        public DataTable getAllData()
        {

            DBCon = new DBConnection();
            sql = string.Format(@"SELECT*FROM `user`");
            dt = new DataTable();
            try
            {
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
        public bool Update(Users_Model usr)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"UPDATE `user`
                                        SET 
                                            `name`='{0}',
                                            `password` = '{1}',
                                            `status` = '{2}',
                                            `sex` = '{3}',
                                            `birthDate` = '{4}',
                                            `Address` = '{5}'
                                            `IsEmployee` = '{6}'
                                        WHERE `Id` = '{0}';",
                                                    usr._Name,
                                                    usr._Password,
                                                    usr._Status,
                                                    usr._Sex,
                                                    usr._BirthDate.ToString("yyyy-MM-dd"),
                                                    usr.Address,
                                                    usr.IsActive,
                                                    usr._UserId);;

                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }
        //public bool Update2(Users_Model usr)
        //{
        //    bool result = false;
        //    try
        //    {
        //        DBCon = new DBConnection();
        //        sql = string.Format(@"UPDATE `TOKO_BUKU`.`user`
        //                                SET 
        //                                    `Id` = '{0}',
        //                                    `password` = '{1}'
        //                                WHERE `Id` = '{0}';",
        //                                            usr._UserId,
        //                                            usr._password2,
        //                                            usr._UserId);

        //        DBCon.ConnectionOpen();
        //        cmd = new MySqlCommand(sql, DBCon.Connection);
        //        result = cmd.ExecuteNonQuery() == 1;
        //        DBCon.ConnectionClose();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //    return result;
    }
  
    //public DataTable Search(Users_Model usr)
    //{

    //    DBCon = new DBConnection();
    //    sql = string.Format(@"SELECT
    //                              `ID`,
    //                              `NAME`,
    //                              `Status`,
    //                              `adress`,
    //                              `SEX`,
    //                              `Birthdate`
    //                               FROM `TOKO_BUKU`.`user`  
    //                               WHERE `Id` like '%{0}%';",
    //                                            usr._UserId);
    //    dt = new DataTable();
    //    try
    //    {
    //        DBCon.ConnectionOpen();
    //        cmd = new MySqlCommand(sql, DBCon.Connection);
    //        adapter = new MySqlDataAdapter(cmd);
    //        adapter.Fill(dt);
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine(ex);
    //    }
    //    DBCon.ConnectionClose();
    //    return dt;
    //}

}

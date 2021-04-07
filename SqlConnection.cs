using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMDB
{
    class SqlConnection
    {
        private static string server = "localhost";
        private static string userid = "CMBD";
        private static string password = "password";
        private static string database = "cmbd";

        public static void InitializeDatabase()
        {
            string cs = @"server=" + server + ";userid=" + userid + "; password=" + password + ";database=" + database;

            MySqlConnection con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS assets(tagNum INTEGER PRIMARY KEY,node VARCHAR(10),os VARCHAR(20),hardDrive VARCHAR(10),ram VARCHAR(10),processor VARCHAR(15),location VARCHAR(15),installDate DATE,upgradeDate DATE,auditDate DATE)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS tickets(tickNum INTEGER PRIMARY KEY,state INTEGER,phone INTEGER,name VARCHAR(20),";
            cmd.ExecuteNonQuery();

        }
    
    }

}

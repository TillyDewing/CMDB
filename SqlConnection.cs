using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMDB
{
    class SqlConnection //SQL Connection class handles calls to SQL Server
    {
        private static string server = "localhost";
        private static string userid = "CMBD";
        private static string password = "password";
        private static string database = "cmbd";

        private static MySqlConnection con;
        private static MySqlCommand cmd;

        private static MySqlDataReader rdr;

        public static void InitializeDatabase()
        {
            string cs = @"server=" + server + ";userid=" + userid + "; password=" + password + ";database=" + database;

            con = new MySqlConnection(cs);
            con.Open();

            cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS assets(tagNum INTEGER AUTO_INCREMENT PRIMARY KEY,node VARCHAR(10),os VARCHAR(20),hardDrive VARCHAR(10),ram VARCHAR(10),processor VARCHAR(15),location VARCHAR(15),installDate DATE,upgradeDate DATE,auditDate DATE)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS tickets(tickNum INTEGER AUTO_INCREMENT PRIMARY KEY,state INTEGER,phone VARCHAR(12),name VARCHAR(20),email VARCHAR(50),priority INTEGER,notes VARCHAR(256), description VARCHAR(256),asset INTEGER, createdDate DATE)";
            cmd.ExecuteNonQuery();
            
        }

        public static void CloseConnection()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        public static void NewTicket(int prioriy, int state, int asset, string name, string phone, string email, string desc, string notes)
        { 
            cmd.CommandText = "INSERT INTO tickets(state, phone, name, email, priority, notes, description, asset) VALUES ('" + state + "','" + name + "','" + email + "','" + prioriy + "','" + notes + "','" + desc + "','" + asset +"','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            cmd.ExecuteNonQuery();
        }

        public static void NewTicket(Ticket ticket)
        {
            NewTicket(ticket.prioriy, ticket.state, ticket.asset, ticket.name, ticket.phone, ticket.email, ticket.desc, ticket.notes);
        }

        public static void NewAsset(string node, string os, string hardDrive, string ram, string processor, string location, DateTime installDate, DateTime upgradeDate, DateTime auditDate)
        { 
            cmd.CommandText = "INSERT INTO assets(node,os,hardDrive,ram,processor,location,installDate,upgradeDate,auditDate) VALUES('" + node + "','" + os + "','" + hardDrive + "','" + ram + "','" + processor + "','" + location + "','" + installDate.ToString("yyyy-MM-dd") + "','" + upgradeDate.ToString("yyyy-MM-dd") + "','" + auditDate.ToString("yyyy-MM-dd") + "')";
            cmd.ExecuteNonQuery();
        }

        public static void GetAsset(int tagNum)
        {
            cmd.CommandText = "SELECT * FROM assets WHERE tagNum=" + tagNum;          
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                Asset.tagNum = tagNum;
                Asset.node = rdr.GetString(1);
                Asset.os = rdr.GetString(2);
                Asset.hardDrive = rdr.GetString(3);
                Asset.ram = rdr.GetString(4);
                Asset.processor = rdr.GetString(5);
                //Asset.installDate = rdr.GetDateTime(6);
                //Asset.upgradeDate = rdr.GetDateTime(7);
                //Asset.auditDate = rdr.GetDateTime(8);
                
                
            }
            else
            { 
                
            }

            rdr.Close();
        }

        public static Ticket GetTicket(int tickNum)
        {
            return null;
        }
    }

}

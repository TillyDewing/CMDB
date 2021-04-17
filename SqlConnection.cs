using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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

            cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS assets(tagNum INTEGER AUTO_INCREMENT PRIMARY KEY,node VARCHAR(10),os VARCHAR(20),hardDrive VARCHAR(10),ram VARCHAR(10),processor VARCHAR(15),location VARCHAR(15),installDate DATE,upgradeDate DATE,auditDate DATE)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS tickets(tickNum INTEGER AUTO_INCREMENT PRIMARY KEY,state INTEGER,phone VARCHAR(12),name VARCHAR(20),email VARCHAR(50),priority INTEGER,notes VARCHAR(256), description VARCHAR(256),asset INTEGER, createdDate DATE)";
            cmd.ExecuteNonQuery();
            
        }

        public static bool AttemptSQLConnection(string username, string password)
        {
            string cs = @"server=" + server + ";userid=" + username + "; password=" + password + ";database=" + database;

            con = new MySqlConnection(cs);

            try
            {
                con.Open();
                InitializeDatabase();

                return true;
            }
            catch (MySqlException)
            {
                string message = "Unable to connect to SQL database. Check login information and server status.";
                string caption = "Error: Unable to connect to SQL Server";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                return false;
            }

        }

        public static void CloseConnection()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        public static void NewTicket()
        {

            int priority = 0;
            int state = 0;
            int asset = 0;
            string name = "name";
            string phone = "phone";
            string email = "email";
            string desc = "description";
            string notes = "Notes";

            cmd.CommandText = "INSERT INTO tickets(state, phone, name, email, priority, notes, description, asset, createdDate) VALUES ('" + state + "','" + phone + "','" + name + "','" + email + "','" + priority + "','" + notes + "','" + desc + "','" + asset +"','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            cmd.ExecuteNonQuery();
            GetLatestTicketNum();

        }

        public static void NewAsset()
        {
            string node = "node";
            string os = "os";
            string hardDrive = "harddrive";
            string ram = "ram";
            string processor = "processor";
            string location = "location";
            DateTime installDate = DateTime.Now;
            DateTime upgradeDate = DateTime.Now;
            DateTime auditDate = DateTime.Now;

            cmd.CommandText = "INSERT INTO assets(node,os,hardDrive,ram,processor,location,installDate,upgradeDate,auditDate) VALUES('" + node + "','" + os + "','" + hardDrive + "','" + ram + "','" + processor + "','" + location + "','" + installDate.ToString("yyyy-MM-dd") + "','" + upgradeDate.ToString("yyyy-MM-dd") + "','" + auditDate.ToString("yyyy-MM-dd") + "')";
            cmd.ExecuteNonQuery();
            GetLatestAssetNum();
        }

        public static void UpdateAsset(int assetTag, string node, string os, string hardDrive, string ram, string processor, string location, DateTime installDate, DateTime upgradeDate, DateTime auditDate)
        {
            cmd.CommandText = "UPDATE assets Set node='" + node + "',os='" + os + "',hardDrive='" + hardDrive + "',ram='" + ram + "',processor='" + processor + "',location='" + location + "',installDate='" + installDate.ToString("yyyy-MM-dd") + "',upgradeDate='" + upgradeDate.ToString("yyyy-MM-dd") + "',auditDate='" + auditDate.ToString("yyyy-MM-dd") + "' WHERE tagNum=" + assetTag;
            cmd.ExecuteNonQuery();
        }

        public static void UpdateTicket(int ticketNum, int priority, int state, int asset, string name, string phone, string email, string desc, string notes)
        {
            cmd.CommandText = "UPDATE tickets Set asset=" + asset + ",state=" + state + ",name='" + name + "',phone='" + phone + "',email='" + email + "',priority='" + priority + "',notes='" + notes + "',description='" + desc + "' WHERE tickNum=" + ticketNum;
            cmd.ExecuteNonQuery();
        }

        public static bool GetAsset(int tagNum)
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
                Asset.location = rdr.GetString(6);
                Asset.installDate = rdr.GetDateTime(7);
                Asset.upgradeDate = rdr.GetDateTime(8);
                Asset.auditDate = rdr.GetDateTime(9);

                rdr.Close();
                return true;
            }
            else
            {
                rdr.Close();
                return false;
            }

        }

        public static bool GetTicket(int tickNum)
        {
            cmd.CommandText = "SELECT * FROM tickets WHERE tickNum=" + tickNum;
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();

                Ticket.ticketNum = rdr.GetInt32(0);
                Ticket.state = rdr.GetInt32(1);
                Ticket.phone = rdr.GetString(2);
                Ticket.name = rdr.GetString(3);
                Ticket.email = rdr.GetString(4);
                Ticket.prioriy = rdr.GetInt32(5);
                Ticket.notes = rdr.GetString(6);
                Ticket.desc = rdr.GetString(7);
                Ticket.asset = rdr.GetInt32(8);
                Ticket.createdDate = rdr.GetDateTime(9);

                rdr.Close();
                return true;
            }
            else
            {
                //No ticket found
                rdr.Close();
                return false;
            }

        }

        public static void GetLatestTicketNum()
        {
            cmd.CommandText = "SELECT MAX(tickNum) From tickets";
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                Ticket.ticketNum = rdr.GetInt32(0);
                rdr.Close();
            }
        }

        public static void GetLatestAssetNum()
        {
            cmd.CommandText = "SELECT MAX(tagNum) From assets";
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                Asset.tagNum = rdr.GetInt32(0);
                rdr.Close();
            }
        }

        public static void GetOpenTicketNums()
        {
            Asset.openTickets = new List<int>();
            int asset = Asset.tagNum;

            cmd.CommandText = "SELECT tickNum From tickets Where asset=" + asset + " AND state=0";

            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Asset.openTickets.Add(rdr.GetInt32(0));
                }
            }
            rdr.Close();
        }

        public static void DeleteAsset(int tagNum)
        {
            cmd.CommandText = "DELETE FROM assets WHERE tagnum=" + tagNum;
            cmd.ExecuteNonQuery();
        }

        public static void DeleteTicket(int tickNum)
        {
            cmd.CommandText = "DELETE FROM tickets WHERE tickNum=" + tickNum;
            cmd.ExecuteNonQuery();
        }

        public static List<string> GetAuditList()
        {
            List<string> results = new List<string>();

            DateTime auditDate = DateTime.Today.AddMonths(-24);

            cmd.CommandText = "SELECT tagNum FROM assets WHERE auditDate <= '" + auditDate.ToString("yyyy-MM-dd") + "'";
            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                results.Add(rdr.GetInt32(0).ToString().PadLeft(6, '0'));
            }
            rdr.Close();
            return results;
        }

        public static List<string> GetReplacementList()
        { 
            List<string> results = new List<string>();

            DateTime replaceDate = DateTime.Today.AddMonths(-48);

            cmd.CommandText = "SELECT tagNum FROM assets WHERE installDate <= '" + replaceDate.ToString("yyyy-MM-dd") + "'";
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                results.Add(rdr.GetInt32(0).ToString().PadLeft(6, '0'));
            }
            rdr.Close();
            return results;

        }
    }

}

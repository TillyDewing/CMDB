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
            string cs = @"server=" + server + ";userid=" + userid + "; password=" + password + ";database=" + database;

            con = new MySqlConnection(cs);
            
            try
            {
                con.Open();
            }
            catch (MySqlException)
            {
                string message = "Unable to connect to SQL database. Check server is up and running.";
                string caption = "Error: Unable to connect to SQL Server";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                return;
            }

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

        public static void NewTicket(int priority, int state, int asset, string name, string phone, string email, string desc, string notes)
        {
            Ticket.prioriy = priority;
            Ticket.asset = asset;
            Ticket.state = state;
            Ticket.name = name;
            Ticket.phone = phone;
            Ticket.email = email;
            Ticket.desc = desc;
            Ticket.notes = notes;

            cmd.CommandText = "INSERT INTO tickets(state, phone, name, email, priority, notes, description, asset) VALUES ('" + state + "','" + name + "','" + email + "','" + priority + "','" + notes + "','" + desc + "','" + asset +"','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            cmd.ExecuteNonQuery();
        }

        public static void NewAsset(string node, string os, string hardDrive, string ram, string processor, string location, DateTime installDate, DateTime upgradeDate, DateTime auditDate)
        { 
            cmd.CommandText = "INSERT INTO assets(node,os,hardDrive,ram,processor,location,installDate,upgradeDate,auditDate) VALUES('" + node + "','" + os + "','" + hardDrive + "','" + ram + "','" + processor + "','" + location + "','" + installDate.ToString("yyyy-MM-dd") + "','" + upgradeDate.ToString("yyyy-MM-dd") + "','" + auditDate.ToString("yyyy-MM-dd") + "')";
            cmd.ExecuteNonQuery();
        }

        public static void UpdateAsset(int assetTag, string node, string os, string hardDrive, string ram, string processor, string location, DateTime installDate, DateTime upgradeDate, DateTime auditDate)
        {
            cmd.CommandText = "UPDATE assets Set node=" + node + ",os=" + os + ",hardDrive=" + hardDrive + ",ram=" + ram + ",processor=" + processor + ",location=" + location + ",installDate=" + installDate.ToString("yyyy-MM-dd") + ",upgradeDate=" + upgradeDate.ToString("yyyy-MM-dd") + ",auditDate=" + auditDate.ToString("yyyy-MM-dd") + " WHERE tagNum=" + assetTag;
            cmd.ExecuteNonQuery();
        }

        public static void UpdateTicket(int ticketNum, int priority, int state, int asset, string name, string phone, string email, string desc, string notes)
        {
            cmd.CommandText = "UPDATE tickets Set state=" + state + ",phone=" + phone + ",email=" + email + ",priority=" + priority + ",notes=" + notes + ",description=" + desc + " WHERE tickNum=" + ticketNum;
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
                Asset.location = rdr.GetString(6);
                Asset.installDate = rdr.GetDateTime(7);
                Asset.upgradeDate = rdr.GetDateTime(8);
                Asset.auditDate = rdr.GetDateTime(9);


            }
            else
            { 
                
            }

            rdr.Close();
        }

        public static void GetTicket(int tickNum)
        {
            cmd.CommandText = "SELECT * FROM tickets WHERE tagNum=" + tickNum;
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

            }
            else
            { 
                //No ticket found
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
        }

    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace CMDB
{
    class Ticket //Container for active ticket.
    {
        public static int ticketNum;
        public static int prioriy;
        public static int state;
        public static int asset;

        public static string name;
        public static string phone;
        public static string email;
        public static string desc;
        public static string notes;

        public static DateTime createdDate;

        public static void Clear()
        {
            ticketNum = 0;
            prioriy = 0;
            state = 0;
            asset = 0;

            name = "";
            phone = "";
            email = "";
            desc = "";
            notes = "";

            createdDate = DateTime.Now;
        }
    }
}

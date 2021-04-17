using System;
using System.Collections.Generic;
using System.Text;

namespace CMDB
{
    class Asset //Container for active asset
    {
        public static int tagNum;
        public static string node;
        public static string location;

        public static DateTime installDate;
        public static DateTime upgradeDate;
        public static DateTime auditDate;

        public static string processor;
        public static string hardDrive;
        public static string ram;
        public static string os;

        public static List<int> openTickets;

        public static void Clear()
        {
            tagNum = 0;
            node = "";
            location = "";
            installDate = DateTime.Now;
            upgradeDate = DateTime.Now;
            auditDate = DateTime.Now;
            processor = "";
            hardDrive = "";
            ram = "";
            os = "";

        }
    }
}

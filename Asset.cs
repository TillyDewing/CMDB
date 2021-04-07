using System;
using System.Collections.Generic;
using System.Text;

namespace CMDB
{
    class Asset
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

        public List<int> openTickets;
        public static CMBD form;

        public void GetOpenTickets()
        {

        }

        public void UpdateAsset(int tagNum, string node, string os, string hardDrive, string ram, string processor, string location, DateTime installDate, DateTime upgradeDate, DateTime auditDate)
        {
            Asset.tagNum = tagNum;
            Asset.node = node;
            Asset.os = os;
            Asset.hardDrive = hardDrive;
            Asset.ram = ram;
            Asset.processor = processor;
            Asset.location = location;
            Asset.installDate = installDate;
            Asset.upgradeDate = upgradeDate;
            Asset.auditDate = auditDate;
        }

    }
}

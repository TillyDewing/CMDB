using System;
using System.Collections.Generic;
using System.Text;

namespace CMDB
{
    class Asset
    {
        public int tagNum;
        public string loc;

        public DateTime installDate;
        public DateTime replaceDate;
        public DateTime auditDate;

        public string processor;
        public string hardDrive;
        public string ram;
        public string os;

        public List<int> openTickets;

        public void LoadRecord(int tagNum)
        { 
            //sql load statement heres
        }

        public void SaveRecord()
        { 
            //save current form data to sql table.
        }

        public void RefreshTickets()
        { 
            //possible implimentation to refresh open ticket view.        
        }
    }
}

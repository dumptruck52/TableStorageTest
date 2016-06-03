using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTableStorageScale
{
    public class StateEntity : TableEntity
    {
        public StateEntity(string stateAbbrev, string transactionId)
        {
            PartitionKey = stateAbbrev;
            RowKey = transactionId;
        }

        public StateEntity() { }

        public string Plate { get; set; }

        public string Dot { get; set; }

        public string AccountNumber { get; set; }

        public bool StationOpenClosed { get; set; }

        public DateTime BypassTimeStamp { get; set; }
    }
}

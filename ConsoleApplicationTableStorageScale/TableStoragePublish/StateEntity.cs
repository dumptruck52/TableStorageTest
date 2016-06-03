using System;
using Microsoft.WindowsAzure.Storage.Table;

namespace TableStoragePublish
{
    public class StateEntity : TableEntity
    {
        public StateEntity(string location, string transactionId)
        {
            PartitionKey = location;
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

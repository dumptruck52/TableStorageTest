using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;
using System.Configuration;

namespace ConsoleApplicationTableStorageScale
{
    class Program
    {
        static void Main(string[] args)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["AzureTableConnectionString"]);

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            CloudTable table = tableClient.GetTableReference("California");
            table.CreateIfNotExists();

            StateEntity state = new StateEntity("Truckee", Guid.NewGuid().ToString());
            state.AccountNumber = "123";
            state.BypassTimeStamp = DateTime.Now;
            state.Dot = "321";
            state.Plate = "987654";
            state.StationOpenClosed = true;

            TableOperation insert = TableOperation.Insert(state);

            table.Execute(insert);
        }
    }
}

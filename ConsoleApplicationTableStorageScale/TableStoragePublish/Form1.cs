using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;
using System.Configuration;
using System.Net;
using System.Diagnostics;

namespace TableStoragePublish
{
    public partial class Form1 : Form
    {
        public CloudStorageAccount StorageAccount { get; set; }

        public CloudTableClient TableClient { get; set; }

        List<string> californiaLocations = new List<string> { "BlytheWB", "Calexico", "CajonNB", "CajonSB", "Chowchilla", "RainbowSB", "PeraltaWB", "GrapevineSB", "CacheCreekWB", "OtayMesaNB" };

        List<string> arizonaLocations = new List<string> { "StGeorgeSB","Ehrenberg","Topock","Yuma", "Sanders" };

        List<string> utahLocations = new List<string> { "PerryNB","PerrySB","EchoWB","WendoverEB","WendoverWB","StGeorgeNB","Monticello" };


        public Form1()
        {
            InitializeComponent();

            //SetUpAzureTableClient();
        }

        private void SetUpAzureTableClient()
        {
            StorageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["AzureTableConnectionString"]);
            ServicePointManager.UseNagleAlgorithm = false;

            TableClient = StorageAccount.CreateCloudTableClient();
            TableClient.DefaultRequestOptions.PayloadFormat = TablePayloadFormat.JsonNoMetadata;
        }

        private void stateComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (stateComboBox.SelectedItem.ToString() == "California")
            {
                locationComboBox.DataSource = californiaLocations;
            }
            else if (stateComboBox.SelectedItem.ToString() == "Arizona")
            {
                locationComboBox.DataSource = arizonaLocations;
            }
            else if (stateComboBox.SelectedItem.ToString() == "Utah")
            {
                locationComboBox.DataSource = utahLocations;
            }
        }

        private void btnSendMessages_Click(object sender, EventArgs e)
        {
            btnSendMessages.Enabled = false;

            lblResultTime.Text = "Running...";

            Stopwatch timer = Stopwatch.StartNew();

            for (int i = 0; i < nudMessagesSent.Value; i++)
            {
                SendMessageToTableStorage();
                lblCount.Text = i.ToString();
            }

            timer.Stop();

            lblResultTime.Text = string.Concat("Elapsed: ", timer.ElapsedMilliseconds.ToString(), "ms");

            lblCount.Text = "0";

            btnSendMessages.Enabled = true;
        }

        private async void SendMessageToTableStorage()
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["AzureTableConnectionString"]);
            ServicePointManager.UseNagleAlgorithm = false;

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();
            tableClient.DefaultRequestOptions.PayloadFormat = TablePayloadFormat.JsonNoMetadata;

            CloudTable table = tableClient.GetTableReference(stateComboBox.SelectedItem.ToString());
            table.CreateIfNotExists();

            StateEntity state = new StateEntity(locationComboBox.SelectedItem.ToString(), Guid.NewGuid().ToString());
            state.AccountNumber = "123";
            state.BypassTimeStamp = DateTime.Now;
            state.Dot = "321";
            state.Plate = "987654";
            state.StationOpenClosed = true;

            TableOperation insert = TableOperation.Insert(state, false);

            await table.ExecuteAsync(insert);
        }
    }
}

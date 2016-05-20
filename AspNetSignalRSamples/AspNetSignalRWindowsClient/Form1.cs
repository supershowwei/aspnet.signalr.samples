using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;

namespace AspNetSignalRWindowsClient
{
    public partial class Form1 : Form
    {
        private static readonly string HubName = "BroadcastHub";
        private HubConnection hubConnection = new HubConnection(@"http://localhost:31949/");
        private IHubProxy broadcastHubProxy;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 建立 Hub Proxy
            this.broadcastHubProxy = this.hubConnection.CreateHubProxy(HubName);

            // 註冊給伺服端呼叫的方法
            this.broadcastHubProxy.On("ShowMessage", (string name, string message) =>
            {
                this.MessagesBlock.InvokeIfNecessary(() =>
                {
                    this.MessagesBlock.AppendText($"{name}, {message}\r\n");
                });
            });

            // 連線到 SignalR 伺服器
            this.hubConnection.Start().Wait();
        }

        private async void SendMessageButton_Click(object sender, EventArgs e)
        {
            await this.broadcastHubProxy.Invoke("Broadcast", this.NameTextBox.Text, this.MessageTextBox.Text);
        }
    }
}

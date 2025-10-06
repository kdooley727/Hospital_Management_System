using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;

namespace ClientChat
{
    public partial class ChatForm : Form
    {
        private HubConnection connection;
        public ChatForm()
        {
            InitializeComponent();
            InitializeSignalR();
        }

        private async void InitializeSignalR()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7257/chathub")
                .Build();

            //receive messages
            connection.On<string, string>("ReceiveMessage", (user, Message) =>
            {
                Invoke((Action)(() =>
                {
                    string messageText = $"{user}: {Message}";

                    lstBox_ChatHistory.Items.Add(messageText);
                }));
            });

            try
            {
                await connection.StartAsync();
                MessageBox.Show("Connection to the hub was successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void btn_Send_Click(object sender, EventArgs e)
        {
            //send messages
            string user = txtBox_Username.Text;
            string message = txtBox_Message.Text;

            try
            {
                await connection.InvokeAsync("SendMessage", user, message);
                txtBox_Message.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

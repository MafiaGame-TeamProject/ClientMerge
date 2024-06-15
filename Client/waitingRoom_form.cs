
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatLib.Handlers;
using ChatLib.Models;
using ChatLib.Sockets;
using WinFormClient;
using System.Net;

namespace WaitingRoom
{
    public partial class waitingRoom_form : KryptonForm
    {
        System.Windows.Forms.Label[] labels;

        public waitingRoom_form()
        {
            InitializeComponent();
            Init_form._client = new ChatClient(IPAddress.Parse("127.0.0.1"), 8080);
            Init_form._client.Received += Received;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Room_lbl.Parent = UsersView;
            Room_lbl.BackColor = Color.Transparent;
            Room_lbl.Left = (UsersView.Width - Room_lbl.Width) / 2;
            Room_lbl.Top = UsersView.Height/50;

            labels = new Label[] {name1_lbl,name2_lbl, name3_lbl, name4_lbl};

            int people_num = 1;
            

            for (int i = 0; i < 4; i++)
            {
                labels[i].Parent = UsersView;
                labels[i].BackColor = Color.Transparent;
                labels[i].ForeColor = Color.White;
                labels[i].Left = (UsersView.Width - labels[i].Width) / 2 - 20;
                labels[i].Top = UsersView.Top + 20 + (i*(labels[i].Height+26));
            }


            

        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Received(object? sender, ChatLib.Events.ChatEventArgs e)
        {
            ChatHub hub = e.Hub;
            string message = hub.State switch
            {
                ChatState.Connect => $"{hub.UserName}",
                ChatState.Disconnect => $"{hub.UserName}",
            };

            if(hub.State == ChatState.Connect)
            {
                for(int i = 0; i < 4; i++)
                {
                    if (labels[i].Text == "")
                    {
                        labels[i].Text = message;
                        break;
                    }
                        
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    if (labels[i].Text == message)
                       { 
                        labels[i].Text = "";
                        break;
                    }
                }
            }
        }
    }
}

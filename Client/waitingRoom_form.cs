
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
using ChatLib.Events;

namespace WaitingRoom
{
    public partial class waitingRoom_form : KryptonForm
    {
        System.Windows.Forms.Label[] labels;

        private ClientRoomManager _roomManager;
        
        public List<ClientHandler> newList = new();
        private static int RoomId;

        private void Form1_Load(object sender, EventArgs e)
        {
            Room_lbl.Parent = UsersView;
            Room_lbl.BackColor = Color.Transparent;
            Room_lbl.Left = (UsersView.Width - Room_lbl.Width) / 2;
            Room_lbl.Top = UsersView.Height/50;

            labels = new Label[] {name1_lbl,name2_lbl, name3_lbl, name4_lbl};

            int people_num = 1;

            Room_lbl.Text = RoomId.ToString();

            for (int i = 0; i < labels.Length; i++)
                labels[i].Text = "";

            for (int i = 0; i < 4; i++)
            {
                labels[i].Parent = UsersView;
                labels[i].BackColor = Color.Transparent;
                labels[i].ForeColor = Color.White;
                labels[i].Left = (UsersView.Width - labels[i].Width) / 2 - 20;
                labels[i].Top = UsersView.Top + 20 + (i*(labels[i].Height+26));
            }

            
            newList = _roomManager.RoomUser(RoomId);

            if (newList != null)
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    if (newList[i].InitialData.UserName != string.Empty)
                    {
                        labels[i].Text = newList[i].InitialData.UserName;
                    }
                }
            }
        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void UserInfo(int roomId)
        {
            
            
            
            
            RoomId = roomId;

           
        }

        public waitingRoom_form()
        {
            InitializeComponent();
            _roomManager = new ClientRoomManager();
            


        }
    }
}

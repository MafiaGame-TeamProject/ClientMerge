using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ChatLib.Sockets;
using SuggestedWord;

namespace WaitingRoom
{
    public partial class waitingRoom_form : KryptonForm
    {
        private System.Windows.Forms.Label[] labels;
        private List<string> newList = new();
        private static int RoomId;
        private ChatClient _client;

        public waitingRoom_form(ChatClient client)
        {
            InitializeComponent();
            _client = client;
            labels = new Label[] { name1_lbl, name2_lbl, name3_lbl, name4_lbl };
        }

        public void UserInfo(int roomId, List<string> users)
        {
            newList = users;
            RoomId = roomId;
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            Room_lbl.Text = "Room " + RoomId.ToString();

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = "";
            }

            for (int i = 0; i < newList.Count && i < labels.Length; i++)
            {
                labels[i].Text = newList[i];
            }

            
            if(newList.Count == 4)
            {
                var suggestWordForm = new suggestWord_form(_client);
                suggestWordForm.Show();
                this.Hide();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Room_lbl.Parent = UsersView;
            Room_lbl.BackColor = Color.Transparent;
            Room_lbl.Left = (UsersView.Width - Room_lbl.Width) / 2;
            Room_lbl.Top = UsersView.Height / 50;

            for (int i = 0; i < labels.Length; i++)
            {
                
                labels[i].Parent = UsersView;
                labels[i].BackColor = Color.Transparent;
                labels[i].ForeColor = Color.White;
                labels[i].Left = (UsersView.Width - labels[i].Width) / 2 - 20;
                labels[i].Top = UsersView.Top + 20 + (i * (labels[i].Height + 26));
            }
        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void waitingRoom_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 클라이언트 연결 종료
            _client.Close();
        }
    }
}

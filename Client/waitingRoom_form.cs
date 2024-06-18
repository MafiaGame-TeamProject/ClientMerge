using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ChatLib.Sockets;
using SuggestedWord;
using ChatLib.Handlers;
using WinFormClient;

namespace WaitingRoom
{
    public partial class waitingRoom_form : KryptonForm
    {
        private System.Windows.Forms.Label[] labels;
        private List<string> newList = new();
        private static int RoomId;
        private ChatClient _client;
        private ClientHandler _clientHandler;
        private string _userName;
        private string _word;
        private ChattingForm _chattingForm;


        public waitingRoom_form(ChatClient client, ClientHandler handler, string UserName, ChattingForm chattingForm)
        {
            InitializeComponent();
            _client = client;
            _clientHandler = handler;
            _userName = UserName;
            _chattingForm = chattingForm;


            labels = new Label[] { name1_lbl, name2_lbl, name3_lbl, name4_lbl };
            /*_client.Received += Client_Received;*/
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
                button1.Text = "유저 " + newList.Count + "/4";
            }
        }

        /*private void Client_Received(object sender, ChatLib.Events.ChatEventArgs e)
        {
            var hub = e.Hub;
            if (hub.Message.StartsWith("WORD:"))
            {
                var words = hub.Message.Substring("WORD:".Length).Split(',').ToList();
                BeginInvoke((MethodInvoker)delegate
                {
                    var suggestWordForm = new suggestWord_form(_client, _clientHandler, _userName, words, _chattingForm);
                    suggestWordForm.Show();
                    this.Hide();
                });
            }
        }*/

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
                if (i == 0)
                    labels[i].Left = (UsersView.Width - labels[i].Width) / 2 - 20;
                else
                {
                    labels[i].Left = labels[0].Left;
                }
                labels[i].Top = UsersView.Top + 40 + (i * (labels[i].Height + 52));
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

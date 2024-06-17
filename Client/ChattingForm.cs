using ChatLib.Handlers;
using ChatLib.Sockets;
using ChatLib.Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using SuggestedWord;
using WaitingRoom;
using Krypton.Toolkit;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormClient
{
    public partial class ChattingForm : KryptonForm
    {
        ChatClient _client;
        ClientHandler _clientHandler;
        string _userName;

        List<string> _userList;

        private int m = 0;
        private int s = 5;

       

        public ChattingForm(ChatClient client, ClientHandler handler, string userName)
        {
            InitializeComponent();
            _client = client;
            _clientHandler = handler;
            _userName = userName;
            
        }

        // 메시지를 보내는 메서드
        private void sendBtn_Click(object sender, EventArgs e)
        {
            string msg = txtInput.Text;
            if (!string.IsNullOrWhiteSpace(msg))
            {
                chatPanel.Controls.Add(new MyChat(msg));
                txtInput.Text = "";

                _clientHandler.Send(new ChatHub
                {
                    UserName = _userName,
                    Message = "MsgSend:"+msg,
                });

            }
        }

        public void AddOtherChat(string msg, string user)
        {
            chatPanel.Controls.Add(new OtherChat(msg, user));
        }

        /*public void setUsername(List<string> users)
        {
            _userList = users;
            
        }*/

        private void UItimer_Tick(object sender, EventArgs e)
        {
            if (s == 0)
            {
                if (m == 0)
                {
                    gTimer.Stop();

                    _clientHandler.Send(new ChatHub
                    {
                        Message = "plzUserList",
                    });
                    return;
                }
                m--;
                s = 59;
            }
            else
            {
                s--;
            }
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            timeLbl.Text = $"{m:D2}:{s:D2}";
        }

        private void ChattingForm_Load(object sender, EventArgs e)
        {
            gTimer.Start();
        }
        
        public void setWord(string word)
        {
            wordLbl.Text = word;
        }
    }
}

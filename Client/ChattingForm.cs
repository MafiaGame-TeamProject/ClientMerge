using ChatLib.Handlers;
using ChatLib.Sockets;
using ChatLib.Models;
using System;
using System.Windows.Forms;

namespace WinFormClient
{
    public partial class ChattingForm : Form
    {
        ChatClient _client;
        ClientHandler _clientHandler;
        string _userName;

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
                    Message = msg,
                });
                
            }
        }

        public void AddOtherChat(string msg, string user)
        {
            chatPanel.Controls.Add(new OtherChat(msg, user));
        }
    }
}

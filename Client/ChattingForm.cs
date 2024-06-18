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

        private int m = 3;
        private int s = 0;

        public ChattingForm(ChatClient client, ClientHandler handler, string userName)
        {
            InitializeComponent();
            _client = client;
            _clientHandler = handler;
            _userName = userName;

            this.KeyPreview = true; // ���� KeyPreview �Ӽ��� true�� ����

            // txtInput ��Ʈ���� KeyDown �̺�Ʈ ó���� ���
            txtInput.KeyDown += TxtInput_KeyDown;
        }

        // �޽����� ������ �޼���
        private void sendBtn_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void SendMessage()
        {
            string msg = txtInput.Text;
            if (!string.IsNullOrWhiteSpace(msg))
            {
                chatPanel.Controls.Add(new MyChat(msg));
                txtInput.Text = "";

                _clientHandler.Send(new ChatHub
                {
                    UserName = _userName,
                    Message = "MsgSend:" + msg,
                });
            }
        }

        public void AddOtherChat(string msg, string user)
        {
            chatPanel.Controls.Add(new OtherChat(msg, user));
        }

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

        // ���� KeyDown �̺�Ʈ ó����
        private void ChattingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendMessage();
                e.SuppressKeyPress = true; // ���� Ű �Է��� ��Ʈ�ѿ��� ó������ �ʵ��� ����
            }
        }

        // txtInput ��Ʈ���� KeyDown �̺�Ʈ ó����
        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendMessage();
                e.SuppressKeyPress = true; // ���� Ű �Է��� �ؽ�Ʈ�ڽ����� ó������ �ʵ��� ����
            }
        }
    }
}

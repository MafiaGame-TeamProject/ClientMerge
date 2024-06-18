using ChatLib.Handlers;
using ChatLib.Models;
using ChatLib.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WinFormClient
{
    public partial class wordGuessing : Form
    {
        private int remainingTime = 60; // 1분
        ChatClient _client;
        ClientHandler _clientHandler;
        string _userName;
        string _topic;

        public wordGuessing(ChatClient client, ClientHandler handler, string userName, string topic)
        {
            InitializeComponent();
            _client = client;
            _clientHandler = handler;
            _userName = userName;
            _topic = topic;

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // 1초 간격
            timer1.Tick += Timer1_Tick;
            this.Load += wordGuessing_Load;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;

            // 시간 업데이트
            int minutes = remainingTime / 60;
            int seconds = remainingTime % 60;
            timeLabel.Text = $"{minutes}:{seconds:D2}";

            // 시간이 다 되면 타이머 중지
            if (remainingTime <= 0)
            {
                timer1.Stop();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string msg = txtBox.Text;
            if (!string.IsNullOrWhiteSpace(msg))
            {
                _clientHandler.Send(new ChatHub
                {
                    Message = "ANSWER:" + msg,
                });
            }
            this.Hide();
        }

        private void wordGuessing_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelWord.Text = _topic;
        }
    }
}

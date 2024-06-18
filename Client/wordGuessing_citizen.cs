using ChatLib.Handlers;
using ChatLib.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormClient
{
    public partial class wordGuessing_citizen : Form
    {
        private int remainingTime = 15; // 15초
        ChatClient _client;
        ClientHandler _clientHandler;
        string _userName;
        string _word;

        string _votedUser; // 최다득표자
        string _liarName; // 라이어 이름
        string _citizenName; // 시민'들' 이름
        string _realWord; // 시민 제시어
        bool _whoWin; // 누가 이겼는지 여부
        string _liarWord; // 라이어가 선택한 제시어

        public wordGuessing_citizen(ChatClient client, ClientHandler handler, string userName, string word, string votedUser, string liarName, string citizenName, string realWord, string liarWord)
        {
            InitializeComponent();
            _client = client;
            _clientHandler = handler;
            _userName = userName;
            _word = word;
            _votedUser = votedUser;
            _liarName = liarName;
            _citizenName = citizenName;
            _realWord = realWord;
            _liarWord = liarWord;

            timer1 = new System.Windows.Forms.Timer();
            //timer1.Interval = 1000; // 1초 간격
            timer1.Tick += Timer1_Tick;
            this.Load += wordGuessing_citizen_Load;
            _liarWord = liarWord;
        }

        private void wordGuessing_citizen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelWord.Text = _liarWord + "입니다!";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            // 시간이 다 되면 타이머 중지
            if (remainingTime <= 0)
            {
                timer1.Stop();
                
                if (_liarWord == _realWord) // 라이어 우승
                 {
                    _whoWin = false;
                    var gameEndForm = new gameEnd(_whoWin, _liarName, _citizenName, _realWord);
                    gameEndForm.Show();
                    this.Close();
                }
                else // 시민 우승
                 {
                    _whoWin = true;
                    var gameEndForm = new gameEnd(_whoWin, _liarName, _citizenName, _realWord);
                    gameEndForm.Show();
                    this.Close();
                } 
            }
        }
    }
}

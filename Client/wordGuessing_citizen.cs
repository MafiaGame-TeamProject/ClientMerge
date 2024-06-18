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
        ChatClient _client;
        ClientHandler _clientHandler;
        string _userName;
        List<string> _word;

        List<string> _totalUsers;
        string _liarAnswer; // 최다득표자

        string _liarName; // 라이어 이름
        string _citizenName; // 시민'들' 이름
        string _realWord; // 시민 제시어
        bool _whoWin; // 누가 이겼는지 여부(시민승: T / 라이어승: F)

        private int remainingTime = 15; // 15초

        public wordGuessing_citizen(ChatClient client, ClientHandler handler, string userName, List<string> word, List<string> totalUsers, string liarAnswer)
        {
            InitializeComponent();
            _client = client;
            _clientHandler = handler;
            _userName = userName;
            _word = word;
            _totalUsers = totalUsers;
            _liarAnswer = liarAnswer;

            _liarName = _word[5];
            _realWord = _word[3];

            for (int i = 0; i < 4; i++)
            {
                if (_totalUsers[i] != _liarName)
                {
                    _citizenName += _totalUsers[i] + " ";
                }
            }

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // 1초 간격
            timer1.Tick += Timer1_Tick;
            this.Load += wordGuessing_citizen_Load;
        }
 
    private void wordGuessing_citizen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelWord.Text = _liarAnswer + "입니다!";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            // 시간이 다 되면 타이머 중지
            if (remainingTime <= 0)
            {
                timer1.Stop();
                
                if (_liarAnswer == _realWord) // 라이어 우승
                 {
                    _whoWin = false;
                    var gameEndForm = new gameEnd(_client, _whoWin, _liarName, _citizenName, _realWord);
                    gameEndForm.Show();
                    this.Hide();
                }
                else // 시민 우승
                 {
                    _whoWin = true;
                    var gameEndForm = new gameEnd(_client, _whoWin, _liarName, _citizenName, _realWord);
                    gameEndForm.Show();
                    this.Hide();
                } 
            }
        }
    } 
}

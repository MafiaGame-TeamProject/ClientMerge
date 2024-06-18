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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormClient
{
    public partial class voteResult : Form
    {
        ChatClient _client;
        ClientHandler _clientHandler;
        string _userName;
        List<string> _word;

        List<string> _totalUsers;
        string _votedUser; // 최다득표자

        string _liarName; // 라이어 이름
        string _citizenName; // 시민'들' 이름
        string _realWord; // 시민 제시어
        bool _whoWin; // 누가 이겼는지 여부(시민승: T / 라이어승: F)

        private int remainingTime = 15; // 15초

        //voteResult(_client, _clientHandler, UserName, _words, _totalUsers, _votedUser);
        public voteResult(ChatClient client, ClientHandler handler, string userName, List<string> word, List<string> totalUsers, string votedUser)
        {
            InitializeComponent();
            _client = client;
            _clientHandler = handler;
            _userName = userName;
            _word = word;
            _totalUsers = totalUsers;
            _votedUser = votedUser;

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
            this.Load += voteResult_Load;
        }

        private void voteResult_Load(object sender, EventArgs e)
        {
            // 폼이 로드될 때 타이머 시작
            timer1.Start();

            if (_votedUser != _liarName) // 시민 처형
            {
                labelDie.Text = _votedUser + "님이 처형당했습니다";
                labelJob.Text = _votedUser + "님은 \n시민입니다.";
                _whoWin = false;
            }
            else // 라이어 처형
            {
                labelDie.Text = _votedUser + "님이 처형당했습니다";
                labelJob.Text = _votedUser + "님은 라이어입니다.\n" + "라이어는 제시어를 맞춰주세요.";
                _whoWin = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;

            // 시간이 다 되면 타이머 중지
            if (remainingTime <= 0)
            {
                timer1.Stop();

                if (!_whoWin)
                { // 시민 처형
                    var gameEndForm = new gameEnd(_whoWin, _liarName, _citizenName, _realWord);
                    gameEndForm.Show();
                    this.Hide();
                }
                else // 라이어 처형
                { 
                    // 라이어만 제시어 맞추기(라이어 화면)으로 전환
                    if(_userName == _liarName)
                    {
                        //wordGuessing(ChatClient client, ClientHandler handler, string userName)
                        var wordGuessingLiarForm = new wordGuessing(_client, _clientHandler, _userName);
                        wordGuessingLiarForm.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}

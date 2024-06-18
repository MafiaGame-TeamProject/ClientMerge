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
    public partial class gameEnd : Form
    {
        bool _whoWin; //true: 시민 승리, false: 라이어 승리
        string _liarName;
        string _citizenName;
        string _realWord; // 제시어


        public gameEnd(bool whoWin, string liarName, string citizenName, string realWord)
        {
            InitializeComponent();
            _whoWin = whoWin;
            _liarName = liarName;
            _citizenName = citizenName;
            _realWord = realWord;
        }

        private void btnLobby_Click(object sender, EventArgs e)
        {
            var initForm = new Init_form();
            initForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gameEnd_Load(object sender, EventArgs e)
        {
            if (_whoWin)
            { // 시민 승리
                lableWinner.Text = "시민팀이\n승리했습니다!";
                labelUser.Text = "라이어: " + _liarName + " / 시민: " + _citizenName;
                labelWord.Text = _realWord;
            }
            else
            { // 라이어 승리
                lableWinner.Text = "라이어가\n승리했습니다!";
                labelUser.Text = "라이어: " + _liarName + " / 시민: " + _citizenName;
                labelWord.Text = "제시어: " + _realWord;
            }
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }
    }
}

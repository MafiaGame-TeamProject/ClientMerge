using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace merge_citizen
{
    public partial class wordGuessing_citizen : Form
    {
        private int remainingTime = 180; // 3분(180초)

        public wordGuessing_citizen()
        {
            InitializeComponent();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // 1초 간격
            timer1.Tick += Timer1_Tick;
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼이 로드될 때 타이머 시작
            timer1.Start();
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
                //MessageBox.Show("Time's up!");
            }
        }
    }
}

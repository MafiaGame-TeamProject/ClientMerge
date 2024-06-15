using System;
using Krypton.Toolkit;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace SuggestedWord
{
    public partial class suggestWord_form : KryptonForm
    {
        private Krypton.Toolkit.KryptonPictureBox CardPB;
        private Image cardFront;
        private Image cardBack;
        private Image SuggestedPicture;
        private bool isFlipping;
        private int flipProgress;
        private bool isFlipped;
        private int currentInterval;
        private int initialInterval = 1; // 초기 속도
        private int maxInterval = 80; // 최종 속도

        private System.Windows.Forms.Label SuggestedWordType_lbl;
        private System.Windows.Forms.Label SugestedWord_lbl;
        private System.Windows.Forms.Label Explanation_lbl;
        private System.Windows.Forms.Label Ment_lbl;
        private Krypton.Toolkit.KryptonPictureBox SuggestPB;

        System.Windows.Forms.Label[] CardLable;

        // 카드 크기 설정
        private readonly int cardWidth = 321/2; 
        private readonly int cardHeight = 512/2;

        // 카드 안 이미지 크기 설정
        private readonly int sgtWidth = 104 / 2;
        private readonly int sgtHeight = 119 / 2;

        public suggestWord_form()
        {
            InitializeComponent();
            InitializeCardFlipComponents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializeCardFlipComponents()
        {
            // 이미지 로드 (프로젝트의 실행 파일 경로에 cardFront.png와 cardBack.png가 있어야 합니다)
            cardFront = Image.FromFile("Card_front.png");
            cardBack = Image.FromFile("Card_back.png");
            SuggestedPicture = Image.FromFile("fontisto_doctor.png");

            // PictureBox 설정
            CardPB = new KryptonPictureBox
            {
                Width = cardWidth,
                Height = cardHeight,
                Image = cardFront,
                
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point((this.ClientSize.Width - cardWidth) / 2,
                                     (this.ClientSize.Height - cardHeight) / 2)
            };
            this.Controls.Add(CardPB);

            // 라벨 설정
            SuggestedWordType_lbl = new System.Windows.Forms.Label
            {
                Text = "주제 : 직업",
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(255, 209, 154),
                Location = new Point(50, 10) 
            };

            SugestedWord_lbl = new System.Windows.Forms.Label
            {
                Text = "Doctor",
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(60, 190) 
            };

            Explanation_lbl = new System.Windows.Forms.Label
            {
                Text = "당신의 제시어는 의사입니다.",
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(255, 209, 154),
                Location = new Point(15, 215),
                Font = new Font(Name, 7),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Ment_lbl = new System.Windows.Forms.Label
            {
                Text = "라이어가 누구인지 추리하세요!",
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Location = new Point(35, 230),
                Font = new Font(Name, 6),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            CardLable = new System.Windows.Forms.Label[]
            {
                SuggestedWordType_lbl,
                SugestedWord_lbl,
                Explanation_lbl,
                Ment_lbl,
            };

            SuggestPB = new KryptonPictureBox
            {
                Width = sgtWidth,
                Height = sgtHeight,
                Image = SuggestedPicture,

                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(53,85)
            };
            

            // PictureBox 위에 라벨 추가
            for (int i = 0; i < CardLable.Length; i++)
            {
                CardPB.Controls.Add(CardLable[i]);
                CardLable[i].Visible = false;
            }
            CardPB.Controls.Add(SuggestPB);
            SuggestPB.Visible = false;

            // Timer 설정
            timer = new System.Windows.Forms.Timer();
            timer.Interval = initialInterval; // 애니메이션 속도 설정
            timer.Tick += Timer_Tick;

            // PictureBox 클릭 이벤트 연결
            CardPB.Click += PictureBox_Click;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (!isFlipping && !isFlipped) // 이미 뒤집혔는지 여부를 체크
            {
                isFlipping = true;
                flipProgress = 0;
                currentInterval = initialInterval; // 초기 속도로 시작
                timer.Interval = currentInterval;
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            flipProgress += 10;
            if (flipProgress > 100)
            {
                flipProgress = 0; // 다시 시작
                isFlipping = true; // 애니메이션 계속 진행

                if (currentInterval < maxInterval)
                {
                    currentInterval += 10; // 점차 속도를 느리게 함
                    timer.Interval = currentInterval;
                }
                else
                {
                    isFlipping = false;
                    isFlipped = true; // 뒤집힘 상태로 설정
                    CardPB.Image = cardBack; // 최종적으로 뒷면을 보여줌
                    for (int i = 0; i < CardLable.Length; i++)
                    {
                        CardLable[i].Visible = true;
                    }
                    SuggestPB.Visible = true;
                    timer.Stop();
                    return;
                }
            }
            UpdateFlipAnimation();
        }

        private void UpdateFlipAnimation()
        {
            // 현재 진행률에 따라 이미지 선택 및 크기 조정
            if (flipProgress <= 50)
            {
                CardPB.Image = cardFront;
                CardPB.Width = (int)(cardWidth * (1 - (flipProgress / 50.0)));
                for (int i = 0; i < CardLable.Length; i++)
                {

                    CardLable[i].Visible = false;
                }
                SuggestPB.Visible = false;
            }
            else
            {
                CardPB.Image = cardFront;
                CardPB.Width = (int)(cardWidth * ((flipProgress - 50) / 50.0));
                for (int i = 0; i < CardLable.Length; i++)
                {

                    CardLable[i].Visible = false;
                }
                SuggestPB.Visible = false;
            }

            // PictureBox의 위치 조정
            CardPB.Left = (this.ClientSize.Width - CardPB.Width) / 2;
        }
    }
}

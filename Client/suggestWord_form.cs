using System;
using System.Drawing;
using System.Windows.Forms;
using ChatLib.Handlers;
using ChatLib.Sockets;
using Krypton.Toolkit;
using WinFormClient;

namespace SuggestedWord
{
    public partial class suggestWord_form : KryptonForm
    {
        private Krypton.Toolkit.KryptonPictureBox CardPB;
        private bool isFlipping;
        private int flipProgress;
        private bool isFlipped;
        private int currentInterval;
        private int initialInterval = 1;
        private int maxInterval = 80;

        private System.Windows.Forms.Label SuggestedWordType_lbl;
        private System.Windows.Forms.Label SugestedWord_lbl;
        private System.Windows.Forms.Label Explanation_lbl;
        private System.Windows.Forms.Label Ment_lbl;
        private Krypton.Toolkit.KryptonPictureBox SuggestPB;

        private ChatClient _client;
        private ClientHandler _clientHandler;
        private string _userName;
        private List<string> _words;
        private ChattingForm _chattingForm;

        System.Windows.Forms.Label[] CardLable;

        private readonly int cardWidth = 321 / 2;
        private readonly int cardHeight = 512 / 2;
        private readonly int sgtWidth = 104 / 2;
        private readonly int sgtHeight = 119 / 2;

        public static class ImageManager
        {
            public static Image CardFront { get; private set; }
            public static Image CardBack { get; private set; }
            public static Image SuggestedPicture { get; private set; }

            static ImageManager()
            {
                // 프로젝트 루트 디렉토리를 가져옵니다.
                string baseDirectory = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                // 상대 경로를 설정합니다.
                string relativePath = @"Resources";
                // 전체 경로를 결합합니다.
                string resourcesPath = Path.Combine(baseDirectory, relativePath);

                CardFront = Image.FromFile(Path.Combine(resourcesPath, "Card_front.png"));
                CardBack = Image.FromFile(Path.Combine(resourcesPath, "Card_back.png"));
                SuggestedPicture = Image.FromFile(Path.Combine(resourcesPath, "fontisto_doctor.png"));


            }
        }


        public suggestWord_form(ChatClient client, ClientHandler handler, string UserName, List<string> words, ChattingForm chattingForm)
        {
            InitializeComponent();
            _client = client;
            _clientHandler = handler;
            _userName = UserName;
            _words = words;
            // assignedWord : 내가 할당 받은 제시어 [4]
            // word1 : 라이어 제시어 [2]
            // word2 : 시민 제시어 [3]
            // liarName : 라이어 이름 [5]
            _chattingForm = chattingForm;
            InitializeCardFlipComponents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            globalTimer.Start();
        }

        private void InitializeCardFlipComponents()
        {
            CardPB = new KryptonPictureBox
            {
                Width = cardWidth,
                Height = cardHeight,
                Image = ImageManager.CardFront,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point((this.ClientSize.Width - cardWidth) / 2,
                                     (this.ClientSize.Height - cardHeight) / 2)
            };
            this.Controls.Add(CardPB);

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
                Text = _words[2],
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(60, 190)
            };

            Explanation_lbl = new System.Windows.Forms.Label
            {
                Text = "당신의 제시어는 " + _words[2] + "입니다.",
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
                Image = ImageManager.SuggestedPicture,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(53, 85)
            };

            for (int i = 0; i < CardLable.Length; i++)
            {
                CardPB.Controls.Add(CardLable[i]);
                CardLable[i].Visible = false;
            }
            CardPB.Controls.Add(SuggestPB);
            SuggestPB.Visible = false;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = initialInterval;
            timer.Tick += Timer_Tick;

            CardPB.Click += PictureBox_Click;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (!isFlipping && !isFlipped)
            {
                isFlipping = true;
                flipProgress = 0;
                currentInterval = initialInterval;
                timer.Interval = currentInterval;
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            flipProgress += 10;
            if (flipProgress > 100)
            {
                flipProgress = 0;
                isFlipping = true;

                if (currentInterval < maxInterval)
                {
                    currentInterval += 10;
                    timer.Interval = currentInterval;
                }
                else
                {
                    isFlipping = false;
                    isFlipped = true;
                    CardPB.Image = ImageManager.CardBack;
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
            if (flipProgress <= 50)
            {
                CardPB.Image = ImageManager.CardFront;
                CardPB.Width = (int)(cardWidth * (1 - (flipProgress / 50.0)));
                for (int i = 0; i < CardLable.Length; i++)
                {
                    CardLable[i].Visible = false;
                }
                SuggestPB.Visible = false;
            }
            else
            {
                CardPB.Image = ImageManager.CardFront;
                CardPB.Width = (int)(cardWidth * ((flipProgress - 50) / 50.0));
                for (int i = 0; i < CardLable.Length; i++)
                {
                    CardLable[i].Visible = false;
                }
                SuggestPB.Visible = false;
            }

            CardPB.Left = (this.ClientSize.Width - CardPB.Width) / 2;
        }

        private void suggestWord_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            _client.Close();
        }

        private void globalTimer_Tick(object sender, EventArgs e)
        {
            globalTimer.Stop();

            BeginInvoke((MethodInvoker)delegate
            {
                _chattingForm.Show();
                _chattingForm.setWord(_words[4]);
                this.Hide();
            });
        }
    }
}

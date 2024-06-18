using System;
using System.Collections.Generic;
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
        private List<List<Image>> images = new();

        System.Windows.Forms.Label[] CardLable;

        private readonly int cardWidth = 321;
        private readonly int cardHeight = 512;
        private readonly int sgtWidth = 104;
        private readonly int sgtHeight = 119;

        public void InitializeImages()
        {
            string baseDirectory = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
            string relativePath = @"Resources";
            string resourcesPath = Path.Combine(baseDirectory, relativePath);

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "1_apple.png")),
                Image.FromFile(Path.Combine(resourcesPath, "1_banana.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "2_baseball.png")),
                Image.FromFile(Path.Combine(resourcesPath, "2_soccer.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "3_dog.png")),
                Image.FromFile(Path.Combine(resourcesPath, "3_cat.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "4_piano.png")),
                Image.FromFile(Path.Combine(resourcesPath, "4_guitar.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "5_bicycle.png")),
                Image.FromFile(Path.Combine(resourcesPath, "5_motorcycle.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "6_carrot.png")),
                Image.FromFile(Path.Combine(resourcesPath, "6_onion.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "7_pen.png")),
                Image.FromFile(Path.Combine(resourcesPath, "7_note.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "8_doctor.png")),
                Image.FromFile(Path.Combine(resourcesPath, "8_firefighter.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "9_shirt.png")),
                Image.FromFile(Path.Combine(resourcesPath, "9_pants.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "10_hammer.png")),
                Image.FromFile(Path.Combine(resourcesPath, "10_screwdriver.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "11_train.png")),
                Image.FromFile(Path.Combine(resourcesPath, "11_ship.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "12_mouse.png")),
                Image.FromFile(Path.Combine(resourcesPath, "12_keyboard.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "13_desk.png")),
                Image.FromFile(Path.Combine(resourcesPath, "13_chair.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "14_candy.png")),
                Image.FromFile(Path.Combine(resourcesPath, "14_icecream.png"))
            });

            images.Add(new List<Image>
            {
                Image.FromFile(Path.Combine(resourcesPath, "15_tulip.png")),
                Image.FromFile(Path.Combine(resourcesPath, "15_rose.png"))
            });
        }

        public static class ImageManager
        {
            public static Image CardFront { get; private set; }
            public static Image CardBack { get; private set; }
            public static Image SuggestedPicture { get; private set; }

            static ImageManager()
            {
                string baseDirectory = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                string relativePath = @"Resources";
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
            _chattingForm = chattingForm;
            InitializeImages();
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
                Text = "주제 : " + _words[1],
                Parent = CardPB,
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(255, 209, 154),
                Location = new Point(50, 12),
                Font = new Font("휴먼둥근헤드라인", 11)
            };

            SugestedWord_lbl = new System.Windows.Forms.Label
            {
                Text = _words[4],
                Parent = CardPB,
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(105, 378),
                Font = new Font("휴먼둥근헤드라인", 11)
            };

            Explanation_lbl = new System.Windows.Forms.Label
            {
                Text = "당신의 제시어는 " + _words[4] + "입니다.",
                Parent = CardPB,
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(255, 209, 154),
                Location = new Point(25, 430),
                Font = new Font("휴먼둥근헤드라인", 7),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Ment_lbl = new System.Windows.Forms.Label
            {
                Text = "라이어가 누구인지 추리하세요!",
                Parent = CardPB,
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Location = new Point(45, 460),
                Font = new Font("휴먼둥근헤드라인", 6),
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
                Image = _userName == _words[5] ? images[Convert.ToInt32(_words[0])][0] : images[Convert.ToInt32(_words[0])][1],
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point((cardWidth - sgtWidth) / 2, ((cardHeight - sgtHeight) / 2) - 20) // 중앙에 위치
            };

            for (int i = 0; i < CardLable.Length; i++)
            {
                CardPB.Controls.Add(CardLable[i]); // CardPB에 라벨 추가
                CardLable[i].Visible = false;
            }
            CardPB.Controls.Add(SuggestPB); // CardPB에 이미지 추가
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
                        CardLable[i].BringToFront(); // 라벨을 맨 앞으로 가져옴
                        CardLable[i].Visible = true; // 라벨을 보이게 설정
                    }
                    SuggestPB.BringToFront(); // 이미지 박스를 맨 앞으로 가져옴
                    SuggestPB.Visible = true; // 이미지 박스를 보이게 설정
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
            this.Close();
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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ChatLib.Handlers;
using ChatLib.Models;
using ChatLib.Sockets;
using Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Vote
{
    public partial class Vote_form : KryptonForm
    {
        private List<CustomCheckBox> customCheckBoxes;
        private List<Label> labels;
        private PictureBox pictureBoxButton;

        private int remainingTime = 10; // 1분


        List<string> _userList = new List<string>();

        ChatClient _client;
        ClientHandler _clientHandler;
        string _userName;
        private int checkedIndex = 1;

        private string msg = "";
        

        public static class ImageManager
        {
            public static Image uncheckedImage { get; private set; }
            public static Image checkedImage { get; private set; }
            public static Image buttonImage { get; private set; }

            static ImageManager()
            {
                // 프로젝트 루트 디렉토리를 가져옵니다.
                string baseDirectory = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                // 상대 경로를 설정합니다.
                string relativePath = @"Resources";
                // 전체 경로를 결합합니다.
                string resourcesPath = Path.Combine(baseDirectory, relativePath);

                uncheckedImage = Image.FromFile(Path.Combine(resourcesPath, "unchecked.png"));
                checkedImage = Image.FromFile(Path.Combine(resourcesPath, "checked.png"));
                buttonImage = Image.FromFile(Path.Combine(resourcesPath, "voteButton.png"));
            }
        }
        public Vote_form(ChatClient client, ClientHandler handler, string userName, List<string> users)
        {
            InitializeComponent();
            _client = client;
            _clientHandler = handler;
            _userName = userName;

            for (int i = 0; i < 4; i++)
            {
                if (users[i] != _userName)
                    _userList.Add(users[i]);
            }

            InitializeCustomCheckBoxes();
            InitializeCustomButton();

            // 첫 번째 체크박스에 체크 설정
            customCheckBoxes[0].Checked = true;
            // 버튼 활성화 상태 업데이트
            UpdateButtonState();

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



        private void InitializeCustomCheckBoxes()
        {
            // 이미지 로드 (프로젝트의 실행 파일 경로에 unchecked.png와 checked.png가 있어야 합니다)


            customCheckBoxes = new List<CustomCheckBox>();
            labels = new List<Label>() { label1, label2, label3 };

            // 여러 개의 사용자 정의 체크박스 생성
            for (int i = 0; i < 3; i++)
            {

                var label = labels[i];

                label.Text = _userList[i];
                label.TextAlign = ContentAlignment.MiddleCenter;


                var customCheckBox = new CustomCheckBox(ImageManager.uncheckedImage, ImageManager.checkedImage)
                {
                    Location = new Point(label.Location.X + 330, label.Location.Y - 10),
                    Tag = i // 각 체크박스에 고유 태그 설정
                };

                customCheckBox.CheckedChanged += CustomCheckBox_CheckedChanged;
                this.Controls.Add(customCheckBox.PictureBox);
                this.Controls.Add(label);
                customCheckBoxes.Add(customCheckBox);
                labels.Add(label);


            }
        }

        private void CustomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var clickedCheckBox = sender as CustomCheckBox;
            if (clickedCheckBox.Checked)
            {
                // 다른 체크박스의 체크 상태를 해제
                foreach (var customCheckBox in customCheckBoxes)
                {
                    if (customCheckBox != clickedCheckBox)
                    {
                        customCheckBox.Checked = false;
                    }
                }

                // 체크된 체크박스의 인덱스 저장
                checkedIndex = (int)clickedCheckBox.Tag;
            }

            // 버튼 활성화 상태 업데이트
            UpdateButtonState();
        }

        private void InitializeCustomButton()
        {


            // PictureBox 설정
            pictureBoxButton = new PictureBox
            {
                Width = 388,
                Height = 84,
                Image = ImageManager.buttonImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(450, 525),
                BackColor = Color.Transparent // 투명 배경 설정
            };

            // PictureBox 클릭 이벤트 연결
            pictureBoxButton.Click += PictureBoxButton_Click;
            this.Controls.Add(pictureBoxButton);

            // 초기 상태에서 버튼 활성화 (첫 번째 체크박스가 초기 체크된 상태로 인해)
            pictureBoxButton.Enabled = true;
        }

        private void PictureBoxButton_Click(object sender, EventArgs e)
        {
            // 버튼 클릭 시 체크박스 비활성화
            foreach (var checkBox in customCheckBoxes)
            {
                checkBox.Disable();
            }

            // 버튼 클릭 시 수행
            msg = labels[checkedIndex].Text;
        }

        private void UpdateButtonState()
        {
            // 체크된 체크박스가 있는지 확인
            bool anyChecked = customCheckBoxes.Any(cb => cb.Checked);

            // 버튼 활성화 또는 비활성화
            pictureBoxButton.Enabled = anyChecked;
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
                //서버에 전송
                if (msg == "")
                    msg = labels[checkedIndex].Text;
                _clientHandler.Send(new ChatHub
                {
                    Message = "VOTED:" + msg,
                });
            }
        }

    }

    public class CustomCheckBox
    {
        public PictureBox PictureBox { get; private set; }
        public object Tag { get; set; }
        private CheckBox hiddenCheckBox;
        private Image uncheckedImage;
        private Image checkedImage;
        public event EventHandler CheckedChanged;

        private readonly int pbWidth = 68;
        private readonly int pbHeight = 70;

        public bool Checked
        {
            get => hiddenCheckBox.Checked;
            set => hiddenCheckBox.Checked = value;
        }
        public Point Location
        {
            get => PictureBox.Location;
            set
            {
                PictureBox.Location = value;
                hiddenCheckBox.Location = value; // 체크박스와 동일한 위치 설정
            }
        }

        public CustomCheckBox(Image uncheckedImage, Image checkedImage)
        {
            this.uncheckedImage = uncheckedImage;
            this.checkedImage = checkedImage;

            hiddenCheckBox = new CheckBox
            {
                Appearance = Appearance.Normal,
                AutoSize = true,
                Checked = false,
                Visible = false // 숨김
            };
            hiddenCheckBox.CheckedChanged += HiddenCheckBox_CheckedChanged;

            PictureBox = new PictureBox
            {
                Width = pbWidth,
                Height = pbHeight,
                Image = uncheckedImage,
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox.Click += PictureBox_Click;
        }

        public void Disable()
        {
            PictureBox.Enabled = false;
        }

        public void Enable()
        {
            PictureBox.Enabled = true;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // 체크된 상태에서는 클릭을 무시
            if (!hiddenCheckBox.Checked)
            {
                // CheckBox의 체크 상태를 토글
                hiddenCheckBox.Checked = !hiddenCheckBox.Checked;
            }
        }

        private void HiddenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // 체크 상태에 따라 PictureBox의 이미지 업데이트
            PictureBox.Image = hiddenCheckBox.Checked ? checkedImage : uncheckedImage;
            CheckedChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
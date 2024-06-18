namespace WinFormClient
{
    partial class wordGuessing
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wordGuessing));
            labelScreen = new Label();
            timeLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxTime = new PictureBox();
            pictureBoxSun = new PictureBox();
            btnTopic = new Krypton.Toolkit.KryptonButton();
            panelLine = new Panel();
            labelWord = new Label();
            labelTopic = new Label();
            btnSend = new Krypton.Toolkit.KryptonButton();
            panelBackground = new Krypton.Toolkit.KryptonPanel();
            Circle = new PictureBox();
            txtBox = new Krypton.Toolkit.KryptonTextBox();
            txtBackground = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelBackground).BeginInit();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Circle).BeginInit();
            SuspendLayout();
            // 
            // labelScreen
            // 
            labelScreen.AutoSize = true;
            labelScreen.BackColor = Color.Transparent;
            labelScreen.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelScreen.ForeColor = Color.White;
            labelScreen.Location = new Point(124, 34);
            labelScreen.Margin = new Padding(6, 0, 6, 0);
            labelScreen.Name = "labelScreen";
            labelScreen.Size = new Size(334, 50);
            labelScreen.TabIndex = 5;
            labelScreen.Text = "제시어 맞추기";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.BackColor = Color.Transparent;
            timeLabel.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.ForeColor = Color.White;
            timeLabel.Location = new Point(1060, 34);
            timeLabel.Margin = new Padding(6, 0, 6, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(141, 50);
            timeLabel.TabIndex = 11;
            timeLabel.Text = "1:00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // pictureBoxTime
            // 
            pictureBoxTime.BackColor = Color.Transparent;
            pictureBoxTime.Image = (Image)resources.GetObject("pictureBoxTime.Image");
            pictureBoxTime.Location = new Point(996, 34);
            pictureBoxTime.Margin = new Padding(6);
            pictureBoxTime.Name = "pictureBoxTime";
            pictureBoxTime.Size = new Size(52, 54);
            pictureBoxTime.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTime.TabIndex = 21;
            pictureBoxTime.TabStop = false;
            // 
            // pictureBoxSun
            // 
            pictureBoxSun.BackColor = Color.Transparent;
            pictureBoxSun.Image = (Image)resources.GetObject("pictureBoxSun.Image");
            pictureBoxSun.Location = new Point(60, 24);
            pictureBoxSun.Margin = new Padding(6);
            pictureBoxSun.Name = "pictureBoxSun";
            pictureBoxSun.Size = new Size(56, 70);
            pictureBoxSun.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSun.TabIndex = 20;
            pictureBoxSun.TabStop = false;
            // 
            // btnTopic
            // 
            btnTopic.Enabled = false;
            btnTopic.Location = new Point(464, 232);
            btnTopic.Margin = new Padding(6);
            btnTopic.Name = "btnTopic";
            btnTopic.OverrideDefault.Back.Color1 = Color.FromArgb(31, 28, 32);
            btnTopic.OverrideDefault.Back.Color2 = Color.FromArgb(31, 28, 32);
            btnTopic.OverrideDefault.Border.Color1 = Color.FromArgb(252, 238, 182);
            btnTopic.OverrideDefault.Border.Color2 = Color.FromArgb(252, 238, 182);
            btnTopic.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTopic.OverrideDefault.Border.Rounding = 10F;
            btnTopic.OverrideDefault.Border.Width = 1;
            btnTopic.Size = new Size(328, 90);
            btnTopic.StateCommon.Back.Color1 = Color.FromArgb(31, 28, 32);
            btnTopic.StateCommon.Back.Color2 = Color.FromArgb(31, 28, 32);
            btnTopic.StateCommon.Border.Color1 = Color.FromArgb(252, 238, 182);
            btnTopic.StateCommon.Border.Color2 = Color.FromArgb(252, 238, 182);
            btnTopic.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTopic.StateCommon.Border.Rounding = 10F;
            btnTopic.StateCommon.Border.Width = 1;
            btnTopic.TabIndex = 25;
            btnTopic.Values.Text = "";
            // 
            // panelLine
            // 
            panelLine.BackColor = Color.FromArgb(252, 238, 182);
            panelLine.Location = new Point(618, 244);
            panelLine.Margin = new Padding(6);
            panelLine.Name = "panelLine";
            panelLine.Size = new Size(2, 60);
            panelLine.TabIndex = 26;
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.BackColor = Color.FromArgb(31, 28, 32);
            labelWord.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelWord.ForeColor = Color.White;
            labelWord.Location = new Point(642, 248);
            labelWord.Margin = new Padding(6, 0, 6, 0);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(118, 50);
            labelWord.TabIndex = 12;
            labelWord.Text = "직업";
            // 
            // labelTopic
            // 
            labelTopic.AutoSize = true;
            labelTopic.BackColor = Color.FromArgb(31, 28, 32);
            labelTopic.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTopic.ForeColor = Color.White;
            labelTopic.Location = new Point(476, 248);
            labelTopic.Margin = new Padding(6, 0, 6, 0);
            labelTopic.Name = "labelTopic";
            labelTopic.Size = new Size(118, 50);
            labelTopic.TabIndex = 11;
            labelTopic.Text = "주제";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(780, 74);
            btnSend.Margin = new Padding(6);
            btnSend.Name = "btnSend";
            btnSend.OverrideDefault.Back.Color1 = Color.FromArgb(31, 28, 32);
            btnSend.OverrideDefault.Back.Color2 = Color.FromArgb(31, 28, 32);
            btnSend.OverrideDefault.Border.Color1 = Color.FromArgb(252, 238, 182);
            btnSend.OverrideDefault.Border.Color2 = Color.FromArgb(252, 238, 182);
            btnSend.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSend.OverrideDefault.Border.Rounding = 10F;
            btnSend.OverrideDefault.Border.Width = 1;
            btnSend.Size = new Size(210, 76);
            btnSend.StateCommon.Back.Color1 = Color.FromArgb(31, 28, 32);
            btnSend.StateCommon.Back.Color2 = Color.FromArgb(31, 28, 32);
            btnSend.StateCommon.Border.Color1 = Color.FromArgb(252, 238, 182);
            btnSend.StateCommon.Border.Color2 = Color.FromArgb(252, 238, 182);
            btnSend.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSend.StateCommon.Border.Rounding = 10F;
            btnSend.StateCommon.Border.Width = 1;
            btnSend.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSend.StateCommon.Content.ShortText.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.TabIndex = 29;
            btnSend.Values.Text = "Send";
            btnSend.Click += btnSend_Click;
            // 
            // panelBackground
            // 
            panelBackground.Controls.Add(Circle);
            panelBackground.Controls.Add(btnSend);
            panelBackground.Controls.Add(txtBox);
            panelBackground.Controls.Add(txtBackground);
            panelBackground.Location = new Point(152, 270);
            panelBackground.Margin = new Padding(6);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(1028, 216);
            panelBackground.StateCommon.Color1 = Color.FromArgb(24, 21, 24);
            panelBackground.TabIndex = 30;
            // 
            // Circle
            // 
            Circle.BackColor = Color.Transparent;
            Circle.Image = (Image)resources.GetObject("Circle.Image");
            Circle.Location = new Point(976, 100);
            Circle.Margin = new Padding(6);
            Circle.Name = "Circle";
            Circle.Size = new Size(20, 20);
            Circle.SizeMode = PictureBoxSizeMode.StretchImage;
            Circle.TabIndex = 31;
            Circle.TabStop = false;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(32, 70);
            txtBox.Margin = new Padding(6);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(732, 69);
            txtBox.StateCommon.Back.Color1 = Color.FromArgb(31, 28, 32);
            txtBox.StateCommon.Border.Color1 = Color.FromArgb(252, 238, 182);
            txtBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBox.StateCommon.Border.Rounding = 10F;
            txtBox.StateCommon.Border.Width = 1;
            txtBox.StateCommon.Content.Color1 = Color.White;
            txtBox.StateCommon.Content.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox.TabIndex = 31;
            // 
            // txtBackground
            // 
            txtBackground.Enabled = false;
            txtBackground.Location = new Point(10, 34);
            txtBackground.Margin = new Padding(6);
            txtBackground.Name = "txtBackground";
            txtBackground.Size = new Size(1004, 149);
            txtBackground.StateCommon.Back.Color1 = Color.FromArgb(24, 21, 24);
            txtBackground.StateCommon.Border.Color1 = Color.FromArgb(252, 238, 182);
            txtBackground.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBackground.StateCommon.Border.Rounding = 10F;
            txtBackground.StateCommon.Border.Width = 1;
            txtBackground.StateCommon.Content.Color1 = Color.White;
            txtBackground.StateCommon.Content.Font = new Font("휴먼둥근헤드라인", 44.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBackground.TabIndex = 32;
            // 
            // wordGuessing
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1280, 720);
            Controls.Add(labelWord);
            Controls.Add(labelTopic);
            Controls.Add(panelLine);
            Controls.Add(btnTopic);
            Controls.Add(pictureBoxTime);
            Controls.Add(pictureBoxSun);
            Controls.Add(timeLabel);
            Controls.Add(labelScreen);
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6);
            Name = "wordGuessing";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LiarGame";
            Load += wordGuessing_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSun).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelBackground).EndInit();
            panelBackground.ResumeLayout(false);
            panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Circle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelScreen;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxTime;
        private System.Windows.Forms.PictureBox pictureBoxSun;
        private Krypton.Toolkit.KryptonButton btnTopic;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Label labelTopic;
        private Krypton.Toolkit.KryptonButton btnSend;
        private Krypton.Toolkit.KryptonPanel panelBackground;
        private Krypton.Toolkit.KryptonTextBox txtBox;
        private Krypton.Toolkit.KryptonTextBox txtBackground;
        private System.Windows.Forms.PictureBox Circle;
    }
}


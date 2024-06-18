namespace WinFormClient
{
    partial class wordGuessing_citizen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wordGuessing_citizen));
            labelScreen = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxSun = new PictureBox();
            labelGuide = new Label();
            pictureBoxDie = new PictureBox();
            panel1 = new Panel();
            labelWord = new Label();
            pictureBoxLine = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDie).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLine).BeginInit();
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
            labelScreen.TabIndex = 12;
            labelScreen.Text = "제시어 맞추기";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // pictureBoxSun
            // 
            pictureBoxSun.BackColor = Color.Transparent;
            pictureBoxSun.Image = (Image)resources.GetObject("pictureBoxSun.Image");
            pictureBoxSun.Location = new Point(60, 24);
            pictureBoxSun.Margin = new Padding(6, 6, 6, 6);
            pictureBoxSun.Name = "pictureBoxSun";
            pictureBoxSun.Size = new Size(56, 70);
            pictureBoxSun.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSun.TabIndex = 22;
            pictureBoxSun.TabStop = false;
            // 
            // labelGuide
            // 
            labelGuide.AutoSize = true;
            labelGuide.BackColor = Color.FromArgb(15, 17, 24);
            labelGuide.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelGuide.ForeColor = Color.White;
            labelGuide.Location = new Point(342, 260);
            labelGuide.Margin = new Padding(6, 0, 6, 0);
            labelGuide.Name = "labelGuide";
            labelGuide.Size = new Size(643, 50);
            labelGuide.TabIndex = 24;
            labelGuide.Text = "라이어가 선택한 제시어는...";
            // 
            // pictureBoxDie
            // 
            pictureBoxDie.BackColor = Color.FromArgb(15, 17, 24);
            pictureBoxDie.Image = (Image)resources.GetObject("pictureBoxDie.Image");
            pictureBoxDie.Location = new Point(216, 222);
            pictureBoxDie.Margin = new Padding(6, 6, 6, 6);
            pictureBoxDie.Name = "pictureBoxDie";
            pictureBoxDie.Size = new Size(854, 114);
            pictureBoxDie.TabIndex = 26;
            pictureBoxDie.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 17, 24);
            panel1.Controls.Add(labelWord);
            panel1.Controls.Add(pictureBoxLine);
            panel1.Location = new Point(216, 316);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 224);
            panel1.TabIndex = 25;
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.BackColor = Color.Transparent;
            labelWord.Font = new Font("휴먼둥근헤드라인", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWord.ForeColor = Color.White;
            labelWord.Location = new Point(208, 66);
            labelWord.Margin = new Padding(6, 0, 6, 0);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(433, 78);
            labelWord.TabIndex = 18;
            labelWord.Text = "의사입니다!";
            // 
            // pictureBoxLine
            // 
            pictureBoxLine.BackColor = Color.FromArgb(15, 17, 24);
            pictureBoxLine.Image = (Image)resources.GetObject("pictureBoxLine.Image");
            pictureBoxLine.Location = new Point(0, 150);
            pictureBoxLine.Margin = new Padding(6, 6, 6, 6);
            pictureBoxLine.Name = "pictureBoxLine";
            pictureBoxLine.Size = new Size(854, 74);
            pictureBoxLine.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLine.TabIndex = 18;
            pictureBoxLine.TabStop = false;
            // 
            // wordGuessing_citizen
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1280, 720);
            Controls.Add(labelGuide);
            Controls.Add(pictureBoxDie);
            Controls.Add(panel1);
            Controls.Add(pictureBoxSun);
            Controls.Add(labelScreen);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 6, 6, 6);
            Name = "wordGuessing_citizen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "citizen";
            Load += wordGuessing_citizen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSun).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDie).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelScreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxSun;
        private Label labelGuide;
        private PictureBox pictureBoxDie;
        private Panel panel1;
        private Label labelWord;
        private PictureBox pictureBoxLine;
    }
}
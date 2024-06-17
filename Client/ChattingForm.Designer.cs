namespace WinFormClient
{
    partial class ChattingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChattingForm));
            plainTextLbl = new Label();
            wordLbl = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtInput = new TextBox();
            sendBtn = new Button();
            chatPanel = new FlowLayoutPanel();
            pictureBoxSun = new PictureBox();
            pictureBoxTime = new PictureBox();
            timeLbl = new Label();
            gTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTime).BeginInit();
            SuspendLayout();
            // 
            // plainTextLbl
            // 
            plainTextLbl.AutoSize = true;
            plainTextLbl.BackColor = Color.Transparent;
            plainTextLbl.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            plainTextLbl.ForeColor = Color.White;
            plainTextLbl.Location = new Point(57, 19);
            plainTextLbl.Name = "plainTextLbl";
            plainTextLbl.Size = new Size(73, 25);
            plainTextLbl.TabIndex = 1;
            plainTextLbl.Text = "제시어:";
            // 
            // wordLbl
            // 
            wordLbl.AutoSize = true;
            wordLbl.BackColor = Color.Transparent;
            wordLbl.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            wordLbl.ForeColor = Color.White;
            wordLbl.Location = new Point(136, 19);
            wordLbl.Name = "wordLbl";
            wordLbl.Size = new Size(50, 25);
            wordLbl.TabIndex = 2;
            wordLbl.Text = "의사";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1069, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1117, 46);
            label1.Name = "label1";
            label1.Size = new Size(110, 50);
            label1.TabIndex = 4;
            label1.Text = "03:00";
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.FromArgb(88, 79, 79);
            txtInput.Font = new Font("맑은 고딕", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.ForeColor = Color.White;
            txtInput.Location = new Point(50, 304);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(536, 43);
            txtInput.TabIndex = 5;
            // 
            // sendBtn
            // 
            sendBtn.BackColor = Color.FromArgb(88, 79, 79);
            sendBtn.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sendBtn.ForeColor = Color.White;
            sendBtn.Location = new Point(506, 312);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(78, 28);
            sendBtn.TabIndex = 6;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = false;
            sendBtn.Click += sendBtn_Click;
            // 
            // chatPanel
            // 
            chatPanel.AutoScroll = true;
            chatPanel.BackColor = Color.Transparent;
            chatPanel.Location = new Point(23, 59);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new Size(592, 230);
            chatPanel.TabIndex = 7;
            // 
            // pictureBoxSun
            // 
            pictureBoxSun.BackColor = Color.Transparent;
            pictureBoxSun.Image = (Image)resources.GetObject("pictureBoxSun.Image");
            pictureBoxSun.Location = new Point(23, 15);
            pictureBoxSun.Name = "pictureBoxSun";
            pictureBoxSun.Size = new Size(28, 35);
            pictureBoxSun.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSun.TabIndex = 21;
            pictureBoxSun.TabStop = false;
            // 
            // pictureBoxTime
            // 
            pictureBoxTime.BackColor = Color.Transparent;
            pictureBoxTime.Image = (Image)resources.GetObject("pictureBoxTime.Image");
            pictureBoxTime.Location = new Point(527, 20);
            pictureBoxTime.Name = "pictureBoxTime";
            pictureBoxTime.Size = new Size(26, 27);
            pictureBoxTime.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTime.TabIndex = 22;
            pictureBoxTime.TabStop = false;
            // 
            // timeLbl
            // 
            timeLbl.AutoSize = true;
            timeLbl.BackColor = Color.Transparent;
            timeLbl.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            timeLbl.ForeColor = Color.White;
            timeLbl.Location = new Point(559, 20);
            timeLbl.Name = "timeLbl";
            timeLbl.Size = new Size(56, 25);
            timeLbl.TabIndex = 23;
            timeLbl.Text = "03:00";
            // 
            // gTimer
            // 
            gTimer.Interval = 1000;
            gTimer.Tick += UItimer_Tick;
            // 
            // ChattingForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(637, 360);
            Controls.Add(timeLbl);
            Controls.Add(pictureBoxTime);
            Controls.Add(pictureBoxSun);
            Controls.Add(chatPanel);
            Controls.Add(sendBtn);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(wordLbl);
            Controls.Add(plainTextLbl);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChattingForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSun).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label plainTextLbl;
        private Label wordLbl;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtInput;
        private Button sendBtn;
        private FlowLayoutPanel chatPanel;
        private PictureBox pictureBoxSun;
        private PictureBox pictureBoxTime;
        private Label timeLbl;
        private System.Windows.Forms.Timer gTimer;
    }
}

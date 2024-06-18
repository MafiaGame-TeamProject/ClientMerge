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
            timeLbl = new Label();
            pictureBoxTime = new PictureBox();
            gTimer = new System.Windows.Forms.Timer(components);
            pictureBoxSun = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSun).BeginInit();
            SuspendLayout();
            // 
            // plainTextLbl
            // 
            plainTextLbl.AutoSize = true;
            plainTextLbl.BackColor = Color.Transparent;
            plainTextLbl.Font = new Font("휴먼둥근헤드라인", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            plainTextLbl.ForeColor = Color.White;
            plainTextLbl.Location = new Point(116, 40);
            plainTextLbl.Margin = new Padding(6, 0, 6, 0);
            plainTextLbl.Name = "plainTextLbl";
            plainTextLbl.Size = new Size(141, 39);
            plainTextLbl.TabIndex = 1;
            plainTextLbl.Text = "제시어:";
            // 
            // wordLbl
            // 
            wordLbl.AutoSize = true;
            wordLbl.BackColor = Color.Transparent;
            wordLbl.Font = new Font("휴먼둥근헤드라인", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            wordLbl.ForeColor = Color.White;
            wordLbl.Location = new Point(248, 40);
            wordLbl.Margin = new Padding(6, 0, 6, 0);
            wordLbl.Name = "wordLbl";
            wordLbl.Size = new Size(0, 39);
            wordLbl.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2138, 92);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 100);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2234, 92);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 99);
            label1.TabIndex = 4;
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.FromArgb(88, 79, 79);
            txtInput.Font = new Font("맑은 고딕", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.ForeColor = Color.White;
            txtInput.Location = new Point(104, 608);
            txtInput.Margin = new Padding(6);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(1070, 78);
            txtInput.TabIndex = 5;
            // 
            // sendBtn
            // 
            sendBtn.BackColor = Color.FromArgb(88, 79, 79);
            sendBtn.Font = new Font("휴먼둥근헤드라인", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sendBtn.ForeColor = Color.White;
            sendBtn.Location = new Point(1010, 619);
            sendBtn.Margin = new Padding(6);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(156, 56);
            sendBtn.TabIndex = 6;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = false;
            sendBtn.Click += sendBtn_Click;
            // 
            // chatPanel
            // 
            chatPanel.AutoScroll = true;
            chatPanel.BackColor = Color.Transparent;
            chatPanel.Location = new Point(48, 118);
            chatPanel.Margin = new Padding(6);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new Size(1184, 460);
            chatPanel.TabIndex = 7;
            // 
            // timeLbl
            // 
            timeLbl.AutoSize = true;
            timeLbl.BackColor = Color.Transparent;
            timeLbl.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            timeLbl.ForeColor = Color.White;
            timeLbl.Location = new Point(1104, 40);
            timeLbl.Margin = new Padding(4, 0, 4, 0);
            timeLbl.Name = "timeLbl";
            timeLbl.Size = new Size(0, 42);
            timeLbl.TabIndex = 23;
            // 
            // pictureBoxTime
            // 
            pictureBoxTime.BackColor = Color.Transparent;
            pictureBoxTime.Image = (Image)resources.GetObject("pictureBoxTime.Image");
            pictureBoxTime.Location = new Point(1042, 30);
            pictureBoxTime.Margin = new Padding(6);
            pictureBoxTime.Name = "pictureBoxTime";
            pictureBoxTime.Size = new Size(52, 54);
            pictureBoxTime.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTime.TabIndex = 24;
            pictureBoxTime.TabStop = false;
            // 
            // gTimer
            // 
            gTimer.Interval = 1000;
            gTimer.Tick += UItimer_Tick;
            // 
            // pictureBoxSun
            // 
            pictureBoxSun.BackColor = Color.Transparent;
            pictureBoxSun.Image = (Image)resources.GetObject("pictureBoxSun.Image");
            pictureBoxSun.Location = new Point(48, 30);
            pictureBoxSun.Margin = new Padding(6);
            pictureBoxSun.Name = "pictureBoxSun";
            pictureBoxSun.Size = new Size(56, 70);
            pictureBoxSun.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSun.TabIndex = 25;
            pictureBoxSun.TabStop = false;
            // 
            // ChattingForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1280, 720);
            Controls.Add(pictureBoxSun);
            Controls.Add(plainTextLbl);
            Controls.Add(timeLbl);
            Controls.Add(pictureBoxTime);
            Controls.Add(chatPanel);
            Controls.Add(sendBtn);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(wordLbl);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6);
            Name = "ChattingForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MafiaGame";
            Load += ChattingForm_Load;
            KeyDown += ChattingForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSun).EndInit();
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
        private Label timeLbl;
        private PictureBox pictureBoxTime;
        private System.Windows.Forms.Timer gTimer;
        private PictureBox pictureBoxSun;
    }
}

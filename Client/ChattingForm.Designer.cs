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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChattingForm));
            pictureBox1 = new PictureBox();
            plainTextLbl = new Label();
            wordLbl = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtInput = new TextBox();
            sendBtn = new Button();
            chatPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 65);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // plainTextLbl
            // 
            plainTextLbl.AutoSize = true;
            plainTextLbl.BackColor = Color.Transparent;
            plainTextLbl.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point);
            plainTextLbl.ForeColor = Color.White;
            plainTextLbl.Location = new Point(124, 33);
            plainTextLbl.Name = "plainTextLbl";
            plainTextLbl.Size = new Size(183, 65);
            plainTextLbl.TabIndex = 1;
            plainTextLbl.Text = "제시어:";
            // 
            // wordLbl
            // 
            wordLbl.AutoSize = true;
            wordLbl.BackColor = Color.Transparent;
            wordLbl.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point);
            wordLbl.ForeColor = Color.White;
            wordLbl.Location = new Point(297, 33);
            wordLbl.Name = "wordLbl";
            wordLbl.Size = new Size(124, 65);
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
            txtInput.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.ForeColor = Color.White;
            txtInput.Location = new Point(124, 607);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(1045, 71);
            txtInput.TabIndex = 5;
            // 
            // sendBtn
            // 
            sendBtn.BackColor = Color.FromArgb(88, 79, 79);
            sendBtn.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            sendBtn.ForeColor = Color.White;
            sendBtn.Location = new Point(1069, 617);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(89, 49);
            sendBtn.TabIndex = 6;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = false;
            sendBtn.Click += sendBtn_Click;
            // 
            // chatPanel
            // 
            chatPanel.AutoScroll = true;
            chatPanel.BackColor = Color.Transparent;
            chatPanel.Location = new Point(37, 104);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new Size(1200, 486);
            chatPanel.TabIndex = 7;
            // 
            // ChattingForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1280, 720);
            Controls.Add(chatPanel);
            Controls.Add(sendBtn);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(wordLbl);
            Controls.Add(plainTextLbl);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ChattingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label plainTextLbl;
        private Label wordLbl;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtInput;
        private Button sendBtn;
        private FlowLayoutPanel chatPanel;
    }
}

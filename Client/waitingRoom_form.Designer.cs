namespace WaitingRoom
{
    partial class waitingRoom_form
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
            UsersView = new Krypton.Toolkit.KryptonPictureBox();
            Room_lbl = new Label();
            name1_lbl = new Label();
            name2_lbl = new Label();
            name3_lbl = new Label();
            name4_lbl = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)UsersView).BeginInit();
            SuspendLayout();
            // 
            // UsersView
            // 
            UsersView.Image = WinFormClient.Properties.Resources.Group_152__2_;
            UsersView.Location = new Point(0, 40);
            UsersView.Margin = new Padding(2);
            UsersView.Name = "UsersView";
            UsersView.Size = new Size(800, 376);
            UsersView.SizeMode = PictureBoxSizeMode.Zoom;
            UsersView.TabIndex = 1;
            UsersView.TabStop = false;
            // 
            // Room_lbl
            // 
            Room_lbl.AutoSize = true;
            Room_lbl.BackColor = Color.Transparent;
            Room_lbl.Font = new Font("굴림", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Room_lbl.ForeColor = SystemColors.ButtonFace;
            Room_lbl.Location = new Point(327, 47);
            Room_lbl.Margin = new Padding(2, 0, 2, 0);
            Room_lbl.Name = "Room_lbl";
            Room_lbl.Size = new Size(149, 40);
            Room_lbl.TabIndex = 2;
            Room_lbl.Text = "Room1";
            // 
            // name1_lbl
            // 
            name1_lbl.AutoSize = true;
            name1_lbl.BackColor = Color.Transparent;
            name1_lbl.Font = new Font("굴림", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            name1_lbl.Location = new Point(341, 104);
            name1_lbl.Margin = new Padding(2, 0, 2, 0);
            name1_lbl.Name = "name1_lbl";
            name1_lbl.Size = new Size(81, 27);
            name1_lbl.TabIndex = 3;
            name1_lbl.Text = "name";
            // 
            // name2_lbl
            // 
            name2_lbl.AutoSize = true;
            name2_lbl.BackColor = Color.Transparent;
            name2_lbl.Font = new Font("굴림", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            name2_lbl.Location = new Point(341, 165);
            name2_lbl.Margin = new Padding(2, 0, 2, 0);
            name2_lbl.Name = "name2_lbl";
            name2_lbl.Size = new Size(81, 27);
            name2_lbl.TabIndex = 4;
            name2_lbl.Text = "name";
            // 
            // name3_lbl
            // 
            name3_lbl.AutoSize = true;
            name3_lbl.BackColor = Color.Transparent;
            name3_lbl.Font = new Font("굴림", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            name3_lbl.Location = new Point(341, 225);
            name3_lbl.Margin = new Padding(2, 0, 2, 0);
            name3_lbl.Name = "name3_lbl";
            name3_lbl.Size = new Size(81, 27);
            name3_lbl.TabIndex = 5;
            name3_lbl.Text = "name";
            // 
            // name4_lbl
            // 
            name4_lbl.AutoSize = true;
            name4_lbl.BackColor = Color.Transparent;
            name4_lbl.Font = new Font("굴림", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            name4_lbl.Location = new Point(341, 286);
            name4_lbl.Margin = new Padding(2, 0, 2, 0);
            name4_lbl.Name = "name4_lbl";
            name4_lbl.Size = new Size(81, 27);
            name4_lbl.TabIndex = 6;
            name4_lbl.Text = "name";
            // 
            // button1
            // 
            button1.ForeColor = Color.White;
            button1.Image = WinFormClient.Properties.Resources.startButton;
            button1.Location = new Point(326, 361);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(144, 32);
            button1.TabIndex = 14;
            button1.Text = "유저 4/4";
            button1.UseVisualStyleBackColor = true;
            // 
            // waitingRoom_form
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = WinFormClient.Properties.Resources.배경사진;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(name4_lbl);
            Controls.Add(name3_lbl);
            Controls.Add(name2_lbl);
            Controls.Add(name1_lbl);
            Controls.Add(Room_lbl);
            Controls.Add(UsersView);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "waitingRoom_form";
            Padding = new Padding(2, 40, 2, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)UsersView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox UsersView;
        private System.Windows.Forms.Label Room_lbl;
        private System.Windows.Forms.Label name1_lbl;
        private System.Windows.Forms.Label name2_lbl;
        private System.Windows.Forms.Label name3_lbl;
        private System.Windows.Forms.Label name4_lbl;
        private System.Windows.Forms.Button button1;
    }
}


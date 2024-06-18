namespace WinFormClient
{
    partial class voteResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(voteResult));
            labelDie = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            labelJob = new Label();
            pictureBoxLine = new PictureBox();
            pictureBoxDie = new PictureBox();
            pictureBoxSun = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSun).BeginInit();
            SuspendLayout();
            // 
            // labelDie
            // 
            labelDie.AutoSize = true;
            labelDie.BackColor = Color.FromArgb(15, 17, 24);
            labelDie.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelDie.ForeColor = Color.White;
            labelDie.Location = new Point(158, 130);
            labelDie.Name = "labelDie";
            labelDie.Size = new Size(330, 25);
            labelDie.TabIndex = 2;
            labelDie.Text = "user1님이 처형당했습니다.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(62, 17);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 12;
            label4.Text = "처형자 공개";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 17, 24);
            panel1.Controls.Add(labelJob);
            panel1.Controls.Add(pictureBoxLine);
            panel1.Location = new Point(108, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 112);
            panel1.TabIndex = 16;
            // 
            // labelJob
            // 
            labelJob.AutoSize = true;
            labelJob.BackColor = Color.Transparent;
            labelJob.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelJob.ForeColor = Color.White;
            labelJob.Location = new Point(147, 22);
            labelJob.Name = "labelJob";
            labelJob.Size = new Size(143, 50);
            labelJob.TabIndex = 18;
            labelJob.Text = "User1님은\r\n시민입니다.";
            // 
            // pictureBoxLine
            // 
            pictureBoxLine.BackColor = Color.FromArgb(15, 17, 24);
            pictureBoxLine.Image = (Image)resources.GetObject("pictureBoxLine.Image");
            pictureBoxLine.Location = new Point(0, 75);
            pictureBoxLine.Name = "pictureBoxLine";
            pictureBoxLine.Size = new Size(427, 37);
            pictureBoxLine.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLine.TabIndex = 18;
            pictureBoxLine.TabStop = false;
            // 
            // pictureBoxDie
            // 
            pictureBoxDie.BackColor = Color.FromArgb(15, 17, 24);
            pictureBoxDie.Image = (Image)resources.GetObject("pictureBoxDie.Image");
            pictureBoxDie.Location = new Point(108, 118);
            pictureBoxDie.Name = "pictureBoxDie";
            pictureBoxDie.Size = new Size(427, 50);
            pictureBoxDie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDie.TabIndex = 17;
            pictureBoxDie.TabStop = false;
            // 
            // pictureBoxSun
            // 
            pictureBoxSun.BackColor = Color.Transparent;
            pictureBoxSun.Image = (Image)resources.GetObject("pictureBoxSun.Image");
            pictureBoxSun.Location = new Point(30, 12);
            pictureBoxSun.Name = "pictureBoxSun";
            pictureBoxSun.Size = new Size(28, 35);
            pictureBoxSun.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSun.TabIndex = 18;
            pictureBoxSun.TabStop = false;
            // 
            // voteResult
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(640, 360);
            Controls.Add(pictureBoxSun);
            Controls.Add(labelDie);
            Controls.Add(label4);
            Controls.Add(pictureBoxDie);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "voteResult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "voteResult";
            Load += voteResult_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDie).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelDie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxDie;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.PictureBox pictureBoxSun;
    }
}


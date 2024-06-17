namespace WinFormClient
{
    partial class OtherChat
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherChat));
            otherLbl = new Label();
            pictureBox1 = new PictureBox();
            userLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // otherLbl
            // 
            otherLbl.BackColor = Color.FromArgb(88, 79, 79);
            otherLbl.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            otherLbl.ForeColor = Color.White;
            otherLbl.Location = new Point(39, 15);
            otherLbl.Name = "otherLbl";
            otherLbl.Size = new Size(240, 23);
            otherLbl.TabIndex = 8;
            otherLbl.Text = "label";
            otherLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Font = new Font("맑은 고딕", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            userLbl.ForeColor = Color.White;
            userLbl.Location = new Point(-3, 0);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(36, 13);
            userLbl.TabIndex = 10;
            userLbl.Text = "User1";
            // 
            // OtherChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(userLbl);
            Controls.Add(pictureBox1);
            Controls.Add(otherLbl);
            Name = "OtherChat";
            Size = new Size(592, 38);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label otherLbl;
        private PictureBox pictureBox1;
        private Label userLbl;
    }
}

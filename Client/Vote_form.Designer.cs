﻿namespace Vote
{
    partial class Vote_form
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
            timer1 = new System.Windows.Forms.Timer(components);
            timeLabel = new Label();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.BackColor = Color.Transparent;
            timeLabel.Font = new Font("휴먼둥근헤드라인", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.ForeColor = Color.White;
            timeLabel.Location = new Point(1079, 45);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(108, 39);
            timeLabel.TabIndex = 1;
            timeLabel.Text = "3:00";
            // 
            // Vote_form
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = WinFormClient.Properties.Resources.VoteBackground;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1274, 719);
            Controls.Add(timeLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Vote_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
    }
}

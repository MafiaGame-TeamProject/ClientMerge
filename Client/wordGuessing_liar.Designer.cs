namespace 제시어맞추기_라이어화면_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            labelScreen.BackColor = Color.Transparent;
            labelScreen.ForeColor = Color.White;
            labelScreen.Location = new Point(0, 0);
            labelScreen.Name = "labelScreen";
            labelScreen.Size = new Size(100, 23);
            labelScreen.TabIndex = 7;
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.Transparent;
            timeLabel.ForeColor = Color.White;
            timeLabel.Location = new Point(0, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(100, 23);
            timeLabel.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // pictureBoxTime
            // 
            pictureBoxTime.BackColor = Color.Transparent;
            pictureBoxTime.Image = (Image)resources.GetObject("pictureBoxTime.Image");
            pictureBoxTime.Location = new Point(0, 0);
            pictureBoxTime.Name = "pictureBoxTime";
            pictureBoxTime.Size = new Size(100, 50);
            pictureBoxTime.TabIndex = 4;
            pictureBoxTime.TabStop = false;
            // 
            // pictureBoxSun
            // 
            pictureBoxSun.BackColor = Color.Transparent;
            pictureBoxSun.Image = (Image)resources.GetObject("pictureBoxSun.Image");
            pictureBoxSun.Location = new Point(0, 0);
            pictureBoxSun.Name = "pictureBoxSun";
            pictureBoxSun.Size = new Size(100, 50);
            pictureBoxSun.TabIndex = 5;
            pictureBoxSun.TabStop = false;
            // 
            // btnTopic
            // 
            btnTopic.Location = new Point(0, 0);
            btnTopic.Name = "btnTopic";
            btnTopic.OverrideDefault.Back.Color1 = Color.FromArgb(31, 28, 32);
            btnTopic.OverrideDefault.Back.Color2 = Color.FromArgb(31, 28, 32);
            btnTopic.OverrideDefault.Border.Color1 = Color.FromArgb(252, 238, 182);
            btnTopic.OverrideDefault.Border.Color2 = Color.FromArgb(252, 238, 182);
            btnTopic.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTopic.OverrideDefault.Border.Rounding = 10F;
            btnTopic.OverrideDefault.Border.Width = 1;
            btnTopic.Size = new Size(90, 25);
            btnTopic.StateCommon.Back.Color1 = Color.FromArgb(31, 28, 32);
            btnTopic.StateCommon.Back.Color2 = Color.FromArgb(31, 28, 32);
            btnTopic.StateCommon.Border.Color1 = Color.FromArgb(252, 238, 182);
            btnTopic.StateCommon.Border.Color2 = Color.FromArgb(252, 238, 182);
            btnTopic.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTopic.StateCommon.Border.Rounding = 10F;
            btnTopic.StateCommon.Border.Width = 1;
            btnTopic.TabIndex = 3;
            btnTopic.Values.Text = "";
            // 
            // panelLine
            // 
            panelLine.BackColor = Color.FromArgb(252, 238, 182);
            panelLine.Location = new Point(0, 0);
            panelLine.Name = "panelLine";
            panelLine.Size = new Size(200, 100);
            panelLine.TabIndex = 2;
            // 
            // labelWord
            // 
            labelWord.BackColor = Color.FromArgb(31, 28, 32);
            labelWord.ForeColor = Color.White;
            labelWord.Location = new Point(0, 0);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(100, 23);
            labelWord.TabIndex = 0;
            // 
            // labelTopic
            // 
            labelTopic.BackColor = Color.FromArgb(31, 28, 32);
            labelTopic.ForeColor = Color.White;
            labelTopic.Location = new Point(0, 0);
            labelTopic.Name = "labelTopic";
            labelTopic.Size = new Size(100, 23);
            labelTopic.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(0, 0);
            btnSend.Name = "btnSend";
            btnSend.OverrideDefault.Back.Color1 = Color.FromArgb(31, 28, 32);
            btnSend.OverrideDefault.Back.Color2 = Color.FromArgb(31, 28, 32);
            btnSend.OverrideDefault.Border.Color1 = Color.FromArgb(252, 238, 182);
            btnSend.OverrideDefault.Border.Color2 = Color.FromArgb(252, 238, 182);
            btnSend.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSend.OverrideDefault.Border.Rounding = 10F;
            btnSend.OverrideDefault.Border.Width = 1;
            btnSend.Size = new Size(90, 25);
            btnSend.StateCommon.Back.Color1 = Color.FromArgb(31, 28, 32);
            btnSend.StateCommon.Back.Color2 = Color.FromArgb(31, 28, 32);
            btnSend.StateCommon.Border.Color1 = Color.FromArgb(252, 238, 182);
            btnSend.StateCommon.Border.Color2 = Color.FromArgb(252, 238, 182);
            btnSend.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSend.StateCommon.Border.Rounding = 10F;
            btnSend.StateCommon.Border.Width = 1;
            btnSend.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSend.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.TabIndex = 1;
            btnSend.Values.Text = "";
            // 
            // panelBackground
            // 
            panelBackground.Controls.Add(Circle);
            panelBackground.Controls.Add(btnSend);
            panelBackground.Controls.Add(txtBox);
            panelBackground.Controls.Add(txtBackground);
            panelBackground.Location = new Point(0, 0);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(100, 100);
            panelBackground.StateCommon.Color1 = Color.FromArgb(24, 21, 24);
            panelBackground.TabIndex = 8;
            // 
            // Circle
            // 
            Circle.BackColor = Color.Transparent;
            Circle.Image = (Image)resources.GetObject("Circle.Image");
            Circle.Location = new Point(0, 0);
            Circle.Name = "Circle";
            Circle.Size = new Size(100, 50);
            Circle.TabIndex = 0;
            Circle.TabStop = false;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(0, 0);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(100, 41);
            txtBox.StateCommon.Back.Color1 = Color.FromArgb(31, 28, 32);
            txtBox.StateCommon.Border.Color1 = Color.FromArgb(252, 238, 182);
            txtBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBox.StateCommon.Border.Rounding = 10F;
            txtBox.StateCommon.Border.Width = 1;
            txtBox.StateCommon.Content.Color1 = Color.White;
            txtBox.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox.TabIndex = 2;
            // 
            // txtBackground
            // 
            txtBackground.Location = new Point(0, 0);
            txtBackground.Name = "txtBackground";
            txtBackground.Size = new Size(100, 80);
            txtBackground.StateCommon.Back.Color1 = Color.FromArgb(24, 21, 24);
            txtBackground.StateCommon.Border.Color1 = Color.FromArgb(252, 238, 182);
            txtBackground.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBackground.StateCommon.Border.Rounding = 10F;
            txtBackground.StateCommon.Border.Width = 1;
            txtBackground.StateCommon.Content.Color1 = Color.White;
            txtBackground.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 44.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBackground.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(350, 190);
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
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSun).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelBackground).EndInit();
            panelBackground.ResumeLayout(false);
            panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Circle).EndInit();
            ResumeLayout(false);
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


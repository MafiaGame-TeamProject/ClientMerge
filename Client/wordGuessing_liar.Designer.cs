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
            resources.ApplyResources(labelScreen, "labelScreen");
            labelScreen.BackColor = Color.Transparent;
            labelScreen.ForeColor = Color.White;
            labelScreen.Name = "labelScreen";
            // 
            // timeLabel
            // 
            resources.ApplyResources(timeLabel, "timeLabel");
            timeLabel.BackColor = Color.Transparent;
            timeLabel.ForeColor = Color.White;
            timeLabel.Name = "timeLabel";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // pictureBoxTime
            // 
            pictureBoxTime.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBoxTime, "pictureBoxTime");
            pictureBoxTime.Name = "pictureBoxTime";
            pictureBoxTime.TabStop = false;
            // 
            // pictureBoxSun
            // 
            pictureBoxSun.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBoxSun, "pictureBoxSun");
            pictureBoxSun.Name = "pictureBoxSun";
            pictureBoxSun.TabStop = false;
            // 
            // btnTopic
            // 
            resources.ApplyResources(btnTopic, "btnTopic");
            btnTopic.Name = "btnTopic";
            btnTopic.OverrideDefault.Back.Color1 = Color.FromArgb(31, 28, 32);
            btnTopic.OverrideDefault.Back.Color2 = Color.FromArgb(31, 28, 32);
            btnTopic.OverrideDefault.Border.Color1 = Color.FromArgb(252, 238, 182);
            btnTopic.OverrideDefault.Border.Color2 = Color.FromArgb(252, 238, 182);
            btnTopic.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTopic.OverrideDefault.Border.Rounding = 10F;
            btnTopic.OverrideDefault.Border.Width = 1;
            btnTopic.StateCommon.Back.Color1 = Color.FromArgb(31, 28, 32);
            btnTopic.StateCommon.Back.Color2 = Color.FromArgb(31, 28, 32);
            btnTopic.StateCommon.Border.Color1 = Color.FromArgb(252, 238, 182);
            btnTopic.StateCommon.Border.Color2 = Color.FromArgb(252, 238, 182);
            btnTopic.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTopic.StateCommon.Border.Rounding = 10F;
            btnTopic.StateCommon.Border.Width = 1;
            btnTopic.Values.Text = resources.GetString("btnTopic.Values.Text");
            // 
            // panelLine
            // 
            panelLine.BackColor = Color.FromArgb(252, 238, 182);
            resources.ApplyResources(panelLine, "panelLine");
            panelLine.Name = "panelLine";
            // 
            // labelWord
            // 
            resources.ApplyResources(labelWord, "labelWord");
            labelWord.BackColor = Color.FromArgb(31, 28, 32);
            labelWord.ForeColor = Color.White;
            labelWord.Name = "labelWord";
            // 
            // labelTopic
            // 
            resources.ApplyResources(labelTopic, "labelTopic");
            labelTopic.BackColor = Color.FromArgb(31, 28, 32);
            labelTopic.ForeColor = Color.White;
            labelTopic.Name = "labelTopic";
            // 
            // btnSend
            // 
            resources.ApplyResources(btnSend, "btnSend");
            btnSend.Name = "btnSend";
            btnSend.OverrideDefault.Back.Color1 = Color.FromArgb(31, 28, 32);
            btnSend.OverrideDefault.Back.Color2 = Color.FromArgb(31, 28, 32);
            btnSend.OverrideDefault.Border.Color1 = Color.FromArgb(252, 238, 182);
            btnSend.OverrideDefault.Border.Color2 = Color.FromArgb(252, 238, 182);
            btnSend.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSend.OverrideDefault.Border.Rounding = 10F;
            btnSend.OverrideDefault.Border.Width = 1;
            btnSend.StateCommon.Back.Color1 = Color.FromArgb(31, 28, 32);
            btnSend.StateCommon.Back.Color2 = Color.FromArgb(31, 28, 32);
            btnSend.StateCommon.Border.Color1 = Color.FromArgb(252, 238, 182);
            btnSend.StateCommon.Border.Color2 = Color.FromArgb(252, 238, 182);
            btnSend.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSend.StateCommon.Border.Rounding = 10F;
            btnSend.StateCommon.Border.Width = 1;
            btnSend.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSend.StateCommon.Content.ShortText.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.Values.Text = resources.GetString("btnSend.Values.Text");
            // 
            // panelBackground
            // 
            panelBackground.Controls.Add(Circle);
            panelBackground.Controls.Add(btnSend);
            panelBackground.Controls.Add(txtBox);
            panelBackground.Controls.Add(txtBackground);
            resources.ApplyResources(panelBackground, "panelBackground");
            panelBackground.Name = "panelBackground";
            panelBackground.StateCommon.Color1 = Color.FromArgb(24, 21, 24);
            // 
            // Circle
            // 
            Circle.BackColor = Color.Transparent;
            resources.ApplyResources(Circle, "Circle");
            Circle.Name = "Circle";
            Circle.TabStop = false;
            // 
            // txtBox
            // 
            resources.ApplyResources(txtBox, "txtBox");
            txtBox.Name = "txtBox";
            txtBox.StateCommon.Back.Color1 = Color.FromArgb(31, 28, 32);
            txtBox.StateCommon.Border.Color1 = Color.FromArgb(252, 238, 182);
            txtBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBox.StateCommon.Border.Rounding = 10F;
            txtBox.StateCommon.Border.Width = 1;
            txtBox.StateCommon.Content.Color1 = Color.White;
            txtBox.StateCommon.Content.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // txtBackground
            // 
            resources.ApplyResources(txtBackground, "txtBackground");
            txtBackground.Name = "txtBackground";
            txtBackground.StateCommon.Back.Color1 = Color.FromArgb(24, 21, 24);
            txtBackground.StateCommon.Border.Color1 = Color.FromArgb(252, 238, 182);
            txtBackground.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBackground.StateCommon.Border.Rounding = 10F;
            txtBackground.StateCommon.Border.Width = 1;
            txtBackground.StateCommon.Content.Color1 = Color.White;
            txtBackground.StateCommon.Content.Font = new Font("휴먼둥근헤드라인", 44.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
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


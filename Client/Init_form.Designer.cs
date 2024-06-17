namespace WinFormClient
{
  partial class Init_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Init_form));
            txtName = new TextBox();
            label2 = new Label();
            label4 = new Label();
            btnStop = new Button();
            btnConnect = new Button();
            nudRoomId = new NumericUpDown();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudRoomId).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.WindowText;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("굴림", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.Transparent;
            txtName.Location = new Point(226, 103);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "User Name";
            txtName.Size = new Size(210, 31);
            txtName.TabIndex = 34;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("굴림", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(126, 103);
            label2.Name = "label2";
            label2.Size = new Size(84, 27);
            label2.TabIndex = 33;
            label2.Text = "Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("굴림", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(126, 45);
            label4.Name = "label4";
            label4.Size = new Size(85, 27);
            label4.TabIndex = 31;
            label4.Text = "Room";
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Black;
            btnStop.FlatAppearance.BorderColor = Color.FromArgb(226, 222, 211);
            btnStop.FlatAppearance.BorderSize = 3;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.ForeColor = Color.FromArgb(226, 222, 211);
            btnStop.Location = new Point(192, 255);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(160, 38);
            btnStop.TabIndex = 30;
            btnStop.Text = "종료";
            btnStop.UseVisualStyleBackColor = false;
            // 
            // btnConnect
            // 
            btnConnect.FlatAppearance.BorderColor = Color.FromArgb(226, 222, 211);
            btnConnect.FlatAppearance.BorderSize = 3;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnConnect.ForeColor = Color.FromArgb(226, 222, 211);
            btnConnect.Location = new Point(192, 166);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(160, 38);
            btnConnect.TabIndex = 29;
            btnConnect.Text = "대기실 입장";
            btnConnect.UseVisualStyleBackColor = true;
            // 
            // nudRoomId
            // 
            nudRoomId.BackColor = SystemColors.WindowText;
            nudRoomId.Font = new Font("굴림", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            nudRoomId.ForeColor = Color.White;
            nudRoomId.Location = new Point(226, 41);
            nudRoomId.Name = "nudRoomId";
            nudRoomId.Size = new Size(105, 38);
            nudRoomId.TabIndex = 36;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(nudRoomId);
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(btnConnect);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(48, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 312);
            panel1.TabIndex = 37;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(226, 222, 211);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(226, 222, 211);
            button1.Location = new Point(192, 211);
            button1.Name = "button1";
            button1.Size = new Size(160, 38);
            button1.TabIndex = 37;
            button1.Text = "순위보기";
            button1.UseVisualStyleBackColor = true;
            // 
            // Init_form
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(640, 360);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Init_form";
            Padding = new Padding(2, 32, 2, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "z";
            ((System.ComponentModel.ISupportInitialize)nudRoomId).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtName;
    private Label label2;
    private Label label4;
    private Button btnStop;
    private Button btnConnect;
    private NumericUpDown nudRoomId;
        private Panel panel1;
        private Button button1;
    }
}
namespace WinFormClient
{
    partial class gameEnd
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
            lableWinner = new Label();
            labelUser = new Label();
            labelWord = new Label();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            btnLobby = new Krypton.Toolkit.KryptonButton();
            btnExit = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // lableWinner
            // 
            lableWinner.AutoSize = true;
            lableWinner.Font = new Font("휴먼둥근헤드라인", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lableWinner.ForeColor = Color.White;
            lableWinner.Location = new Point(408, 58);
            lableWinner.Margin = new Padding(6, 0, 6, 0);
            lableWinner.Name = "lableWinner";
            lableWinner.Size = new Size(480, 146);
            lableWinner.TabIndex = 0;
            lableWinner.Text = "시민팀이 \r\n승리했습니다!";
            lableWinner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.ForeColor = Color.White;
            labelUser.Location = new Point(74, 231);
            labelUser.Margin = new Padding(6, 0, 6, 0);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(1161, 50);
            labelUser.TabIndex = 1;
            labelUser.Text = "라이어: User1 / 시민: User2, User3, User4";
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelWord.ForeColor = Color.White;
            labelWord.Location = new Point(490, 312);
            labelWord.Margin = new Padding(6, 0, 6, 0);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(303, 50);
            labelWord.TabIndex = 2;
            labelWord.Text = "제시어: 의사";
            // 
            // kryptonButton4
            // 
            kryptonButton4.CornerRoundingRadius = 5F;
            kryptonButton4.Enabled = false;
            kryptonButton4.Location = new Point(420, 536);
            kryptonButton4.Margin = new Padding(6);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.Size = new Size(440, 110);
            kryptonButton4.StateCommon.Back.Color1 = Color.FromArgb(10, 10, 14);
            kryptonButton4.StateCommon.Back.Color2 = Color.FromArgb(10, 10, 14);
            kryptonButton4.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButton4.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButton4.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton4.StateCommon.Border.Rounding = 5F;
            kryptonButton4.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton4.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton4.StateCommon.Content.ShortText.Font = new Font("휴먼둥근헤드라인", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton4.TabIndex = 16;
            kryptonButton4.Values.Text = "";
            // 
            // kryptonButton6
            // 
            kryptonButton6.CornerRoundingRadius = 5F;
            kryptonButton6.Enabled = false;
            kryptonButton6.Location = new Point(420, 404);
            kryptonButton6.Margin = new Padding(6);
            kryptonButton6.Name = "kryptonButton6";
            kryptonButton6.Size = new Size(440, 110);
            kryptonButton6.StateCommon.Back.Color1 = Color.FromArgb(10, 10, 14);
            kryptonButton6.StateCommon.Back.Color2 = Color.FromArgb(10, 10, 14);
            kryptonButton6.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButton6.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButton6.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton6.StateCommon.Border.Rounding = 5F;
            kryptonButton6.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton6.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton6.StateCommon.Content.ShortText.Font = new Font("휴먼둥근헤드라인", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton6.TabIndex = 18;
            kryptonButton6.Values.Text = "";
            // 
            // btnLobby
            // 
            btnLobby.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            btnLobby.Location = new Point(432, 412);
            btnLobby.Margin = new Padding(6);
            btnLobby.Name = "btnLobby";
            btnLobby.OverrideDefault.Back.Color1 = Color.FromArgb(10, 10, 14);
            btnLobby.OverrideDefault.Back.Color2 = Color.FromArgb(10, 10, 14);
            btnLobby.OverrideDefault.Border.Color1 = Color.DimGray;
            btnLobby.OverrideDefault.Border.Color2 = Color.DimGray;
            btnLobby.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLobby.OverrideFocus.Border.Color1 = Color.White;
            btnLobby.OverrideFocus.Border.Color2 = Color.White;
            btnLobby.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLobby.OverrideFocus.Border.Rounding = 5F;
            btnLobby.OverrideFocus.Border.Width = 2;
            btnLobby.Size = new Size(418, 90);
            btnLobby.StateCommon.Back.Color1 = Color.FromArgb(10, 10, 14);
            btnLobby.StateCommon.Back.Color2 = Color.FromArgb(10, 10, 14);
            btnLobby.StateCommon.Border.Color1 = Color.DimGray;
            btnLobby.StateCommon.Border.Color2 = Color.DimGray;
            btnLobby.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLobby.StateCommon.Border.Rounding = 5F;
            btnLobby.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLobby.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLobby.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLobby.StateCommon.Content.ShortText.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLobby.TabIndex = 22;
            btnLobby.Values.Text = "로비로 돌아가기";
            btnLobby.Click += btnLobby_Click;
            // 
            // btnExit
            // 
            btnExit.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            btnExit.Location = new Point(432, 546);
            btnExit.Margin = new Padding(6);
            btnExit.Name = "btnExit";
            btnExit.OverrideDefault.Back.Color1 = Color.FromArgb(10, 10, 14);
            btnExit.OverrideDefault.Back.Color2 = Color.FromArgb(10, 10, 14);
            btnExit.OverrideDefault.Border.Color1 = Color.DimGray;
            btnExit.OverrideDefault.Border.Color2 = Color.DimGray;
            btnExit.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExit.OverrideFocus.Border.Color1 = Color.White;
            btnExit.OverrideFocus.Border.Color2 = Color.White;
            btnExit.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExit.OverrideFocus.Border.Rounding = 5F;
            btnExit.OverrideFocus.Border.Width = 2;
            btnExit.Size = new Size(418, 90);
            btnExit.StateCommon.Back.Color1 = Color.FromArgb(10, 10, 14);
            btnExit.StateCommon.Back.Color2 = Color.FromArgb(10, 10, 14);
            btnExit.StateCommon.Border.Color1 = Color.DimGray;
            btnExit.StateCommon.Border.Color2 = Color.DimGray;
            btnExit.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExit.StateCommon.Border.Rounding = 5F;
            btnExit.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExit.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExit.StateCommon.Content.ShortText.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.TabIndex = 24;
            btnExit.Values.Text = "종료하기";
            btnExit.Click += btnExit_Click;
            // 
            // gameEnd
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(25, 23, 39);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1280, 720);
            Controls.Add(btnExit);
            Controls.Add(labelWord);
            Controls.Add(labelUser);
            Controls.Add(lableWinner);
            Controls.Add(btnLobby);
            Controls.Add(kryptonButton6);
            Controls.Add(kryptonButton4);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6);
            Name = "gameEnd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MafiaGame";
            Load += gameEnd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lableWinner;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelWord;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private Krypton.Toolkit.KryptonButton btnLobby;
        private Krypton.Toolkit.KryptonButton btnExit;
    }
}


namespace CaroChill_13_03.GUI
{
    partial class frmStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTheRules = new Button();
            btnQuitGame = new Button();
            btn1Player = new Button();
            btn2Player = new Button();
            lblCaroChill = new Label();
            lbl1Player = new Label();
            lbl2Player = new Label();
            SuspendLayout();
            // 
            // btnTheRules
            // 
            btnTheRules.BackColor = Color.LightBlue;
            btnTheRules.Font = new Font("Showcard Gothic", 14F);
            btnTheRules.Location = new Point(457, 144);
            btnTheRules.Name = "btnTheRules";
            btnTheRules.Size = new Size(198, 52);
            btnTheRules.TabIndex = 2;
            btnTheRules.Text = "LUẬT CHƠI";
            btnTheRules.UseVisualStyleBackColor = false;
            btnTheRules.Click += btnTheRules_Click;
            // 
            // btnQuitGame
            // 
            btnQuitGame.BackColor = Color.LightBlue;
            btnQuitGame.Font = new Font("Showcard Gothic", 14F);
            btnQuitGame.Location = new Point(457, 224);
            btnQuitGame.Name = "btnQuitGame";
            btnQuitGame.Size = new Size(198, 48);
            btnQuitGame.TabIndex = 3;
            btnQuitGame.Text = "THOÁT";
            btnQuitGame.UseVisualStyleBackColor = false;
            btnQuitGame.Click += btnQuitGame_Click;
            // 
            // btn1Player
            // 
            btn1Player.BackgroundImage = Properties.Resources._1Player;
            btn1Player.BackgroundImageLayout = ImageLayout.Stretch;
            btn1Player.Location = new Point(47, 144);
            btn1Player.Name = "btn1Player";
            btn1Player.Size = new Size(131, 179);
            btn1Player.TabIndex = 0;
            btn1Player.UseVisualStyleBackColor = true;
            btn1Player.Click += btn1Player_Click;
            // 
            // btn2Player
            // 
            btn2Player.BackgroundImage = Properties.Resources._2Player;
            btn2Player.BackgroundImageLayout = ImageLayout.Stretch;
            btn2Player.Location = new Point(224, 144);
            btn2Player.Name = "btn2Player";
            btn2Player.Size = new Size(128, 179);
            btn2Player.TabIndex = 1;
            btn2Player.UseVisualStyleBackColor = true;
            btn2Player.Click += btn2Player_Click;
            // 
            // lblCaroChill
            // 
            lblCaroChill.AutoSize = true;
            lblCaroChill.BackColor = Color.Transparent;
            lblCaroChill.Font = new Font("Showcard Gothic", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCaroChill.ForeColor = Color.LightBlue;
            lblCaroChill.Location = new Point(-8, 9);
            lblCaroChill.Name = "lblCaroChill";
            lblCaroChill.Size = new Size(350, 68);
            lblCaroChill.TabIndex = 4;
            lblCaroChill.Text = "CARO CHILL";
            // 
            // lbl1Player
            // 
            lbl1Player.AutoSize = true;
            lbl1Player.BackColor = Color.Transparent;
            lbl1Player.Font = new Font("Showcard Gothic", 9F);
            lbl1Player.ForeColor = Color.LightBlue;
            lbl1Player.Location = new Point(51, 346);
            lbl1Player.Name = "lbl1Player";
            lbl1Player.Size = new Size(127, 23);
            lbl1Player.TabIndex = 5;
            lbl1Player.Text = "1 NGƯỜI CHƠI";
            // 
            // lbl2Player
            // 
            lbl2Player.AutoSize = true;
            lbl2Player.BackColor = Color.Transparent;
            lbl2Player.Font = new Font("Showcard Gothic", 9F);
            lbl2Player.ForeColor = Color.LightBlue;
            lbl2Player.Location = new Point(224, 346);
            lbl2Player.Name = "lbl2Player";
            lbl2Player.Size = new Size(128, 23);
            lbl2Player.TabIndex = 6;
            lbl2Player.Text = "2 NGƯỜI CHƠI\r\n";
            // 
            // frmStart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(722, 411);
            Controls.Add(lbl2Player);
            Controls.Add(lbl1Player);
            Controls.Add(lblCaroChill);
            Controls.Add(btn2Player);
            Controls.Add(btn1Player);
            Controls.Add(btnQuitGame);
            Controls.Add(btnTheRules);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTheRules;
        private Button btnQuitGame;
        private Button btn1Player;
        private Button btn2Player;
        private Label lblCaroChill;
        private Label lbl1Player;
        private Label lbl2Player;
    }
}
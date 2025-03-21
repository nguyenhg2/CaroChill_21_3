namespace CaroChill_13_03.GUI
{
    partial class frmChessBoard
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
            menuStrip1 = new MenuStrip();
            càiĐặtToolStripMenuItem = new ToolStripMenuItem();
            pnlChessBoard = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labChatBox = new Label();
            ptbavt1 = new PictureBox();
            ptbavt2 = new PictureBox();
            labname1 = new Label();
            labname2 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbavt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbavt2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { càiĐặtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1578, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // càiĐặtToolStripMenuItem
            // 
            càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            càiĐặtToolStripMenuItem.Size = new Size(83, 29);
            càiĐặtToolStripMenuItem.Text = "Cài đặt";
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Location = new Point(361, 31);
            pnlChessBoard.Margin = new Padding(4);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(821, 795);
            pnlChessBoard.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1232, 528);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 228);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1232, 784);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 42);
            textBox2.TabIndex = 5;
            // 
            // labChatBox
            // 
            labChatBox.AutoSize = true;
            labChatBox.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labChatBox.Location = new Point(1301, 458);
            labChatBox.Margin = new Padding(4, 0, 4, 0);
            labChatBox.Name = "labChatBox";
            labChatBox.Size = new Size(188, 43);
            labChatBox.TabIndex = 6;
            labChatBox.Text = "CHAT BOX";
            // 
            // ptbavt1
            // 
            ptbavt1.BackgroundImage = Properties.Resources._1Player;
            ptbavt1.BackgroundImageLayout = ImageLayout.Stretch;
            ptbavt1.Location = new Point(62, 95);
            ptbavt1.Margin = new Padding(4);
            ptbavt1.Name = "ptbavt1";
            ptbavt1.Size = new Size(184, 190);
            ptbavt1.TabIndex = 7;
            ptbavt1.TabStop = false;
            // 
            // ptbavt2
            // 
            ptbavt2.BackgroundImage = Properties.Resources._2Player;
            ptbavt2.BackgroundImageLayout = ImageLayout.Stretch;
            ptbavt2.Location = new Point(1301, 95);
            ptbavt2.Margin = new Padding(4);
            ptbavt2.Name = "ptbavt2";
            ptbavt2.Size = new Size(184, 190);
            ptbavt2.TabIndex = 8;
            ptbavt2.TabStop = false;
            // 
            // labname1
            // 
            labname1.AutoSize = true;
            labname1.Location = new Point(62, 320);
            labname1.Margin = new Padding(4, 0, 4, 0);
            labname1.Name = "labname1";
            labname1.Size = new Size(59, 25);
            labname1.TabIndex = 9;
            labname1.Text = "label1";
            // 
            // labname2
            // 
            labname2.AutoSize = true;
            labname2.Location = new Point(1301, 320);
            labname2.Margin = new Padding(4, 0, 4, 0);
            labname2.Name = "labname2";
            labname2.Size = new Size(59, 25);
            labname2.TabIndex = 10;
            labname2.Text = "label1";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Red;
            progressBar1.Cursor = Cursors.AppStarting;
            progressBar1.ForeColor = SystemColors.MenuHighlight;
            progressBar1.Location = new Point(64, 372);
            progressBar1.Margin = new Padding(4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(182, 36);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 11;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(1301, 372);
            progressBar2.Margin = new Padding(4);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(184, 36);
            progressBar2.Style = ProgressBarStyle.Continuous;
            progressBar2.TabIndex = 12;
            // 
            // frmChessBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 841);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(labname2);
            Controls.Add(labname1);
            Controls.Add(ptbavt2);
            Controls.Add(ptbavt1);
            Controls.Add(labChatBox);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pnlChessBoard);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmChessBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChessBoard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbavt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbavt2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem càiĐặtToolStripMenuItem;
        private Panel pnlChessBoard;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labChatBox;
        private PictureBox ptbavt1;
        private PictureBox ptbavt2;
        private Label labname1;
        private Label labname2;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
    }
}
namespace WinFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblMines;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlGame;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            oyunToolStripMenuItem = new ToolStripMenuItem();
            yeniOyunToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            cikisToolStripMenuItem = new ToolStripMenuItem();
            pnlTop = new Panel();
            lblMines = new Label();
            btnReset = new Button();
            pnlGame = new Panel();

            menuStrip1.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();

            // menuStrip1
            menuStrip1.Items.AddRange(new ToolStripItem[] { oyunToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(370, 24);
            menuStrip1.TabIndex = 0;

            // oyunToolStripMenuItem
            oyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                yeniOyunToolStripMenuItem,
                toolStripSeparator1,
                cikisToolStripMenuItem
            });
            oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            oyunToolStripMenuItem.Size = new Size(48, 20);
            oyunToolStripMenuItem.Text = "Oyun";

            // yeniOyunToolStripMenuItem
            yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            yeniOyunToolStripMenuItem.Size = new Size(128, 22);
            yeniOyunToolStripMenuItem.Text = "Yeni Oyun";
            yeniOyunToolStripMenuItem.Click += yeniOyunToolStripMenuItem_Click;

            // toolStripSeparator1
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(125, 6);

            // cikisToolStripMenuItem
            cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            cikisToolStripMenuItem.Size = new Size(128, 22);
            cikisToolStripMenuItem.Text = "Çıkış";
            cikisToolStripMenuItem.Click += cikisToolStripMenuItem_Click;

            // pnlTop
            pnlTop.BackColor = Color.LightGray;
            pnlTop.BorderStyle = BorderStyle.FixedSingle;
            pnlTop.Controls.Add(lblMines);
            pnlTop.Controls.Add(btnReset);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 24);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(370, 45);
            pnlTop.TabIndex = 1;

            // lblMines
            lblMines.AutoSize = true;
            lblMines.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblMines.ForeColor = Color.DarkRed;
            lblMines.Location = new Point(12, 12);
            lblMines.Name = "lblMines";
            lblMines.Size = new Size(74, 20);
            lblMines.TabIndex = 0;
            lblMines.Text = "Mayın: 10";

            // btnReset
            btnReset.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(160, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(40, 35);
            btnReset.TabIndex = 1;
            btnReset.Text = "😊";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;

            // pnlGame
            pnlGame.BackColor = Color.Gray;
            pnlGame.BorderStyle = BorderStyle.FixedSingle;
            pnlGame.Location = new Point(10, 75);
            pnlGame.Name = "pnlGame";
            pnlGame.Size = new Size(350, 350);
            pnlGame.TabIndex = 2;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 435);
            Controls.Add(pnlGame);
            Controls.Add(pnlTop);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mayın Tarlası Oyunu";

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private const int Rows = 10;
        private const int Cols = 10;
        private const int TotalMines = 10;
        private const int CellSize = 35;

        private Cell[,] grid = new Cell[Rows, Cols];
        private bool isGameOver = false;
        private int flagsPlaced = 0;
        private int revealedCount = 0;

        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            isGameOver = false;
            flagsPlaced = 0;
            revealedCount = 0;
            btnReset.Text = "😊";

            pnlGame.Controls.Clear();
            pnlGame.Size = new Size(Cols * CellSize, Rows * CellSize);
            this.ClientSize = new Size(Cols * CellSize + 20, Rows * CellSize + pnlTop.Height + menuStrip1.Height + 20);

            UpdateMineLabel();
            CreateGrid();
            PlaceMines();
            CalculateAdjacentMines();
        }

        private void CreateGrid()
        {
            pnlGame.SuspendLayout();

            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(CellSize, CellSize);
                    btn.Location = new Point(c * CellSize, r * CellSize);
                    btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    btn.Tag = new Point(r, c);

                    btn.MouseDown += Cell_MouseDown;

                    pnlGame.Controls.Add(btn);
                    grid[r, c] = new Cell(r, c, btn);
                }
            }

            pnlGame.ResumeLayout();
        }

        private void PlaceMines()
        {
            Random rand = new Random();
            int placed = 0;

            while (placed < TotalMines)
            {
                int r = rand.Next(Rows);
                int c = rand.Next(Cols);

                if (!grid[r, c].IsMine)
                {
                    grid[r, c].IsMine = true;
                    placed++;
                }
            }
        }

        private void CalculateAdjacentMines()
        {
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                {
                    if (grid[r, c].IsMine) continue;

                    int count = 0;

                    for (int dr = -1; dr <= 1; dr++)
                    {
                        for (int dc = -1; dc <= 1; dc++)
                        {
                            int nr = r + dr;
                            int nc = c + dc;

                            if (nr >= 0 && nr < Rows && nc >= 0 && nc < Cols)
                            {
                                if (grid[nr, nc].IsMine)
                                {
                                    count++;
                                }
                            }
                        }
                    }

                    grid[r, c].AdjacentMines = count;
                }
            }
        }

        private void Cell_MouseDown(object? sender, MouseEventArgs e)
        {
            if (isGameOver) return;

            if (sender is not Button btn || btn.Tag is not Point pt) return;

            int r = pt.X;
            int c = pt.Y;
            Cell cell = grid[r, c];

            if (e.Button == MouseButtons.Left)
            {
                if (cell.IsFlagged || cell.IsRevealed) return;

                if (cell.IsMine)
                {
                    GameOver(cell);
                }
                else
                {
                    OpenCell(r, c);
                    CheckWin();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (cell.IsRevealed) return;

                cell.IsFlagged = !cell.IsFlagged;

                if (cell.IsFlagged)
                {
                    cell.Button.Text = "🚩";
                    cell.Button.ForeColor = Color.Red;
                    flagsPlaced++;
                }
                else
                {
                    cell.Button.Text = "";
                    flagsPlaced--;
                }

                UpdateMineLabel();
            }
        }

        private void OpenCell(int r, int c)
        {
            if (r < 0 || r >= Rows || c < 0 || c >= Cols) return;

            Cell cell = grid[r, c];

            if (cell.IsRevealed || cell.IsFlagged || cell.IsMine) return;

            cell.IsRevealed = true;
            revealedCount++;

            cell.Button.Enabled = false;
            cell.Button.BackColor = Color.LightGray;

            if (cell.AdjacentMines > 0)
            {
                cell.Button.Text = cell.AdjacentMines.ToString();
                cell.Button.ForeColor = GetNumberColor(cell.AdjacentMines);
            }
            else
            {
                cell.Button.Text = "";

                for (int dr = -1; dr <= 1; dr++)
                {
                    for (int dc = -1; dc <= 1; dc++)
                    {
                        if (dr != 0 || dc != 0)
                        {
                            OpenCell(r + dr, c + dc);
                        }
                    }
                }
            }
        }

        private Color GetNumberColor(int number)
        {
            if (number == 1) return Color.Blue;
            if (number == 2) return Color.Green;
            if (number == 3) return Color.Red;
            if (number == 4) return Color.DarkBlue;
            if (number == 5) return Color.DarkRed;
            return Color.Black;
        }

        private void UpdateMineLabel()
        {
            int kalan = TotalMines - flagsPlaced;
            lblMines.Text = "Kalan Mayın: " + kalan;
        }

        private void GameOver(Cell hitCell)
        {
            isGameOver = true;
            btnReset.Text = "😵";

            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                {
                    if (grid[r, c].IsMine)
                    {
                        grid[r, c].Button.Text = "💣";
                        grid[r, c].Button.BackColor = Color.Red;
                    }
                }
            }

            MessageBox.Show("Mayına bastınız! Oyun bitti.", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CheckWin()
        {
            int safeCells = (Rows * Cols) - TotalMines;

            if (revealedCount == safeCells)
            {
                isGameOver = true;
                btnReset.Text = "😎";
                MessageBox.Show("Tebrikler! Tüm güvenli kareleri açtınız ve oyunu kazandınız! 🎉", "Tebrikler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            StartGame();
        }

        private void yeniOyunToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            StartGame();
        }

        private void cikisToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

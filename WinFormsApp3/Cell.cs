using System.Windows.Forms;

namespace WinFormsApp3
{
    public class Cell
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public bool IsMine { get; set; }
        public bool IsRevealed { get; set; }
        public bool IsFlagged { get; set; }
        public int AdjacentMines { get; set; }
        public Button Button { get; set; }

        public Cell(int row, int col, Button button)
        {
            Row = row;
            Col = col;
            Button = button;
            IsMine = false;
            IsRevealed = false;
            IsFlagged = false;
            AdjacentMines = 0;
        }
    }
}

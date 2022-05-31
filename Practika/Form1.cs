namespace Practika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private const int _cellSize = 30;
        private const int _headerSize = 25;

        private void changeCellCount(DataGridView grid, int rowCount, int columnCount)
        {
            grid.RowCount = rowCount;
            grid.ColumnCount = columnCount;
            grid.RowHeadersVisible = true;
            grid.RowHeadersWidth = _headerSize;
            grid.ColumnHeadersHeight = _headerSize;

            calcCellSize(rowCount, columnCount, grid.Size, out int cellSizeW, out int cellSizeH);

            for (int i = 0; i < columnCount; i++)
            {
                var column = grid.Columns[i];
                column.Name = $"{i}";
                column.Width = cellSizeW;
                column.HeaderCell.Style.BackColor = Color.Aqua;
                column.ValueType = typeof(int);
            }


            for (int j = 0; j < rowCount; j++)
            {
                var row = grid.Rows[j];
                row.Height = cellSizeH;
                row.HeaderCell.Value = $"{j}";
                row.HeaderCell.Style.BackColor = Color.Aqua;
            }
        }


        private void changeCellSize(DataGridView grid)
        {
            int rowCount = grid.RowCount;
            int columnCount = grid.ColumnCount;

            calcCellSize(rowCount, columnCount, grid.Size, out int cellSizeW, out int cellSizeH);

            for (int i = 0; i < columnCount; i++)
            {
                var column = grid.Columns[i];
                column.Width = cellSizeW;
            }

            for (int j = 0; j < rowCount; j++)
            {
                var row = grid.Rows[j];
                row.Height = cellSizeH;
            }
        }

        private static void calcCellSize(int rowCount, int columnCount, Size gridSize, out int cellSizeW, out int cellSizeH)
        {
            cellSizeW = _cellSize;
            cellSizeH = _cellSize;
            double gridW = gridSize.Width - _headerSize - columnCount - 1;
            double gridH = gridSize.Height - _headerSize - rowCount - 1;

            cellSizeW = (int)(gridW / columnCount);
            cellSizeH = (int)(gridH / rowCount);

            cellSizeW = cellSizeW < _cellSize ? _cellSize : cellSizeW;
            cellSizeH = cellSizeH < _cellSize ? _cellSize : cellSizeH;
        }


        private void resultsToTable(DataGridView output, int[,] source)
        {
            int rLng = source.GetLength(0);
            int cLng = source.GetLength(1);
            output.RowCount = rLng;
            output.ColumnCount = cLng;
            for (int i = 0; i < rLng; i++)
            {
                for (int k = 0; k < cLng; k++)
                {
                    output.Rows[i].Cells[k].Value = source[i, k];
                }
            }
        }

        private int[,] readFromGrid(DataGridView input)
        {
            int rLng = input.Rows.Count;
            int cLng = input.Columns.Count;
            var res = new int[rLng, cLng];
            for (int i = 0; i < rLng; i++)

            {
                for (int k = 0; k < cLng; k++)
                {
                    string vTxt = input.Rows[i].Cells[k].Value?.ToString();
                    int value = int.Parse(vTxt);
                    res[i, k] = value;
                }
            }

            return res;
        }

        public class DR
        {
            public int X { get; set; }

            public int Y { get; set; }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            int[,] source = this.readFromGrid(this.GridInput);
            Calculations.sorting (source);
            Calculations.zeroing (source);
            resultsToTable(GridOut, source);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n= (int) this.numericUpDown1.Value;
            changeCellCount(this.GridInput, n * 2);
            changeCellCount(this.GridOut, n * 2);
        }

        private void GridInput_Resize(object sender, EventArgs e)
        {
            changeCellSize(this.GridInput);
        }

        private void GridOut_Resize(object sender, EventArgs e)
        {
            changeCellSize(this.GridOut);
        }


    }
}
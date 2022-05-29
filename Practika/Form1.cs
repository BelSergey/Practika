namespace Practika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.GridInput.ColumnCount = 6;
            this.GridInput.RowCount = 6;

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

        private int[,] ChangeTheGrid(DataGridView input)
        {
            int rLng = input.Rows.Count;
            int cLng = input.Columns.Count;
            var res = new int[rLng, cLng];
            for (int i = 0; i < rLng; i++)
            {
                for (int k = 0; k < cLng; k++)
                {
                    string? vTxt = input.Rows[i].Cells[k].Value?.ToString();
                    int value = int.Parse(vTxt);
                    res[i, k] = 2*value;
                }
            }

            return res;
        }
        public class DR
        {
            public int X { get; set; }

            public int Y { get; set; }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GridInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            int[,] source=this.readFromGrid(this.GridInput);
            for (int i=0; i<source.GetLength(0);i++)
            {
                for (int j=0; j < source.GetLength(1); j++)
                {
                    source[i, j] = source[i, j] * 2;
                }
            }
            resultsToTable(GridOut, source);
        }
    }
}
namespace Practika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
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
            this.GridInput.ColumnCount= n*2;
            this.GridInput.RowCount= n*2 ;
        }
    }
}
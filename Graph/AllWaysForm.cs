using System.Windows.Forms;

namespace Graph
{
    public partial class AllWaysForm : Form
    {
        List<List<int>> allPaths;
        public AllWaysForm(List<List<int>> allPaths)
        {
            this.allPaths = allPaths;
            InitializeComponent();
            createGrid(allPaths);
        }

        void createGrid(List<List<int>> allPaths)
        {
            // grid settings
            const int rowWidth = 101;
            const int colWidth = 31;
            dataGridView.ColumnCount = 0;
            for (int i = 0; i < allPaths.Count; i++)
                if (allPaths[i].Count > dataGridView.ColumnCount)
                    dataGridView.ColumnCount = allPaths[i].Count;
            dataGridView.RowCount = allPaths.Count;
            dataGridView.Width = rowWidth * dataGridView.ColumnCount;
            dataGridView.Height = colWidth * dataGridView.RowCount;
            this.Width = dataGridView.Width + 100;
            this.Height = dataGridView.Height + 100;
            this.MaximumSize = new Size(this.Width, this.Height);
            this.MinimumSize = new Size(this.Width, this.Height);
            // grid input
            dataGridView.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;

            for (int i = 0; i < allPaths.Count; i++) 
            {
                int j = 0;
                for (; j < allPaths[i].Count; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = allPaths[i][j] + 1;
                }
                dataGridView.Rows[i].Cells[--j].Style.BackColor = Color.LightBlue;
            }
        }
    }
}

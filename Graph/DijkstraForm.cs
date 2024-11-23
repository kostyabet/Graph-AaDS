using System.CodeDom;

namespace Graph
{
    public partial class DijkstraForm : Form
    {
        int[,] D;
        public DijkstraForm(int[,] D)
        {
            this.D = D;
            InitializeComponent();
            createGrid(D);
        }

        void createGrid(int[,] D)
        {
            const int rowWidth = 110;
            const int colWidth = 30;
            resGridView.ColumnCount = D.GetLength(1) + 1;
            resGridView.RowCount = D.GetLength(0) + 1;
            resGridView.Width = rowWidth * resGridView.ColumnCount + 1;
            resGridView.Height = colWidth * resGridView.RowCount + 1;
            this.Width = resGridView.Width;
            this.Height = resGridView.Height + 10;

            for (int i = 0; i < D.GetLength(0); i++)
                for (int j = 0; j < D.GetLength(1); j++)
                    resGridView.Rows[i].Cells[j].Value = D[i, j];
        }
    }
}

namespace Graph
{
    public partial class DijkstraForm : Form
    {
        int[,] D;
        Graph<int> graph;
        int[] W;
        public DijkstraForm(int[,] D, int[] W, Graph<int> graph)
        {
            this.D = D;
            this.W = W;
            this.graph = graph;
            InitializeComponent();
            createGrid(D, W);
        }

        void createGrid(int[,] D, int[] W)
        {
            // grid settings
            const int rowWidth = 101;
            const int colWidth = 30;
            resGridView.ColumnCount = D.GetLength(1) + 1;
            resGridView.RowCount = D.GetLength(0) + 1;
            resGridView.Width = rowWidth * resGridView.ColumnCount;
            resGridView.Height = colWidth * resGridView.RowCount;
            this.Width = resGridView.Width + 20;
            this.Height = resGridView.Height + 20;
            this.MaximumSize = new Size(this.Width, this.Height);
            this.MinimumSize = new Size(this.Width, this.Height);
            // grid input
            resGridView.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
            resGridView.Rows[0].Cells[0].Value = "Итерация";
            for (int i = 1; i < D.GetLength(0) + 1; i++)
                resGridView.Rows[0].Cells[i].Value = $"{i}";
            for (int i = 1; i < D.GetLength(0) + 1; i++)
            {
                resGridView.Rows[i].Cells[0].Value = $"{i}";
                for (int j = 1; j < D.GetLength(1) + 1; j++)
                    resGridView.Rows[i].Cells[j].Value = D[i - 1, j - 1] == int.MaxValue || D[i - 1, j - 1] == int.MinValue ? "∞" : D[i - 1, j - 1];
            }
            int currentIndex = graph.MainDest;
            for (int i = D.GetLength(0); i >= 0; i--)
            {
                resGridView.Rows[i].Cells[currentIndex].Style.BackColor = Color.LightBlue;
                if (i > 1 && D[i - 1, currentIndex - 1] != D[i - 2, currentIndex - 1])
                    currentIndex = W[i - 1];
                if (i == 1)
                    currentIndex = W[0];
            }
        }

        private void DijkstraForm_Load(object sender, EventArgs e)
        {

        }
    }
}

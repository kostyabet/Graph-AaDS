using System.Windows.Forms;
namespace Graph
{
    public partial class MainForm : Form
    {
        Graph<int> graph;
        public MainForm()
        {
            graph = new Graph<int>();
            InitializeComponent();
        }

        private void inputGraphButton_Click(object sender, EventArgs e)
        {
            InputGraphForm inputGraphForm = new InputGraphForm(graph);
            inputGraphForm.ShowDialog();
            graphPanel.Invalidate();
        }

        private void graphPanel_Paint(object sender, PaintEventArgs e)
        {
            graph.DrawGraph(e.Graphics, graphPanel.Width, graphPanel.Height);
        }

        private void searchShortWayButton_Click(object sender, EventArgs e)
        {
            if (!graph.Empty())
            {
                int[,] D;
                int[] W;
                (D, W) = graph.DijkstraAlgoShort(graph.MainSrc);
                DijkstraForm dijkstraForm = new DijkstraForm(D, W, graph);
                dijkstraForm.ShowDialog();
            }
        }

        private void searchLongestWayButton_Click(object sender, EventArgs e)
        {
            if (!graph.Empty())
            {
                int[,] D;
                int[] W;
                (D, W) = graph.DijkstraAlgoLong(graph.MainSrc);
                DijkstraForm dijkstraForm = new DijkstraForm(D, W, graph);
                dijkstraForm.ShowDialog();
            }
        }

        private void searchAllWaysButton_Click(object sender, EventArgs e)
        {
            if (!graph.Empty())
            {
                List<List<int>> allPaths;
                allPaths = graph.FindAllPaths(graph.MainSrc, graph.MainDest);
                graph.SortPaths(allPaths);
                AllWaysForm allWaysForm = new AllWaysForm(allPaths);
                allWaysForm.ShowDialog();
            }
        }

        private void searchCenterButton_Click(object sender, EventArgs e)
        {
            if (!graph.Empty())
            {
                int[,] Ds;
                Ds = graph.FloydAlgorithm();
                SearchCenterForm allWaysForm = new SearchCenterForm(Ds);
                allWaysForm.ShowDialog();
            }
        }
    }
}

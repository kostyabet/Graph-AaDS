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
            int[,] D;
            int[] W;
            (D, W)= graph.DijkstraAlgo(graph.MainSrc, graph.MainDest);
            DijkstraForm dijkstraForm = new DijkstraForm(D, W, graph);
            dijkstraForm.ShowDialog();
        }
    }
}

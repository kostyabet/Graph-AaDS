namespace Graph
{
    public partial class InputGraphForm : Form
    {
        Graph<int> graph;
        public InputGraphForm(Graph<int> graph)
        {
            this.graph = graph;
            InitializeComponent();
        }

        private void createGraphButton_Click(object sender, EventArgs e)
        {
            graph.Clear();
            // add nodes
            nodesTextBox.Text = "1 2 3 4 5"; //////////////////////////////////////////////////
            string[] inputNodes = nodesTextBox.Text.Split(' ');
            for (int i = 0; i < inputNodes.Length; i++)
            {
                graph.Add(Convert.ToInt32(inputNodes[i]));
            }
            // add edges
            edgesTextBox.Text = "1-10-2 1-30-4 1-100-5 2-50-3 3-10-5 4-20-3 4-60-5"; //////////////////////////////////////////////////
            string[] inputEdges = edgesTextBox.Text.Split(" ");
            foreach (string str in inputEdges)
            {
                string[] values = str.Split("-");
                int src = Convert.ToInt32(values[0]);
                int weight = Convert.ToInt32(values[1]);
                int dest = Convert.ToInt32(values[2]);
                graph.AddEdge(src, weight, dest);
            }
            // src dest
            srcTextBox.Text = "1"; //////////////////////////////////////////////////
            destTextBox.Text = "5"; //////////////////////////////////////////////////
            int source = Convert.ToInt32(srcTextBox.Text);
            int destanation = Convert.ToInt32(destTextBox.Text);
            graph.SetSrc(source);
            graph.SetDest(destanation);
            // exit
            this.Close();
        }

        private void InputGraphForm_Load(object sender, EventArgs e)
        {

        }
    }
}

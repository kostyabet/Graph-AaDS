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
            nodesTextBox.Text = "1 2 3"; //////////////////////////////////////////////////
            string[] inputNodes = nodesTextBox.Text.Split(' ');
            for (int i = 0; i < inputNodes.Length; i++)
            {
                graph.Add(Convert.ToInt32(inputNodes[i]));
            }
            // add edges
            edgesTextBox.Text = "1-1-2 2-2-3 3-2-1"; //////////////////////////////////////////////////
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
            destTextBox.Text = "4"; //////////////////////////////////////////////////
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

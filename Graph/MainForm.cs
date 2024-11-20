using System.Windows.Forms;

namespace Graph
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void inputGraphButton_Click(object sender, EventArgs e)
        {
            // may set graph
            InputGraphForm inputGraphForm = new InputGraphForm();
            inputGraphForm.ShowDialog();
            //panel.Invalidate();
        }
    }
}

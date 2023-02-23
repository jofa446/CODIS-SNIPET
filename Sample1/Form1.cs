namespace Sample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeTreeView()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Parent");
            treeView1.Nodes[0].Nodes.Add("Child 1");
            treeView1.Nodes[0].Nodes.Add("Child 2");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Grandchild");
            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Great Grandchild");
            treeView1.EndUpdate();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}

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
            // Items.
            DomainUpDown.DomainUpDownItemCollection items = this.domainUpDown1.Items;
            items.Add("Dot");
            items.Add("Net");
            items.Add("Perls");

            // Set Text.
            this.domainUpDown1.Text = "Dot";
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


        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {


            // Set Text.
            this.domainUpDown1.Text = "Dot";
            // Run code every time the item is changed.
            this.Text = domainUpDown1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

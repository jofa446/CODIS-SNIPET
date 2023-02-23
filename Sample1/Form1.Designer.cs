namespace Sample1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Node2");
            TreeNode treeNode2 = new TreeNode("Node5");
            TreeNode treeNode3 = new TreeNode("Node6");
            TreeNode treeNode4 = new TreeNode("Root2", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Node3");
            TreeNode treeNode6 = new TreeNode("Node4");
            TreeNode treeNode7 = new TreeNode("Root1", new TreeNode[] { treeNode5, treeNode6 });
            TreeNode treeNode8 = new TreeNode("Node0");
            TreeNode treeNode9 = new TreeNode("Node7");
            TreeNode treeNode10 = new TreeNode("Node1", new TreeNode[] { treeNode9 });
            TreeNode treeNode11 = new TreeNode("Root3", new TreeNode[] { treeNode8, treeNode10 });
            button1 = new Button();
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(149, 49);
            button1.TabIndex = 0;
            button1.Text = "OPEN SECOND FORM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(374, 89);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Node2";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Node5";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Node6";
            treeNode4.ForeColor = Color.Blue;
            treeNode4.Name = "Root2";
            treeNode4.Tag = "holaa";
            treeNode4.Text = "Root2";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Node3";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Node4";
            treeNode7.Name = "Root1";
            treeNode7.Text = "Root1";
            treeNode8.Name = "Node0";
            treeNode8.Text = "Node0";
            treeNode9.Name = "Node7";
            treeNode9.Text = "Node7";
            treeNode10.Name = "Node1";
            treeNode10.Text = "Node1";
            treeNode11.Name = "Root3";
            treeNode11.Text = "Root3";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode7, treeNode11 });
            treeView1.Size = new Size(305, 252);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 508);
            Controls.Add(treeView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TreeView treeView1;
    }
}
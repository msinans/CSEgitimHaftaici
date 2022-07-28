namespace WindowsFormsEgitimi
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("C# dot net");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Java");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("PHP");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Yazılım", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("PostgreSQL");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Oracle", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("MySQl", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Sql Server", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Veri Tabanı", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(304, 142);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "C# dot net";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Java";
            treeNode3.Name = "Node3";
            treeNode3.Text = "PHP";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Yazılım";
            treeNode5.Name = "Node8";
            treeNode5.Text = "PostgreSQL";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Oracle";
            treeNode7.Name = "Node6";
            treeNode7.Text = "MySQl";
            treeNode8.Name = "Node5";
            treeNode8.Text = "Sql Server";
            treeNode9.Name = "Node4";
            treeNode9.Text = "Veri Tabanı";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(162, 121);
            this.treeView1.TabIndex = 0;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}
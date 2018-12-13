namespace Calculator
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Year2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Year2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Year3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Year4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Students", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Kist1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Kist2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Muhabura");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Kist4");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("CampKgl");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Rooms", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("WebTech");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("NetApps");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("DataC&N");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("BusinessMgt");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Courses", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Calculator");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Utility", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(698, 367);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Year1";
            treeNode1.Text = "Year2";
            treeNode2.Name = "Year2";
            treeNode2.Text = "Year2";
            treeNode3.Name = "Year3";
            treeNode3.Text = "Year3";
            treeNode4.Name = "Year4";
            treeNode4.Text = "Year4";
            treeNode5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            treeNode5.ForeColor = System.Drawing.Color.Black;
            treeNode5.Name = "Students";
            treeNode5.Text = "Students";
            treeNode6.Name = "Kist1";
            treeNode6.Text = "Kist1";
            treeNode7.Name = "Kist2";
            treeNode7.Text = "Kist2";
            treeNode8.Name = "Muhabura";
            treeNode8.Text = "Muhabura";
            treeNode9.Name = "Kist4";
            treeNode9.Text = "Kist4";
            treeNode10.Name = "CampKgl";
            treeNode10.Text = "CampKgl";
            treeNode11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            treeNode11.Name = "Rooms";
            treeNode11.Text = "Rooms";
            treeNode12.Name = "WebTech";
            treeNode12.Text = "WebTech";
            treeNode13.Name = "NetApps";
            treeNode13.Text = "NetApps";
            treeNode14.Name = "DataC&N";
            treeNode14.Text = "DataC&N";
            treeNode15.Name = "BusinessMgt";
            treeNode15.Text = "BusinessMgt";
            treeNode16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            treeNode16.Name = "Courses";
            treeNode16.NodeFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode16.Text = "Courses";
            treeNode17.Name = "Calculator";
            treeNode17.Text = "Calculator";
            treeNode18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            treeNode18.Name = "Utility";
            treeNode18.Text = "Utility";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode11,
            treeNode16,
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(229, 545);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 367);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
    }
}


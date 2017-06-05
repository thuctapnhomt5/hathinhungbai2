namespace QLSTHi
{
    partial class frmHuongDan
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Giới Thiệu");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Hướng Dẫn");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Liên Hệ");
            this.txtHD = new System.Windows.Forms.RichTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // txtHD
            // 
            this.txtHD.Location = new System.Drawing.Point(267, 12);
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(436, 413);
            this.txtHD.TabIndex = 1;
            this.txtHD.Text = "";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "rGioiThieu";
            treeNode1.Text = "Giới Thiệu";
            treeNode2.Name = "rHuongDan";
            treeNode2.Text = "Hướng Dẫn";
            treeNode3.Name = "rLienHe";
            treeNode3.Text = "Liên Hệ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(249, 413);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 446);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtHD);
            this.Name = "frmHuongDan";
            this.Text = "frmHuongDan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHD;
        private System.Windows.Forms.TreeView treeView1;
    }
}
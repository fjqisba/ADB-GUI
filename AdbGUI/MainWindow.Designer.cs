namespace AdbGUI
{
    partial class MainWindow
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
            this.deviceTree = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.程序ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceTree
            // 
            this.deviceTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceTree.Location = new System.Drawing.Point(3, 26);
            this.deviceTree.Name = "deviceTree";
            this.deviceTree.Size = new System.Drawing.Size(359, 626);
            this.deviceTree.TabIndex = 0;
            this.deviceTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.deviceTree_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.deviceTree);
            this.groupBox1.Location = new System.Drawing.Point(24, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 655);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备列表";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 32);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 704);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(4, 32);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(4, 704);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(8, 32);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(4, 704);
            this.splitter3.TabIndex = 4;
            this.splitter3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(411, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(790, 638);
            this.textBox1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.程序ToolStripMenuItem,
            this.程序ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1255, 32);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 程序ToolStripMenuItem
            // 
            this.程序ToolStripMenuItem.Name = "程序ToolStripMenuItem";
            this.程序ToolStripMenuItem.Size = new System.Drawing.Size(16, 28);
            // 
            // 程序ToolStripMenuItem1
            // 
            this.程序ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新设备ToolStripMenuItem});
            this.程序ToolStripMenuItem1.Name = "程序ToolStripMenuItem1";
            this.程序ToolStripMenuItem1.Size = new System.Drawing.Size(62, 28);
            this.程序ToolStripMenuItem1.Text = "设备";
            this.程序ToolStripMenuItem1.Click += new System.EventHandler(this.程序ToolStripMenuItem1_Click);
            // 
            // 刷新设备ToolStripMenuItem
            // 
            this.刷新设备ToolStripMenuItem.Name = "刷新设备ToolStripMenuItem";
            this.刷新设备ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.刷新设备ToolStripMenuItem.Text = "刷新设备";
            this.刷新设备ToolStripMenuItem.Click += new System.EventHandler(this.刷新设备ToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 736);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADB小助手";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView deviceTree;
        private GroupBox groupBox1;
        private Splitter splitter1;
        private Splitter splitter2;
        private Splitter splitter3;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 程序ToolStripMenuItem;
        private ToolStripMenuItem 程序ToolStripMenuItem1;
        private ToolStripMenuItem 刷新设备ToolStripMenuItem;
    }
}
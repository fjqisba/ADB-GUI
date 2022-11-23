using System.Collections;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;

namespace AdbGUI
{
    public partial class MainWindow : Form
    {
        private static ContextMenuStrip menu_Device = new ContextMenuStrip();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void 程序ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 刷新设备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList deviceList = AdbCmd.adb_devices();
            this.deviceTree.Nodes.Clear();
            TreeNode defaultNode = this.deviceTree.Nodes.Add("默认设备");
            for (int i = 0; i < deviceList.Count; i++){
                if (deviceList[i] != null){
                    TreeNode tmpNode = new TreeNode(deviceList[i].ToString());
                    tmpNode.ContextMenuStrip = menu_Device;
                    defaultNode.Nodes.Add(tmpNode);
                }
            }
            defaultNode.ExpandAll();
        }

        private void onDeviceMenu_OpenShell(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripItem)sender;
            string deviceID = this.deviceTree.SelectedNode.Text;
            AdbCmd.adb_shell(deviceID);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.刷新设备ToolStripMenuItem_Click(sender,e);

            ToolStripMenuItem menu_OpenShell = new ToolStripMenuItem();
            menu_OpenShell.Text = "打开命令行";
            menu_OpenShell.Click += new EventHandler(onDeviceMenu_OpenShell);
            
            menu_Device.Items.Add(menu_OpenShell);
        }

        private void deviceTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
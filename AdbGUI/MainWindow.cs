using System.Collections;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdbGUI
{
    public partial class MainWindow : Form
    {
        private static ContextMenuStrip menu_Device = new ContextMenuStrip();
        private static string selectDeviceID = "";
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

     
        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.刷新设备ToolStripMenuItem_Click(sender,e);
            this.deviceTree.NodeMouseClick += DeviceTree_NodeMouseClick;
           
            ToolStripMenuItem menu_OpenShell = new ToolStripMenuItem();
            menu_OpenShell.Text = "打开命令行";
            menu_OpenShell.Click += Menu_OpenShell_Click;

            ToolStripMenuItem menu_EditRemark = new ToolStripMenuItem();
            menu_EditRemark.Text = "修改备注";
            menu_EditRemark.Click += Menu_EditRemark_Click;

            menu_Device.Items.Add(menu_OpenShell);
            menu_Device.Items.Add(menu_EditRemark);
        }

        private void Menu_OpenShell_Click(object? sender, EventArgs e)
        {
            AdbCmd.adb_shell(selectDeviceID);
        }

        //修改备注
        private void Menu_EditRemark_Click(object? sender, EventArgs e)
        {
            
        }


        private void DeviceTree_NodeMouseClick(object? sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Button == MouseButtons.Left) {
                return;
            }
            if (e.Button == MouseButtons.Right){
                //路径节点
                if (e.Node.Nodes.Count > 0) {
                    return;
                }
                selectDeviceID = e.Node.Text;
                menu_Device.Show(this.deviceTree, e.Location);
            }
        }

        private void deviceTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeViewEventArgs treeViewEventArgs = (TreeViewEventArgs)e;
            
        }
    }
}
using System.Collections;
using System.Diagnostics;
using System.Text;

namespace AdbGUI
{
    public partial class MainWindow : Form
    {
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
            int a = 0;
        }
    }
}
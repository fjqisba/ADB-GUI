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

        private void ����ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ˢ���豸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList deviceList = AdbCmd.adb_devices();
            int a = 0;
        }
    }
}
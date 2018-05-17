using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplWin
{
    public partial class WinStart : Form
    {
        CMDcommand cmd = new CMDcommand();
        public WinStart()
        {
            InitializeComponent();
        }

        public void btnstart_Click_standard() //点击开始优化后标准的界面变化步骤
        {
            this.Labmain.Visible = false;
            this.Labmain.Location = new Point(136, 76);
            this.Labmain.Text = "正在执行优化";
            this.Labmain.Visible = true;
            this.Labsecondly.Visible = false;
            this.Texmain.ReadOnly = true;
            this.Texmain.Visible = true;
            this.Labmain.Enabled = false;
            this.Labmain.Enabled = true;
            this.Texmain.Enabled = false;
            this.Texmain.Enabled = true;
            this.Texmain.SelectionStart = this.Texmain.Text.Length;
            this.Texmain.SelectionLength = 0;
            this.Texmain.ScrollToCaret();
        }

        private void WinStart_Load(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e) //开始优化按扭点击操作
        {
            btnstart_Click_standard();
            string state = cmd.Net_Framework35();
            this.Texmain.AppendText(".Net Framework 3.5组件"+state+"\n");
        }

        private void btnexit_Click(object sender, EventArgs e) //退出按扭点击操作
        {
            Application.Exit();
        }
    }
}

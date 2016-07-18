//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;

namespace Test2
{
    public partial class MyTaskManeger : Form
    {
        public MyTaskManeger()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获取进程
        /// </summary>
        private void getProcessInfo()
        {
            try
            {
                listView1.Items.Clear();//清空listView1控件的内容
                Process[] MyProcesses = Process.GetProcesses();//获取所有的进程
                tsslInfo.Text = "进程总数：" + MyProcesses.Length.ToString();//状态栏总进程数
                string[] Minfo = new string[6];//用于存储进程信息
                foreach (Process MyProcess in MyProcesses) //遍历所有进程
                {
                    Minfo[0] = MyProcess.ProcessName;
                    //Minfo[1] = MyProcess.MainModule.ModuleName;
                    Minfo[1] = MyProcess.ProcessName + ".exe";
                    Minfo[2] = MyProcess.Threads.Count.ToString();
                    Minfo[3] = MyProcess.BasePriority.ToString();
                    Minfo[4] = Convert.ToString(MyProcess.WorkingSet / 1024) + "K";//物理内存
                    Minfo[5] = Convert.ToString(MyProcess.VirtualMemorySize / 1024) + "K";//虚拟内存
                    ListViewItem lvi = new ListViewItem(Minfo, "process");
                    listView1.Items.Add(lvi);
                }
            }
            catch { }
        }

        private void 退出CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getProcessInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("警告:终止进程会导致不希望发生的结果，\r包括数据丢失和系统不稳定。在被终止前，\r进程将没有机会保存其状态和数据。确实\r想终止该进程吗?", "任务管理器警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string ProcessName = listView1.SelectedItems[0].Text;
                    Process[] MyProcess = Process.GetProcessesByName(ProcessName);
                    MyProcess[0].Kill();
                    getProcessInfo();
                }
                else
                { }
            }
            catch
            {
                string ProcessName = listView1.SelectedItems[0].Text;
                Process[] MyProcess1 = Process.GetProcessesByName(ProcessName);
                Process MyProcess = new Process();
                //设定程序名
                MyProcess.StartInfo.FileName = "cmd.exe";
                //关闭Shell的使用
                MyProcess.StartInfo.UseShellExecute = false;
                //重定向标准输入
                MyProcess.StartInfo.RedirectStandardInput = true;
                //重定向标准输出
                MyProcess.StartInfo.RedirectStandardOutput = true;
                //重定向错误输出
                MyProcess.StartInfo.RedirectStandardError = true;
                //设置不显示窗口
                MyProcess.StartInfo.CreateNoWindow = true;
                //执行强制结束命令
                MyProcess.Start();
                MyProcess.StandardInput.WriteLine("ntsd -c q -p " + (MyProcess1[0].Id).ToString());
                MyProcess.StandardInput.WriteLine("Exit");
                getProcessInfo();
            }
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getProcessInfo();
        }

        private void 结束进程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("警告:终止进程会导致不希望发生的结果，\r包括数据丢失和系统不稳定。在被终止前，\r进程将没有机会保存其状态和数据。确实\r想终止该进程吗?", "任务管理器警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string ProcessName = listView1.SelectedItems[0].Text;
                    Process[] MyProcess = Process.GetProcessesByName(ProcessName);
                    MyProcess[0].Kill();
                    getProcessInfo();
                }
                else
                { }
            }
            catch
            {
                string ProcessName = listView1.SelectedItems[0].Text;
                Process[] MyProcess1 = Process.GetProcessesByName(ProcessName);
                Process MyProcess = new Process();
                //设定程序名
                MyProcess.StartInfo.FileName = "cmd.exe";
                //关闭Shell的使用
                MyProcess.StartInfo.UseShellExecute = false;
                //重定向标准输入
                MyProcess.StartInfo.RedirectStandardInput = true;
                //重定向标准输出
                MyProcess.StartInfo.RedirectStandardOutput = true;
                //重定向错误输出
                MyProcess.StartInfo.RedirectStandardError = true;
                //设置不显示窗口
                MyProcess.StartInfo.CreateNoWindow = true;
                //执行强制结束命令
                MyProcess.Start();
                MyProcess.StandardInput.WriteLine("ntsd -c q -p " + (MyProcess1[0].Id).ToString());
                MyProcess.StandardInput.WriteLine("Exit");
                getProcessInfo();
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

            GetAppPro();
        }
        /// <summary>
        /// 获取应用程序进程(非全部的)
        /// </summary>
        public void GetAppPro()
        {
            listView2.Items.Clear();//清空控件中的信息
            Process[] myProcesses = Process.GetProcesses();//获取本地进程信息
            string[] Minfo2 = new string[2];//用于存储进程信息
            foreach (Process myProcess in myProcesses)//遍历进程数组
            {
                if (myProcess.MainWindowTitle.Length > 0)//如果进程存在主窗口标题
                {
                    //listBox1.Items.Add(myProcess.ProcessName.ToString().Trim());//将进程名称添加到控件中
                    Minfo2[0] = myProcess.ProcessName.ToString().Trim();
                    Minfo2[1] = "正在运行";
                    ListViewItem lvi2 = new ListViewItem(Minfo2, "process");
                    listView2.Items.Add(lvi2);
                }
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            //listView2.SelectedItems.Count
            //listView2.SelectedItems
            if (MessageBox.Show("警告:终止进程会导致不希望发生的结果，\r包括数据丢失和系统不稳定。在被终止前，\r进程将没有机会保存其状态和数据。确实\r想终止该进程吗?", "任务管理器警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string ProcessName = listView2.SelectedItems[0].Text;
                Process[] MyProcess = Process.GetProcessesByName(ProcessName);
                MyProcess[0].Kill();
                //重新加载进程
                MessageBox.Show("进程已关闭！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAppPro();
            }
            else
            { }
        }
    }
}

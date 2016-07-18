using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Test2
{
    public partial class MyFileManeger : Form
    {
        /// <summary>
        /// 全局变量,用于保存后退时文件夹的路径
        /// </summary>
        string[] globalPaths = new string[] { "0", "1", "2", "0", "1", "2", "0", "1", "2", "0", "1", "2", "0", 
            "1", "2", "0", "1", "2", "0", "1", "2", "0", "1", "2", "0","1","2","0","1","2","0","1","2","0","1","2"};

        /// <summary>
        /// globalPath的索引
        /// </summary>
        static int flag = 0;

        /// <summary>
        /// 文件复制时原路径
        /// </summary>
        string srcPath = null;

        /// <summary>
        /// 文件复制时目标路径
        /// </summary>
        string desPath = null;

        public MyFileManeger()
        {
            InitializeComponent();
            ControlInitial();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TreeNode tvRoot = tvTree.Nodes[0];
            LoadMyDisk();
        }

        //加载左边树
        private void tvTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = tvTree.SelectedNode.Tag.ToString();
            LoadDirctoriesAndFiles(path);
        }


        //加载右边listView列表
        private void lvInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DoubleClickOpen();
        }
        #region 控件初始化设置+ControlInitial()
        /// <summary>
        /// 控件初始化设置
        /// </summary>
        public void ControlInitial()
        {
            粘贴VtoolStripMenuItem1.Enabled = false;
            属性RToolStripMenuItem.Enabled = false;
        } 
        #endregion

        #region 加载磁盘目录+LoadMyDisk()
        /// <summary>
        /// 加载磁盘目录
        /// </summary>
        public  void LoadMyDisk()
        {
            
            DriveInfo[] dInfos = DriveInfo.GetDrives();
            foreach (DriveInfo drive in dInfos)
            {
                //ImageList myImageList = new ImageList();
                //myImageList.Images.Add(Image.FromFile("Default.ico"));
                //myImageList.Images.Add(Image.FromFile("Default2.ico"));
                //tvTree.ImageList = myImageList;
                //tvTree.ImageIndex = 0;
                //tvTree.SelectedImageIndex = 1;
                TreeNode driveNode = new TreeNode(drive.Name);
                driveNode.Tag = drive.RootDirectory;
                driveNode.ImageIndex = 5;
                if (drive.Name == "G:\\" || drive.Name == "C:\\")
                {

                }
                else
                {
                    tvTree.Nodes.Add(driveNode);
                }
                string drivePath = drive.RootDirectory.ToString();
                if (drivePath == "D:\\")
                {
                    LoadTree(driveNode, drivePath);
                }
            }
        } 
        #endregion

        #region 初始化递归加载目录树+LoadTree(TreeNode tNode, string currentDir)
        /// <summary>
        /// 初始化递归加载目录树
        /// </summary>
        /// <param name="tNode"></param>
        /// <param name="currentDir"></param>
        public void LoadTree(TreeNode tNode, string currentDir)
        {
            //01 获取所有的目录
            string[] sonDirs = Directory.GetDirectories(currentDir);
            //递归加载磁盘下所有目录
            foreach (string dir in sonDirs)
            {
                TreeNode sonNode = new TreeNode();
                sonNode.Text = Path.GetFileName(dir);
                sonNode.Tag = dir;
                sonNode.ImageIndex = 0;
                //02 将目录添加到viewtree的节点中去
                tNode.Nodes.Add(sonNode);
                if (Directory.GetDirectories(dir).Length > 0)
                {
                    LoadTree(sonNode, dir);
                }

            }
        }
        #endregion

        #region 双击打开文件或者文件夹+DoubleClickOpen()
        /// <summary>
        /// 双击打开文件或者文件夹
        /// </summary>
        public void DoubleClickOpen()
        {
            string fileExtension = Path.GetExtension(lvInfo.SelectedItems[0].SubItems[0].Text);

            string currentDir = Path.GetFileName(lvInfo.SelectedItems[0].SubItems[0].Text);
            //imageIndex为0表示为目录,就继续加载
            string path = lvInfo.SelectedItems[0].Tag.ToString();

            if (lvInfo.SelectedItems[0].ImageIndex == 0)
            {
                //如果是文件夹,就保存当前文件夹,方便后退
                if (path.Length > 4)
                {
                    //保存上一级的路径
                    flag++;
                    globalPaths[flag] = path.Substring(0, path.Length - currentDir.Length);

                }
                LoadDirctoriesAndFiles(path);
            }
            else if (fileExtension == ".txt" || fileExtension == ".xml" || fileExtension == ".bat" || fileExtension == ".cs"
                || fileExtension == ".java" || fileExtension == ".c" || fileExtension == ".ini" || fileExtension == ".aspx" || fileExtension == ".ashx")
            {
                //OpenMyEdit();

                MyNotepad note = new MyNotepad(path);
                //richTextBox1.LoadFile(dlg.FileName, RichTextBoxStreamType.PlainText);
                note.ShowDialog();
            }
            else if (fileExtension == ".png" || fileExtension == ".jpg" || fileExtension == ".gif" || fileExtension == ".ico")
            {
                CmdOpen.mspaintCmd(path);
            }
            else if (fileExtension == ".exe")
            {
                CmdOpen.EXECmd(path);
            }
        } 
        #endregion

        #region 加载树的目录和文件+LoadDirctoriesAndFiles(string path)
        /// <summary>
        /// 加载树的目录和文件
        /// </summary>
        
        public void LoadDirctoriesAndFiles(string path)
        {
            
            cboxPath.Text = path.ToString();
            //如果不为磁盘就就记录,当前目录
           
            
            lvInfo.Items.Clear();
            
            string[] files = Directory.GetFiles(path);
            //1.0 获取所有的文件
            //将文件的名称,创建时间,大小添加到lv中去
            ListViewItem item = null;
            FileInfo fileInfo = null;
            DirectoryInfo dirInfo = null;
            //加载目录的子目录
            string[] childDirs = Directory.GetDirectories(path);

            toolStripStatusLabelCount.Text = "状态:" + (files.Length + childDirs.Length)+"个对象";
            foreach (string dir in childDirs)
            {
                item = new ListViewItem();
                dirInfo = new DirectoryInfo(dir);

                item.ImageIndex = 0;
                item.Text = Path.GetFileName(dir);
                
                
                item.Tag = dir;
                item.SubItems.Add(dirInfo.CreationTime.ToShortDateString());
                lvInfo.Items.Add(item);
            }
            //加载文件
            foreach (string file in files)
            {
                item = new ListViewItem();
                fileInfo = new FileInfo(file);
                item.Tag = file;
                switch (Path.GetExtension(file))
                {
                    case ".txt":
                        item.ImageIndex = 1;
                        break;
                    case ".exe":
                        item.ImageIndex = 2;
                        break;
                    case ".mp3":
                        item.ImageIndex = 3;
                        break;
                    case ".jpg":
                        item.ImageIndex = 4;
                        break;
                    case ".png":
                        item.ImageIndex = 4;
                        break;
                    case ".ico":
                        item.ImageIndex = 4;
                        break;
                    default:
                        item.ImageIndex = 6;
                        break;
                }
                //item.ImageIndex = 0;
                item.Text = Path.GetFileName(file);
                item.SubItems.Add(fileInfo.CreationTime.ToShortDateString());
                item.SubItems.Add(fileInfo.Extension);
                //大小KB M的处理
                string length = fileInfo.Length > 1024 * 1024 ? (fileInfo.Length / (1024.0 * 1024)).ToString().Split(new char[1] { '.' })[0] + " M" :
                    (fileInfo.Length / 1024 == 0 ? 1 : fileInfo.Length / 1024).ToString() + " KB";
                item.SubItems.Add(length);
                lvInfo.Items.Add(item);


            }
        } 
        #endregion

        #region 视图切换+ChangeView()
        /// <summary>
        /// 视图切换
        /// </summary>
        public void ChangeView()
        {
            if (lvInfo.View == View.LargeIcon)
            {
                lvInfo.View = View.Details;
                lvInfo.LargeImageList = this.myImageList;
            }
            else
            {
                lvInfo.View = View.LargeIcon;
                lvInfo.LargeImageList = this.myImagelistLarge;
            }
        } 
        #endregion

        private void btnChangeView_Click(object sender, EventArgs e)
        {
            ChangeView();
        } 

        private void tvTree_MouseClick(object sender, MouseEventArgs e)
        {
            string path = tvTree.SelectedNode.Tag.ToString();
            LoadDirctoriesAndFiles(path);
        }

        private void 任务管理器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyTaskManeger task = new MyTaskManeger();
            task.ShowDialog();
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
            if (flag > 0)
            {
                string path = globalPaths[flag];
                flag--;
                LoadDirctoriesAndFiles(path);
            }
            
        }

        private void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lvInfo_MouseEnter(object sender, EventArgs e)
        {
            lvInfo.Focus();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoubleClickOpen();
        }

        private void 重命名RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvInfo.SelectedItems[0].Focused = true;
        }

        private void lvInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void lvInfo_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //this.lvInfo.Sorting = SortOrder.Descending;
        }

        private void 新建文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = cboxPath.Text;
            FileOperate.CreateFolder(path);
            LoadDirctoriesAndFiles(path);
        }

        private void 删除DToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FileOperate.Delete(cboxPath.Text+"\\"+lvInfo.SelectedItems[0].SubItems[0].Text);
            LoadDirctoriesAndFiles(cboxPath.Text);
        }

        private void 剪切XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            srcPath = cboxPath.Text + "\\" + lvInfo.SelectedItems[0].SubItems[0].Text+"_cut";
            lvInfo.SelectedItems[0].ImageIndex = 7;
            粘贴VtoolStripMenuItem1.Enabled = true;
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            srcPath = cboxPath.Text + "\\" + lvInfo.SelectedItems[0].SubItems[0].Text;
            lvInfo.SelectedItems[0].ImageIndex = 7;
            粘贴VtoolStripMenuItem1.Enabled = true;
        }

        private void 粘贴VtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int flag=0;
            desPath = cboxPath.Text;
            if (srcPath.Contains("_cut"))
            {
                srcPath= srcPath.Substring(0,srcPath.Length-4);
                flag++;
            }
            if (Directory.Exists(srcPath))
            {
                FileOperate.CopyDirectory(srcPath, desPath);
            }
            else
            {
                FileOperate.CopyFile(srcPath,desPath+"\\"+srcPath.Substring(srcPath.LastIndexOf("\\")+1));
                //如果是剪切就删除源文件,是复制就不用了.
                if (flag > 0)
                {
                    FileOperate.DeleteFile(srcPath);
                }
            }
            粘贴VtoolStripMenuItem1.Enabled = false;
            LoadDirctoriesAndFiles(cboxPath.Text);
        }

        private void 桌面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string shortcutDirPath = cboxPath.Text;
            string shortcutFilePath = cboxPath.Text + "\\" + lvInfo.SelectedItems[0].SubItems[0].Text;
            if (Directory.Exists(srcPath))
            {
                FileOperate.CreateDesktopShortcut(shortcutDirPath, shortcutDirPath.Substring(srcPath.LastIndexOf("\\")));
            }
            else
            {
                FileOperate.CreateDesktopShortcut(shortcutFilePath, shortcutFilePath.Substring(shortcutFilePath.LastIndexOf("\\")));
            }
        }



        
    }
}

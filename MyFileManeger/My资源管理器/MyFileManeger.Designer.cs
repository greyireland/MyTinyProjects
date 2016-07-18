namespace Test2
{
    partial class MyFileManeger
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyFileManeger));
            this.tvTree = new System.Windows.Forms.TreeView();
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            this.lvInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOperate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发送到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.桌面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的U盘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴VtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cboxPath = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.组织ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切XToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.任务管理器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.卸载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刻录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnChangeView = new System.Windows.Forms.Button();
            this.myImagelistLarge = new System.Windows.Forms.ImageList(this.components);
            this.cmsOperate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvTree
            // 
            resources.ApplyResources(this.tvTree, "tvTree");
            this.tvTree.ImageList = this.myImageList;
            this.tvTree.Name = "tvTree";
            this.tvTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTree_AfterSelect);
            this.tvTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvTree_MouseClick);
            // 
            // myImageList
            // 
            this.myImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myImageList.ImageStream")));
            this.myImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.myImageList.Images.SetKeyName(0, "Icon_4.ico");
            this.myImageList.Images.SetKeyName(1, "Icon_98.ico");
            this.myImageList.Images.SetKeyName(2, "Icon_12.ico");
            this.myImageList.Images.SetKeyName(3, "Icon_126.ico");
            this.myImageList.Images.SetKeyName(4, "Icon_79.ico");
            this.myImageList.Images.SetKeyName(5, "Icon_32.ico");
            this.myImageList.Images.SetKeyName(6, "Icon_64.ico");
            this.myImageList.Images.SetKeyName(7, "Icon_204.ico");
            // 
            // lvInfo
            // 
            resources.ApplyResources(this.lvInfo, "lvInfo");
            this.lvInfo.AllowColumnReorder = true;
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvInfo.ContextMenuStrip = this.cmsOperate;
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.LabelEdit = true;
            this.lvInfo.LargeImageList = this.myImageList;
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.SmallImageList = this.myImageList;
            this.lvInfo.StateImageList = this.myImageList;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            this.lvInfo.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvInfo_ColumnClick);
            this.lvInfo.SelectedIndexChanged += new System.EventHandler(this.lvInfo_SelectedIndexChanged);
            this.lvInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvInfo_MouseDoubleClick);
            this.lvInfo.MouseEnter += new System.EventHandler(this.lvInfo_MouseEnter);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // cmsOperate
            // 
            this.cmsOperate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开OToolStripMenuItem,
            this.发送到ToolStripMenuItem,
            this.剪切XToolStripMenuItem,
            this.复制CToolStripMenuItem,
            this.粘贴VtoolStripMenuItem1,
            this.删除DToolStripMenuItem,
            this.重命名RToolStripMenuItem,
            this.属性RToolStripMenuItem});
            this.cmsOperate.Name = "contextMenuStrip1";
            resources.ApplyResources(this.cmsOperate, "cmsOperate");
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            resources.ApplyResources(this.打开OToolStripMenuItem, "打开OToolStripMenuItem");
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // 发送到ToolStripMenuItem
            // 
            this.发送到ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.桌面ToolStripMenuItem,
            this.我的U盘ToolStripMenuItem});
            this.发送到ToolStripMenuItem.Name = "发送到ToolStripMenuItem";
            resources.ApplyResources(this.发送到ToolStripMenuItem, "发送到ToolStripMenuItem");
            // 
            // 桌面ToolStripMenuItem
            // 
            this.桌面ToolStripMenuItem.Name = "桌面ToolStripMenuItem";
            resources.ApplyResources(this.桌面ToolStripMenuItem, "桌面ToolStripMenuItem");
            this.桌面ToolStripMenuItem.Click += new System.EventHandler(this.桌面ToolStripMenuItem_Click);
            // 
            // 我的U盘ToolStripMenuItem
            // 
            this.我的U盘ToolStripMenuItem.Name = "我的U盘ToolStripMenuItem";
            resources.ApplyResources(this.我的U盘ToolStripMenuItem, "我的U盘ToolStripMenuItem");
            // 
            // 剪切XToolStripMenuItem
            // 
            this.剪切XToolStripMenuItem.Name = "剪切XToolStripMenuItem";
            resources.ApplyResources(this.剪切XToolStripMenuItem, "剪切XToolStripMenuItem");
            this.剪切XToolStripMenuItem.Click += new System.EventHandler(this.剪切XToolStripMenuItem_Click);
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            resources.ApplyResources(this.复制CToolStripMenuItem, "复制CToolStripMenuItem");
            this.复制CToolStripMenuItem.Click += new System.EventHandler(this.复制CToolStripMenuItem_Click);
            // 
            // 粘贴VtoolStripMenuItem1
            // 
            this.粘贴VtoolStripMenuItem1.Name = "粘贴VtoolStripMenuItem1";
            resources.ApplyResources(this.粘贴VtoolStripMenuItem1, "粘贴VtoolStripMenuItem1");
            this.粘贴VtoolStripMenuItem1.Click += new System.EventHandler(this.粘贴VtoolStripMenuItem1_Click);
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            resources.ApplyResources(this.删除DToolStripMenuItem, "删除DToolStripMenuItem");
            this.删除DToolStripMenuItem.Click += new System.EventHandler(this.删除DToolStripMenuItem_Click_1);
            // 
            // 重命名RToolStripMenuItem
            // 
            this.重命名RToolStripMenuItem.Name = "重命名RToolStripMenuItem";
            resources.ApplyResources(this.重命名RToolStripMenuItem, "重命名RToolStripMenuItem");
            this.重命名RToolStripMenuItem.Click += new System.EventHandler(this.重命名RToolStripMenuItem_Click);
            // 
            // 属性RToolStripMenuItem
            // 
            this.属性RToolStripMenuItem.Name = "属性RToolStripMenuItem";
            resources.ApplyResources(this.属性RToolStripMenuItem, "属性RToolStripMenuItem");
            // 
            // btnPrevious
            // 
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // cboxPath
            // 
            this.cboxPath.FormattingEnabled = true;
            resources.ApplyResources(this.cboxPath, "cboxPath");
            this.cboxPath.Name = "cboxPath";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.cboxPath);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.组织ToolStripMenuItem,
            this.选项OToolStripMenuItem,
            this.系统属性ToolStripMenuItem,
            this.卸载ToolStripMenuItem,
            this.刻录ToolStripMenuItem,
            this.新建文件夹ToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // 组织ToolStripMenuItem
            // 
            this.组织ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪切XToolStripMenuItem1,
            this.复制CToolStripMenuItem1,
            this.退出EToolStripMenuItem});
            this.组织ToolStripMenuItem.Name = "组织ToolStripMenuItem";
            resources.ApplyResources(this.组织ToolStripMenuItem, "组织ToolStripMenuItem");
            // 
            // 剪切XToolStripMenuItem1
            // 
            this.剪切XToolStripMenuItem1.Name = "剪切XToolStripMenuItem1";
            resources.ApplyResources(this.剪切XToolStripMenuItem1, "剪切XToolStripMenuItem1");
            // 
            // 复制CToolStripMenuItem1
            // 
            this.复制CToolStripMenuItem1.Name = "复制CToolStripMenuItem1";
            resources.ApplyResources(this.复制CToolStripMenuItem1, "复制CToolStripMenuItem1");
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            resources.ApplyResources(this.退出EToolStripMenuItem, "退出EToolStripMenuItem");
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // 选项OToolStripMenuItem
            // 
            this.选项OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.任务管理器ToolStripMenuItem});
            this.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem";
            resources.ApplyResources(this.选项OToolStripMenuItem, "选项OToolStripMenuItem");
            // 
            // 任务管理器ToolStripMenuItem
            // 
            this.任务管理器ToolStripMenuItem.Name = "任务管理器ToolStripMenuItem";
            resources.ApplyResources(this.任务管理器ToolStripMenuItem, "任务管理器ToolStripMenuItem");
            this.任务管理器ToolStripMenuItem.Click += new System.EventHandler(this.任务管理器ToolStripMenuItem_Click);
            // 
            // 系统属性ToolStripMenuItem
            // 
            this.系统属性ToolStripMenuItem.Name = "系统属性ToolStripMenuItem";
            resources.ApplyResources(this.系统属性ToolStripMenuItem, "系统属性ToolStripMenuItem");
            // 
            // 卸载ToolStripMenuItem
            // 
            this.卸载ToolStripMenuItem.Name = "卸载ToolStripMenuItem";
            resources.ApplyResources(this.卸载ToolStripMenuItem, "卸载ToolStripMenuItem");
            // 
            // 刻录ToolStripMenuItem
            // 
            this.刻录ToolStripMenuItem.Name = "刻录ToolStripMenuItem";
            resources.ApplyResources(this.刻录ToolStripMenuItem, "刻录ToolStripMenuItem");
            // 
            // 新建文件夹ToolStripMenuItem
            // 
            this.新建文件夹ToolStripMenuItem.Name = "新建文件夹ToolStripMenuItem";
            resources.ApplyResources(this.新建文件夹ToolStripMenuItem, "新建文件夹ToolStripMenuItem");
            this.新建文件夹ToolStripMenuItem.Click += new System.EventHandler(this.新建文件夹ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCount});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabelCount
            // 
            this.toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            resources.ApplyResources(this.toolStripStatusLabelCount, "toolStripStatusLabelCount");
            // 
            // btnChangeView
            // 
            resources.ApplyResources(this.btnChangeView, "btnChangeView");
            this.btnChangeView.Name = "btnChangeView";
            this.btnChangeView.UseVisualStyleBackColor = true;
            this.btnChangeView.Click += new System.EventHandler(this.btnChangeView_Click);
            // 
            // myImagelistLarge
            // 
            this.myImagelistLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myImagelistLarge.ImageStream")));
            this.myImagelistLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.myImagelistLarge.Images.SetKeyName(0, "Icon_4.ico");
            this.myImagelistLarge.Images.SetKeyName(1, "Icon_15.ico");
            this.myImagelistLarge.Images.SetKeyName(2, "Icon_12.ico");
            this.myImagelistLarge.Images.SetKeyName(3, "Icon_126.ico");
            this.myImagelistLarge.Images.SetKeyName(4, "Icon_79.ico");
            this.myImagelistLarge.Images.SetKeyName(5, "Icon_32.ico");
            this.myImagelistLarge.Images.SetKeyName(6, "Icon_64.ico");
            // 
            // MyFileManeger
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnChangeView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.tvTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MyFileManeger";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsOperate.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvTree;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip cmsOperate;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发送到ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重命名RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 属性RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴VtoolStripMenuItem1;
        private System.Windows.Forms.ImageList myImageList;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cboxPath;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 组织ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切XToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 系统属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 卸载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刻录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建文件夹ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
        private System.Windows.Forms.Button btnChangeView;
        private System.Windows.Forms.ImageList myImagelistLarge;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 任务管理器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 桌面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的U盘ToolStripMenuItem;
        public System.Windows.Forms.ListView lvInfo;
    }
}


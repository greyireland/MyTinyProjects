using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test2
{
    public partial class MyNotepad : Form
    {
        public MyNotepad(string path)
        {
            InitializeComponent();
            richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
        }

        private void 页面设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form note = new Form();
            note.Text = "";
            
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "打开";
            dlg.Filter = "Text Files|*.txt|All File|*.*";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(dlg.FileName, RichTextBoxStreamType.PlainText);
            }
            
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedlg = new SaveFileDialog();
            savedlg.Title = "保存为";
            savedlg.Filter = "Text File|*.txt|All File |*.*";

            if (savedlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(savedlg.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedlg = new SaveFileDialog();
            savedlg.Title = "保存为";
            savedlg.Filter = "Text File|*.txt|All File |*.*";

            if (savedlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(savedlg.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void 字体TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontdlg = new FontDialog();

            fontdlg.ShowColor = true;

            if (fontdlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontdlg.Font;
                richTextBox1.SelectionColor = fontdlg.Color;
            }
        }

        private void 背景颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colordlg = new ColorDialog();
            colordlg.Color = Color.Black;
            colordlg.ShowDialog();

            richTextBox1.BackColor = colordlg.Color;
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
                richTextBox1.ClearUndo();
            }
        }

        private void 剪切XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    DialogResult result;
                    result = MessageBox.Show("你要覆盖吗？","确认覆盖",MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                    }
                    
                }

                richTextBox1.Paste();
            }
        }

        private void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText.Remove(0,richTextBox1.SelectionLength);
            richTextBox1.SelectedText = "";
        }

        private void 全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 撤销ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
                richTextBox1.ClearUndo();
            }

        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    DialogResult result;
                    result = MessageBox.Show("你要覆盖吗？", "确认覆盖", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                    }

                }

                richTextBox1.Paste();
            }
        }

        private void 打印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("未找到打印设备！");
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2About about = new Form2About();
            //about.Show();
        }
    }
}

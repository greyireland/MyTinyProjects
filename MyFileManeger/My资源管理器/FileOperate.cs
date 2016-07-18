using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using File = System.IO.File;
using IWshRuntimeLibrary;

namespace Test2
{
    public static class FileOperate
    {

        #region 复制文件夹到文件夹+CopyDirectory(string srcPath, string desPath)
        /// <summary>
        /// 复制文件夹到文件夹
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="desPath"></param>
        public static void CopyDirectory(string srcPath, string desPath)
        {
            string dirName = srcPath.Substring(srcPath.LastIndexOf("\\") + 1);
            string[] oldDirs = Directory.GetDirectories(desPath);
            foreach (string dir in oldDirs)
            {
                string dirName2 = dir.Substring(dir.LastIndexOf("\\") + 1);
                //重名了就不执行复制
                if (dirName == dirName2)
                {
                    MessageBox.Show("已存在该文件夹,你确定要覆盖原来的文件夹?");
                }
                //否则就复制文件夹
                else
                {
                    string newPath = desPath + "\\" + dirName;
                    DirectoryInfo newExistPath = Directory.CreateDirectory(newPath);
                    string[] filesAndDirs = Directory.GetFileSystemEntries(srcPath);
                    foreach (var fileOrDir in filesAndDirs)
                    {
                        //如果是目录
                        if (Directory.Exists(fileOrDir))
                        {
                            CopyDirectory(fileOrDir, desPath + "\\" + dirName);//d:\\testc\\game\\little
                        }
                        else 
                        {
                            string fileName = fileOrDir.Substring(fileOrDir.LastIndexOf("\\") + 1);
                            File.Copy(fileOrDir, desPath + "\\" + dirName + "\\" + fileName, true);
                        }

                    }
                }
            }


        } 
        #endregion

        #region 复制文件+CopyFile(string srcFilePath, string desFilePath)
        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="srcFilePath"></param>
        /// <param name="desFilePath"></param>
        public static void CopyFile(string srcFilePath, string desFilePath)
        {
            //覆盖同名的文件
            File.Copy(srcFilePath, desFilePath, true);
        } 
        #endregion

        #region 复制文件夹或者文件+Copy(string srcPath, string desPath)
        /// <summary>
        /// 复制文件夹或者文件
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="desPath"></param>
        public static void Copy(string srcPath, string desPath)
        {
            if (Directory.Exists(srcPath))
            {
                CopyDirectory(srcPath, desPath);
            }
            else
            {
                CopyFile(srcPath, desPath);
            }
        } 
        #endregion
        
        //重命名

        #region 新建文件夹+CreateFolder(string path)
        /// <summary>
        /// 新建文件夹
        /// </summary>
        /// <param name="path"></param>
        public static void CreateFolder(string path)
        {
            int flag = 0;
            if (Directory.Exists(path + "\\新建文件夹"))
            {
                flag++;
                //Directory.CreateDirectory(path + "\\新建文件夹(1)");
                for (var i = 0; i < 10; i++)
                {
                    if (Directory.Exists(path + "\\新建文件夹(" + (i+1) + ")"))
                    {
                        flag++;
                    }
                }
                if (flag > 0)
                {
                    Directory.CreateDirectory(path + "\\新建文件夹(" + flag + ")");
                }
            }
            else
            {
                Directory.CreateDirectory(path + "\\新建文件夹");
                flag++;
            }
            
        } 
        #endregion

        #region 删除文件夹+DeleteFolder(string path)
        /// <summary>
        /// 删除文件夹
        /// </summary>
        /// <param name="path"></param>
        public static void DeleteFolder(string path)
        {
            if (Directory.GetFiles(path) == null)
            {
                Directory.Delete(path);
            }
            else
            {
                //message提示用户是否删除
                Directory.Delete(path, true);
            }
        } 
        #endregion

        #region 删除文件+DeleteFile(string pathIncludeFileName)
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="pathIncludeFileName"></param>
        public static void DeleteFile(string pathIncludeFileName)
        {
            File.Delete(pathIncludeFileName);
        } 
        #endregion

        #region  删除文件夹或文件+Delete(string FileOrFolder)
        /// <summary>
        /// 删除文件夹或文件
        /// </summary>
        /// <param name="FileOrFolder"></param>
        public static void Delete(string FileOrFolder)
        {
            if (Directory.Exists(FileOrFolder))
            {
                DeleteFolder(FileOrFolder);
            }
            else
            {
                DeleteFile(FileOrFolder);
            }
            
        } 
        #endregion

        #region 创建桌面快捷方式+CreateDesktopShortcut(string srcPath, string objectName)
        /// <summary>
        /// 创建桌面快捷方式
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="objectName"></param>
        public static void CreateDesktopShortcut(string srcPath, string objectName)
        {
            string desktopPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShellClass();
            IWshRuntimeLibrary.WshShell shell = new WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(desktopPath + objectName + ".lnk");
            shortcut.TargetPath = srcPath;
            shortcut.Arguments = "";// 参数 
            shortcut.Description = "没有描述";
            
            shortcut.WorkingDirectory = srcPath;//程序所在文件夹，在快捷方式图标点击右键可以看到此属性 
            //shortcut.IconLocation = @"D:\software\cmpc\zy.exe,0";//图标 
            //shortcut.Hotkey = "CTRL+SHIFT+Z";//热键 
            shortcut.WindowStyle = 1;
            shortcut.Save();

        } 
        #endregion

    }
}

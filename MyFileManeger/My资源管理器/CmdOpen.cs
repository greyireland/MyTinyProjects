using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public static class CmdOpen
    {
        public static void mspaintCmd(string filePath)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            //string pingrst;
            p.Start();
            p.StandardInput.WriteLine("mspaint.exe "+filePath);
            p.StandardInput.WriteLine("exit");
            p.Close();
            
        }

        public static void EXECmd(string filePath)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            //string pingrst;
            p.Start();
            p.StandardInput.WriteLine(filePath);
            p.StandardInput.WriteLine("exit");
            p.Close();

        }
    }
}

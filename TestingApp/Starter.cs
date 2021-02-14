using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TestingApp
{
    public class Starter
    {
        public static string Run(string fileName, Data inputData)
        {
            var p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = fileName;
            p.StartInfo.Arguments = inputData.ToString();
            p.Start();
            StringBuilder YF = new StringBuilder();
            string buffer = string.Empty;
            char symb;
            while (!p.StandardOutput.EndOfStream)
            {
                symb = (char)p.StandardOutput.Peek();
                if (symb == '„')
                {
                    p.StandardInput.Write(ConsoleKey.Enter);
                    break;
                }
                buffer = p.StandardOutput.ReadLine();
                YF.AppendLine(buffer);
            }
            p.WaitForExit();
            return YF.Remove(YF.Length - 2, 2).ToString();
        }
    }
}

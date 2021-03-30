using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;                 //   cd C:\Windows\Microsoft.NET\Framework\v4.0.30319
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
namespace Bai2
{
    public partial class Bai2 : ServiceBase
    {
        Timer timer = new Timer();
        public Bai2()
        {
            InitializeComponent();
        }

        private void ProcessStatus(object source, ElapsedEventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("notepad");
            if (processes.Length > 0)
            {
                foreach (var process in processes)
                    process.Kill();
                WriteToFile("Process is killed at " + DateTime.Now);
            }
            else
            {
                Process.Start("notepad.exe");
                WriteToFile("Process starts at " + DateTime.Now);
            }
        }
        protected override void OnStart(string[] args)
        {
            WriteToFile("Service is started at " + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(ProcessStatus);
            timer.Interval = 3000; //number in miliseconds
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            WriteToFile("Service is stopped at " + DateTime.Now);
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            WriteToFile("Service is recall at " + DateTime.Now);

        }

        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory +
           "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') +
           ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to. 
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
        }
    }
}

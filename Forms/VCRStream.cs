using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMUTools.Forms
{
    public partial class VCRStream : Form
    {
        public VCRStream()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sInitialDir = "";

            if (Directory.Exists("F:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays")) { sInitialDir = "F:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays"; }
            else if (Directory.Exists("C:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays")) { sInitialDir = "C:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays"; }
            else if (Directory.Exists("D:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays")) { sInitialDir = "D:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays"; }
            else if (Directory.Exists("E:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays")) { sInitialDir = "E:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays"; }
            else if (Directory.Exists("C:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays")) { sInitialDir = "C:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays"; }
            else if (Directory.Exists("D:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays")) { sInitialDir = "D:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays"; }
            else if (Directory.Exists("E:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays")) { sInitialDir = "E:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays"; }
            else if (Directory.Exists("F:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays")) { sInitialDir = "F:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Replays"; }
            else if (Directory.Exists("C:\\Le Mans Ultimate\\UserData\\Replays")) { sInitialDir = "C:\\Le Mans Ultimate\\UserData\\Replays"; }
            else if (Directory.Exists("D:\\Le Mans Ultimate\\UserData\\Replays")) { sInitialDir = "D:\\Le Mans Ultimate\\UserData\\Replays"; }
            else if (Directory.Exists("E:\\Le Mans Ultimate\\UserData\\Replays")) { sInitialDir = "E:\\Le Mans Ultimate\\UserData\\Replays"; }
            else if (Directory.Exists("F:\\Le Mans Ultimate\\UserData\\Replays")) { sInitialDir = "F:\\Le Mans Ultimate\\UserData\\Replays"; }

            if (sInitialDir.Length > 0) { ofdResultFile.InitialDirectory = sInitialDir; }
            ofdResultFile.Title = "Select tmp vcr file";
            ofdResultFile.Multiselect = false;
            ofdResultFile.CheckFileExists = true;
            ofdResultFile.Filter = "tmp|*.tmp";

            if (ofdResultFile.ShowDialog() == DialogResult.OK && txtFile.Text != ofdResultFile.SafeFileName)
            {
                txtFile.Text = ofdResultFile.FileName;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            /*var wh = new AutoResetEvent(false);
            var fsw = new FileSystemWatcher(".");
            fsw.Filter = txtFile.Text;
            fsw.EnableRaisingEvents = true;
            fsw.Changed += (s, e) => wh.Set();

            var fs = new FileStream(txtFile.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using (var sr = new StreamReader(fs))
            {
                var s = "";
                while (true)
                {
                    s = sr.ReadLine();
                    if (s != null)
                        txtConsole.Text = s;
                    else
                        wh.WaitOne(100);
                }
            }

            wh.Close();*/

            MonitorTailOfFile(txtFile.Text);
            
        }

        public void MonitorTailOfFile(string filePath)
        {
            var initialFileSize = new FileInfo(filePath).Length;
            var lastReadLength = initialFileSize - 1024;
            if (lastReadLength < 0) lastReadLength = 0;

            while (true)
            {

                    var fileSize = new FileInfo(filePath).Length;
                    if (fileSize > lastReadLength)
                    {
                        using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            fs.Seek(lastReadLength, SeekOrigin.Begin);
                            var buffer = new byte[1024];

                            while (true)
                            {
                                var bytesRead = fs.Read(buffer, 0, buffer.Length);
                                lastReadLength += bytesRead;

                                if (bytesRead == 0) {  break; } 
 
                                //var text = ASCIIEncoding.ASCII.GetString(buffer, 0, bytesRead);

                                //Console.Write(text);
                               // txtConsole.Text = text;


                            using (FileStream data = new FileStream("F:\\test.vcr", FileMode.Append))
                            {
                                data.Write(buffer);
                            }

                        }
                        }
                    }


                Thread.Sleep(1000);
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MW2_Stats_Saver_2._0
{
    public partial class Main : Form
    {
        bool pathsAreSet = Properties.Settings.Default.pathsAreSet;
        String steamFolderPath = Properties.Settings.Default.steamFolderPath;
        String saveFolderPath = Properties.Settings.Default.saveFolderPath;

        String MW2PlayersFolder;
        String userdataFolder;

        public Main()
        {
            InitializeComponent();

            if (!pathsAreSet)
            {
                Settings s = new Settings();
                if (s.ShowDialog() == DialogResult.OK)
                {
                    steamFolderPath = Properties.Settings.Default.steamFolderPath;
                    saveFolderPath = Properties.Settings.Default.saveFolderPath;

                    MW2PlayersFolder = steamFolderPath + @"\steamapps\common\call of duty modern warfare 2\players";
                    userdataFolder = steamFolderPath + @"\userdata";

                    saveManuallyButton.Enabled = true;
                }
            }

            MW2PlayersFolder = steamFolderPath + @"\steamapps\common\call of duty modern warfare 2\players";
            userdataFolder = steamFolderPath + @"\userdata";

            saveManuallyButton.Enabled = true;

            processTimer.Start();
        }

        public void LogAppend(string s)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            logTextBox.AppendText("[" + dt.ToShortDateString() + " " + dt.ToShortTimeString() + "] " + s + "\r\n");
        }

        public void CopyFolder(String srcFolder, String destFolder)
        {
            if (!Directory.Exists(destFolder))
            {
                Directory.CreateDirectory(destFolder);
            }

            String[] files = Directory.GetFiles(srcFolder);
            foreach (String file in files)
            {
                String name = Path.GetFileName(file);
                String dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }

            String[] folders = Directory.GetDirectories(srcFolder);
            foreach (String folder in folders)
            {
                String name = Path.GetFileName(folder);
                String dest = Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
            }
        }

        public void PerformSave()
        {
            DateTime now = DateTime.Now;
            String date = now.ToShortDateString();
            String time = now.Hour + "." + now.Minute;
            String statsFolderPath = saveFolderPath + "\\" + date + " " + time;

            LogAppend("------------");
            LogAppend("Saving...");

            if (Directory.Exists(statsFolderPath)) 
            {
                statsFolderPath += now.Second;
            }
            try
            {
                Directory.CreateDirectory(statsFolderPath);
            }
            catch (Exception e)
            {
                LogAppend(e.Message);
            }

            try
            {
                CopyFolder(MW2PlayersFolder, statsFolderPath + @"\players");
                LogAppend("Players folder saved.");
                CopyFolder(userdataFolder, statsFolderPath + @"\userdata");
                LogAppend("Userdata folder saved.");
            }
            catch (Exception e)
            {
                LogAppend("Error: " + e.Message);
            }
        }

        public bool CheckForCOD()
        {
            Process[] process = Process.GetProcesses();
            foreach (Process p in process)
            {
                if (p.ProcessName.Equals("iw4mp"))
                {
                    return true;
                }
            }
            return false;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            if (s.ShowDialog() == DialogResult.OK)
            {
                if (!(steamFolderPath.Equals(Properties.Settings.Default.steamFolderPath)) || !(saveFolderPath.Equals(Properties.Settings.Default.saveFolderPath)))
                {
                    LogAppend("Paths updated.");
                    LogAppend("New paths are:");
                    LogAppend(Properties.Settings.Default.steamFolderPath);
                    LogAppend(Properties.Settings.Default.saveFolderPath);
                    steamFolderPath = Properties.Settings.Default.steamFolderPath;
                    saveFolderPath = Properties.Settings.Default.saveFolderPath;
                }
            }
        }

        private void saveManuallyButton_Click(object sender, EventArgs e)
        {
            PerformSave();
        }

        private void processTimer_Tick(object sender, EventArgs e)
        {
            if (CheckForCOD())
            {
            }
        }
    }
}

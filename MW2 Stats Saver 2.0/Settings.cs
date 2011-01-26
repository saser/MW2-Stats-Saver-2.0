using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MW2_Stats_Saver_2._0
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            steamPathBox.Text = Properties.Settings.Default.steamFolderPath;
            savePathBox.Text = Properties.Settings.Default.saveFolderPath;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.steamFolderPath = steamPathBox.Text;
            Properties.Settings.Default.saveFolderPath = savePathBox.Text;
            Properties.Settings.Default.pathsAreSet = true;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void steamFolderButton_Click(object sender, EventArgs e)
        {
            if (steamFolderDialog.ShowDialog() == DialogResult.OK)
            {
                steamPathBox.Text = steamFolderDialog.SelectedPath;
            }
        }

        private void saveFolderButton_Click(object sender, EventArgs e)
        {
            if (saveFolderDialog.ShowDialog() == DialogResult.OK)
            {
                savePathBox.Text = saveFolderDialog.SelectedPath;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

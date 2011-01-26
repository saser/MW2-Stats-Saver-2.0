namespace MW2_Stats_Saver_2._0
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.steamPathBox = new System.Windows.Forms.TextBox();
            this.savePathBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.steamFolderButton = new System.Windows.Forms.Button();
            this.saveFolderButton = new System.Windows.Forms.Button();
            this.steamFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Steam folder:";
            // 
            // steamPathBox
            // 
            this.steamPathBox.Location = new System.Drawing.Point(87, 6);
            this.steamPathBox.Name = "steamPathBox";
            this.steamPathBox.Size = new System.Drawing.Size(100, 20);
            this.steamPathBox.TabIndex = 2;
            // 
            // savePathBox
            // 
            this.savePathBox.Location = new System.Drawing.Point(87, 32);
            this.savePathBox.Name = "savePathBox";
            this.savePathBox.Size = new System.Drawing.Size(100, 20);
            this.savePathBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Save folder:";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(12, 58);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(101, 23);
            this.saveSettingsButton.TabIndex = 5;
            this.saveSettingsButton.Text = "Done";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(119, 58);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // steamFolderButton
            // 
            this.steamFolderButton.Location = new System.Drawing.Point(193, 6);
            this.steamFolderButton.Name = "steamFolderButton";
            this.steamFolderButton.Size = new System.Drawing.Size(27, 20);
            this.steamFolderButton.TabIndex = 7;
            this.steamFolderButton.Text = "...";
            this.steamFolderButton.UseVisualStyleBackColor = true;
            this.steamFolderButton.Click += new System.EventHandler(this.steamFolderButton_Click);
            // 
            // saveFolderButton
            // 
            this.saveFolderButton.Location = new System.Drawing.Point(193, 32);
            this.saveFolderButton.Name = "saveFolderButton";
            this.saveFolderButton.Size = new System.Drawing.Size(27, 20);
            this.saveFolderButton.TabIndex = 8;
            this.saveFolderButton.Text = "...";
            this.saveFolderButton.UseVisualStyleBackColor = true;
            this.saveFolderButton.Click += new System.EventHandler(this.saveFolderButton_Click);
            // 
            // steamFolderDialog
            // 
            this.steamFolderDialog.Description = "Select the Steam folder";
            this.steamFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.steamFolderDialog.ShowNewFolderButton = false;
            // 
            // saveFolderDialog
            // 
            this.saveFolderDialog.Description = "Select where your stats will be saved";
            // 
            // Settings
            // 
            this.AcceptButton = this.saveSettingsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(232, 88);
            this.Controls.Add(this.saveFolderButton);
            this.Controls.Add(this.steamFolderButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.savePathBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.steamPathBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox steamPathBox;
        private System.Windows.Forms.TextBox savePathBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button steamFolderButton;
        private System.Windows.Forms.Button saveFolderButton;
        private System.Windows.Forms.FolderBrowserDialog steamFolderDialog;
        private System.Windows.Forms.FolderBrowserDialog saveFolderDialog;
    }
}
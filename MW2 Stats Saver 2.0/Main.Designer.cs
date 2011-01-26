namespace MW2_Stats_Saver_2._0
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.saveManuallyButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.processTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // saveManuallyButton
            // 
            this.saveManuallyButton.Enabled = false;
            this.saveManuallyButton.Location = new System.Drawing.Point(13, 13);
            this.saveManuallyButton.Name = "saveManuallyButton";
            this.saveManuallyButton.Size = new System.Drawing.Size(259, 23);
            this.saveManuallyButton.TabIndex = 0;
            this.saveManuallyButton.Text = "Save manually";
            this.saveManuallyButton.UseVisualStyleBackColor = true;
            this.saveManuallyButton.Click += new System.EventHandler(this.saveManuallyButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(13, 43);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(259, 23);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.logTextBox.Location = new System.Drawing.Point(13, 73);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(259, 177);
            this.logTextBox.TabIndex = 2;
            // 
            // processTimer
            // 
            this.processTimer.Interval = 5000;
            this.processTimer.Tick += new System.EventHandler(this.processTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.saveManuallyButton);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Main";
            this.Text = "MW2 Stats Saver 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveManuallyButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Timer processTimer;
    }
}


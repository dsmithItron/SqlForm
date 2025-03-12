namespace SqlForm.Forms
{
    partial class SettingsForm
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
            profileHeaderLabel = new Label();
            profilePanel = new Panel();
            profileBox = new TextBox();
            optionsPanel = new Panel();
            profileOptionsPanel = new Panel();
            ConnectStringBox = new TextBox();
            defaultSettingsRadio = new RadioButton();
            defaultConnectionRadio = new RadioButton();
            profileQueryHistory = new Panel();
            panel1 = new Panel();
            profilePanel.SuspendLayout();
            profileOptionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // profileHeaderLabel
            // 
            profileHeaderLabel.BackColor = SystemColors.ActiveBorder;
            profileHeaderLabel.Dock = DockStyle.Top;
            profileHeaderLabel.Location = new Point(0, 0);
            profileHeaderLabel.Margin = new Padding(0);
            profileHeaderLabel.Name = "profileHeaderLabel";
            profileHeaderLabel.Size = new Size(800, 23);
            profileHeaderLabel.TabIndex = 0;
            profileHeaderLabel.Text = "Profile";
            profileHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profilePanel
            // 
            profilePanel.BackColor = SystemColors.ActiveCaption;
            profilePanel.Controls.Add(profileBox);
            profilePanel.Dock = DockStyle.Left;
            profilePanel.Location = new Point(0, 23);
            profilePanel.Margin = new Padding(0);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(192, 427);
            profilePanel.TabIndex = 1;
            // 
            // profileBox
            // 
            profileBox.Location = new Point(12, 12);
            profileBox.Name = "profileBox";
            profileBox.Size = new Size(120, 23);
            profileBox.TabIndex = 0;
            profileBox.TextChanged += profileBox_TextChanged;
            // 
            // optionsPanel
            // 
            optionsPanel.BackColor = Color.Turquoise;
            optionsPanel.Dock = DockStyle.Fill;
            optionsPanel.Location = new Point(192, 23);
            optionsPanel.Margin = new Padding(0);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.Size = new Size(608, 427);
            optionsPanel.TabIndex = 2;
            // 
            // profileOptionsPanel
            // 
            profileOptionsPanel.AutoSize = true;
            profileOptionsPanel.BackColor = SystemColors.AppWorkspace;
            profileOptionsPanel.Controls.Add(ConnectStringBox);
            profileOptionsPanel.Controls.Add(defaultSettingsRadio);
            profileOptionsPanel.Controls.Add(defaultConnectionRadio);
            profileOptionsPanel.Location = new Point(254, 23);
            profileOptionsPanel.Name = "profileOptionsPanel";
            profileOptionsPanel.Size = new Size(305, 421);
            profileOptionsPanel.TabIndex = 0;
            profileOptionsPanel.Visible = false;
            // 
            // ConnectStringBox
            // 
            ConnectStringBox.Location = new Point(3, 65);
            ConnectStringBox.Margin = new Padding(0);
            ConnectStringBox.Name = "ConnectStringBox";
            ConnectStringBox.Size = new Size(281, 23);
            ConnectStringBox.TabIndex = 2;
            // 
            // defaultSettingsRadio
            // 
            defaultSettingsRadio.AutoSize = true;
            defaultSettingsRadio.BackColor = Color.Transparent;
            defaultSettingsRadio.Checked = true;
            defaultSettingsRadio.Dock = DockStyle.Top;
            defaultSettingsRadio.Location = new Point(0, 0);
            defaultSettingsRadio.Margin = new Padding(0);
            defaultSettingsRadio.Name = "defaultSettingsRadio";
            defaultSettingsRadio.Size = new Size(305, 19);
            defaultSettingsRadio.TabIndex = 1;
            defaultSettingsRadio.TabStop = true;
            defaultSettingsRadio.Text = "Use Default Settings";
            defaultSettingsRadio.TextAlign = ContentAlignment.MiddleCenter;
            defaultSettingsRadio.UseVisualStyleBackColor = false;
            // 
            // defaultConnectionRadio
            // 
            defaultConnectionRadio.AutoSize = true;
            defaultConnectionRadio.Location = new Point(3, 46);
            defaultConnectionRadio.Margin = new Padding(0);
            defaultConnectionRadio.Name = "defaultConnectionRadio";
            defaultConnectionRadio.Size = new Size(150, 19);
            defaultConnectionRadio.TabIndex = 0;
            defaultConnectionRadio.TabStop = true;
            defaultConnectionRadio.Text = "Use Default Connection";
            defaultConnectionRadio.UseVisualStyleBackColor = true;
            // 
            // profileQueryHistory
            // 
            profileQueryHistory.AutoSize = true;
            profileQueryHistory.BackColor = SystemColors.ButtonShadow;
            profileQueryHistory.Dock = DockStyle.Right;
            profileQueryHistory.Location = new Point(800, 23);
            profileQueryHistory.Margin = new Padding(0);
            profileQueryHistory.Name = "profileQueryHistory";
            profileQueryHistory.Size = new Size(0, 427);
            profileQueryHistory.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(600, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 427);
            panel1.TabIndex = 1;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(profileQueryHistory);
            Controls.Add(profileOptionsPanel);
            Controls.Add(optionsPanel);
            Controls.Add(profilePanel);
            Controls.Add(profileHeaderLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            Text = "SettingsForm";
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            profileOptionsPanel.ResumeLayout(false);
            profileOptionsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label profileHeaderLabel;
        private Panel profilePanel;
        private Panel optionsPanel;
        private Panel profileQueryHistory;
        private Panel profileOptionsPanel;
        private RadioButton defaultConnectionRadio;
        private RadioButton defaultSettingsRadio;
        private TextBox ConnectStringBox;
        private TextBox profileBox;
        private Panel panel1;
    }
}
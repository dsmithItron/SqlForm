namespace SqlForm
{
    partial class SqlForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlForm));
            SidebarPanel = new Panel();
            SelectSidebarButton = new Button();
            DeleteSidebarButton = new Button();
            InsertSidebarButton = new Button();
            UpdateSidebarButton = new Button();
            TopSidebarPanel = new Panel();
            PanelTop = new Panel();
            HeaderLabel = new Label();
            PanelDesktop = new Panel();
            SidebarPanel.SuspendLayout();
            PanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.FromArgb(3, 64, 107);
            SidebarPanel.Controls.Add(SelectSidebarButton);
            SidebarPanel.Controls.Add(DeleteSidebarButton);
            SidebarPanel.Controls.Add(InsertSidebarButton);
            SidebarPanel.Controls.Add(UpdateSidebarButton);
            SidebarPanel.Controls.Add(TopSidebarPanel);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 0);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(180, 512);
            SidebarPanel.TabIndex = 0;
            // 
            // SelectSidebarButton
            // 
            SelectSidebarButton.FlatAppearance.BorderSize = 0;
            SelectSidebarButton.FlatStyle = FlatStyle.Flat;
            SelectSidebarButton.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectSidebarButton.ForeColor = Color.White;
            SelectSidebarButton.Image = (Image)resources.GetObject("SelectSidebarButton.Image");
            SelectSidebarButton.ImageAlign = ContentAlignment.MiddleLeft;
            SelectSidebarButton.Location = new Point(0, 67);
            SelectSidebarButton.Margin = new Padding(0);
            SelectSidebarButton.Name = "SelectSidebarButton";
            SelectSidebarButton.Size = new Size(180, 60);
            SelectSidebarButton.TabIndex = 4;
            SelectSidebarButton.Text = "Select";
            SelectSidebarButton.UseVisualStyleBackColor = true;
            SelectSidebarButton.Click += SelectSidebarButton_Click;
            // 
            // DeleteSidebarButton
            // 
            DeleteSidebarButton.FlatAppearance.BorderSize = 0;
            DeleteSidebarButton.FlatStyle = FlatStyle.Flat;
            DeleteSidebarButton.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSidebarButton.ForeColor = Color.White;
            DeleteSidebarButton.Image = (Image)resources.GetObject("DeleteSidebarButton.Image");
            DeleteSidebarButton.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteSidebarButton.Location = new Point(0, 187);
            DeleteSidebarButton.Margin = new Padding(0);
            DeleteSidebarButton.Name = "DeleteSidebarButton";
            DeleteSidebarButton.Size = new Size(180, 60);
            DeleteSidebarButton.TabIndex = 3;
            DeleteSidebarButton.Text = "Delete";
            DeleteSidebarButton.UseVisualStyleBackColor = true;
            DeleteSidebarButton.Click += DeleteSidebarButton_Click;
            // 
            // InsertSidebarButton
            // 
            InsertSidebarButton.FlatAppearance.BorderSize = 0;
            InsertSidebarButton.FlatStyle = FlatStyle.Flat;
            InsertSidebarButton.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InsertSidebarButton.ForeColor = Color.White;
            InsertSidebarButton.Image = (Image)resources.GetObject("InsertSidebarButton.Image");
            InsertSidebarButton.ImageAlign = ContentAlignment.MiddleLeft;
            InsertSidebarButton.Location = new Point(0, 127);
            InsertSidebarButton.Margin = new Padding(0);
            InsertSidebarButton.Name = "InsertSidebarButton";
            InsertSidebarButton.Size = new Size(180, 60);
            InsertSidebarButton.TabIndex = 2;
            InsertSidebarButton.Text = "Insert";
            InsertSidebarButton.UseVisualStyleBackColor = true;
            InsertSidebarButton.Click += InsertSidebarButton_Click;
            // 
            // UpdateSidebarButton
            // 
            UpdateSidebarButton.FlatAppearance.BorderSize = 0;
            UpdateSidebarButton.FlatStyle = FlatStyle.Flat;
            UpdateSidebarButton.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateSidebarButton.ForeColor = Color.White;
            UpdateSidebarButton.Image = (Image)resources.GetObject("UpdateSidebarButton.Image");
            UpdateSidebarButton.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateSidebarButton.Location = new Point(0, 247);
            UpdateSidebarButton.Margin = new Padding(0);
            UpdateSidebarButton.Name = "UpdateSidebarButton";
            UpdateSidebarButton.Size = new Size(180, 60);
            UpdateSidebarButton.TabIndex = 1;
            UpdateSidebarButton.Text = "Update";
            UpdateSidebarButton.UseVisualStyleBackColor = true;
            UpdateSidebarButton.Click += UpdateSidebarButton_Click;
            // 
            // TopSidebarPanel
            // 
            TopSidebarPanel.BackColor = Color.FromArgb(2, 49, 82);
            TopSidebarPanel.Dock = DockStyle.Top;
            TopSidebarPanel.Location = new Point(0, 0);
            TopSidebarPanel.Name = "TopSidebarPanel";
            TopSidebarPanel.Size = new Size(180, 67);
            TopSidebarPanel.TabIndex = 0;
            // 
            // PanelTop
            // 
            PanelTop.BackColor = Color.LightSeaGreen;
            PanelTop.Controls.Add(HeaderLabel);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(180, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(904, 67);
            PanelTop.TabIndex = 2;
            // 
            // HeaderLabel
            // 
            HeaderLabel.BackColor = Color.Transparent;
            HeaderLabel.Dock = DockStyle.Fill;
            HeaderLabel.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = Color.White;
            HeaderLabel.Location = new Point(0, 0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(904, 67);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelDesktop
            // 
            PanelDesktop.BackColor = Color.WhiteSmoke;
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(180, 67);
            PanelDesktop.Margin = new Padding(0);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Padding = new Padding(10);
            PanelDesktop.Size = new Size(904, 445);
            PanelDesktop.TabIndex = 3;
            // 
            // SqlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 512);
            Controls.Add(PanelDesktop);
            Controls.Add(PanelTop);
            Controls.Add(SidebarPanel);
            Name = "SqlForm";
            Text = "SQL Form";
            SidebarPanel.ResumeLayout(false);
            PanelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel SidebarPanel;
        private Panel PanelTop;
        private Panel PanelDesktop;
        private Panel TopSidebarPanel;
        private Button UpdateSidebarButton;
        private Button InsertSidebarButton;
        private Button DeleteSidebarButton;
        private Button SelectSidebarButton;
        private Label HeaderLabel;
    }
}

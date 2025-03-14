namespace SqlForm.Forms
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            headerPanel = new Panel();
            resultFormLabel = new Label();
            footerPanel = new Panel();
            goBackButton = new Button();
            continueButton = new Button();
            resultDataGrid = new DataGridView();
            headerPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultDataGrid).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = SystemColors.Control;
            headerPanel.Controls.Add(resultFormLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(784, 65);
            headerPanel.TabIndex = 0;
            // 
            // resultFormLabel
            // 
            resultFormLabel.Dock = DockStyle.Fill;
            resultFormLabel.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultFormLabel.Location = new Point(0, 0);
            resultFormLabel.Margin = new Padding(0);
            resultFormLabel.Name = "resultFormLabel";
            resultFormLabel.Size = new Size(784, 65);
            resultFormLabel.TabIndex = 0;
            resultFormLabel.Text = "Error";
            resultFormLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = SystemColors.Control;
            footerPanel.Controls.Add(goBackButton);
            footerPanel.Controls.Add(continueButton);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 329);
            footerPanel.Margin = new Padding(0);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(784, 53);
            footerPanel.TabIndex = 2;
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.DeepSkyBlue;
            goBackButton.FlatAppearance.BorderSize = 0;
            goBackButton.FlatStyle = FlatStyle.Flat;
            goBackButton.Image = (Image)resources.GetObject("goBackButton.Image");
            goBackButton.ImageAlign = ContentAlignment.MiddleLeft;
            goBackButton.Location = new Point(12, 18);
            goBackButton.MaximumSize = new Size(120, 35);
            goBackButton.MinimumSize = new Size(75, 23);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(120, 23);
            goBackButton.TabIndex = 1;
            goBackButton.Text = "Go Back ";
            goBackButton.UseVisualStyleBackColor = false;
            // 
            // continueButton
            // 
            continueButton.Anchor = AnchorStyles.None;
            continueButton.FlatAppearance.BorderSize = 0;
            continueButton.FlatStyle = FlatStyle.Flat;
            continueButton.Location = new Point(356, 18);
            continueButton.MaximumSize = new Size(120, 35);
            continueButton.MinimumSize = new Size(75, 23);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(75, 23);
            continueButton.TabIndex = 0;
            continueButton.Text = "Continue?";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += ContinueButton_Click;
            // 
            // resultDataGrid
            // 
            resultDataGrid.AllowUserToAddRows = false;
            resultDataGrid.AllowUserToDeleteRows = false;
            resultDataGrid.AllowUserToResizeColumns = false;
            resultDataGrid.AllowUserToResizeRows = false;
            resultDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            resultDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            resultDataGrid.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "\"Null\"";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            resultDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resultDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            resultDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            resultDataGrid.Dock = DockStyle.Fill;
            resultDataGrid.Location = new Point(0, 65);
            resultDataGrid.Margin = new Padding(0);
            resultDataGrid.Name = "resultDataGrid";
            resultDataGrid.ReadOnly = true;
            resultDataGrid.ShowEditingIcon = false;
            resultDataGrid.Size = new Size(784, 264);
            resultDataGrid.TabIndex = 0;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 382);
            Controls.Add(resultDataGrid);
            Controls.Add(footerPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultForm";
            Text = "ResultForm";
            headerPanel.ResumeLayout(false);
            footerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resultDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Panel footerPanel;
        private Button continueButton;
        private Label resultFormLabel;
        private Button goBackButton;
        private DataGridView resultDataGrid;
    }
}
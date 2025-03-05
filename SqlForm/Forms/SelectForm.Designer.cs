namespace SqlForm.Forms
{
    partial class SelectForm
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
            SubmitAllButton = new Button();
            selectTable = new DataGridView();
            panel1 = new Panel();
            AddLeftCondition = new Button();
            FieldDropdown = new ComboBox();
            AddMiddleCondition = new Button();
            AddRightCondition = new Button();
            LeftConditionDropdown = new ComboBox();
            MiddleConditionDropdown = new ComboBox();
            RightConditionDropdown = new ComboBox();
            SubmitConditionSelection = new Button();
            SubmitFieldSelection = new Button();
            SqlTableDropdown = new ComboBox();
            ChooseTableLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)selectTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitAllButton
            // 
            SubmitAllButton.Location = new Point(351, 399);
            SubmitAllButton.Name = "SubmitAllButton";
            SubmitAllButton.Size = new Size(142, 39);
            SubmitAllButton.TabIndex = 1;
            SubmitAllButton.Text = "Finish Query Creation";
            SubmitAllButton.UseVisualStyleBackColor = true;
            SubmitAllButton.Visible = false;
            SubmitAllButton.Click += SubmitButton_Click;
            // 
            // selectTable
            // 
            selectTable.AllowUserToAddRows = false;
            selectTable.AllowUserToDeleteRows = false;
            selectTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectTable.Location = new Point(12, 12);
            selectTable.Name = "selectTable";
            selectTable.ReadOnly = true;
            selectTable.Size = new Size(776, 397);
            selectTable.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(AddLeftCondition);
            panel1.Controls.Add(FieldDropdown);
            panel1.Controls.Add(AddMiddleCondition);
            panel1.Controls.Add(AddRightCondition);
            panel1.Controls.Add(LeftConditionDropdown);
            panel1.Controls.Add(MiddleConditionDropdown);
            panel1.Controls.Add(RightConditionDropdown);
            panel1.Controls.Add(SubmitConditionSelection);
            panel1.Controls.Add(SubmitFieldSelection);
            panel1.Controls.Add(SqlTableDropdown);
            panel1.Controls.Add(ChooseTableLabel);
            panel1.Controls.Add(SubmitAllButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 3;
            // 
            // AddLeftCondition
            // 
            AddLeftCondition.Location = new Point(207, 174);
            AddLeftCondition.Name = "AddLeftCondition";
            AddLeftCondition.Size = new Size(53, 23);
            AddLeftCondition.TabIndex = 12;
            AddLeftCondition.Text = "Add";
            AddLeftCondition.UseVisualStyleBackColor = true;
            AddLeftCondition.Visible = false;
            // 
            // FieldDropdown
            // 
            FieldDropdown.FormattingEnabled = true;
            FieldDropdown.Location = new Point(372, 97);
            FieldDropdown.Name = "FieldDropdown";
            FieldDropdown.Size = new Size(121, 23);
            FieldDropdown.TabIndex = 11;
            FieldDropdown.Visible = false;
            // 
            // AddMiddleCondition
            // 
            AddMiddleCondition.Location = new Point(311, 174);
            AddMiddleCondition.Name = "AddMiddleCondition";
            AddMiddleCondition.Size = new Size(45, 23);
            AddMiddleCondition.TabIndex = 10;
            AddMiddleCondition.Text = "Add";
            AddMiddleCondition.UseVisualStyleBackColor = true;
            AddMiddleCondition.Visible = false;
            // 
            // AddRightCondition
            // 
            AddRightCondition.Location = new Point(405, 174);
            AddRightCondition.Name = "AddRightCondition";
            AddRightCondition.Size = new Size(53, 23);
            AddRightCondition.TabIndex = 9;
            AddRightCondition.Text = "Add";
            AddRightCondition.UseVisualStyleBackColor = true;
            AddRightCondition.Visible = false;
            // 
            // LeftConditionDropdown
            // 
            LeftConditionDropdown.FormattingEnabled = true;
            LeftConditionDropdown.Location = new Point(170, 145);
            LeftConditionDropdown.Name = "LeftConditionDropdown";
            LeftConditionDropdown.Size = new Size(121, 23);
            LeftConditionDropdown.TabIndex = 8;
            LeftConditionDropdown.Visible = false;
            // 
            // MiddleConditionDropdown
            // 
            MiddleConditionDropdown.FormattingEnabled = true;
            MiddleConditionDropdown.Location = new Point(297, 145);
            MiddleConditionDropdown.Name = "MiddleConditionDropdown";
            MiddleConditionDropdown.Size = new Size(69, 23);
            MiddleConditionDropdown.TabIndex = 7;
            MiddleConditionDropdown.Visible = false;
            // 
            // RightConditionDropdown
            // 
            RightConditionDropdown.FormattingEnabled = true;
            RightConditionDropdown.Location = new Point(372, 145);
            RightConditionDropdown.Name = "RightConditionDropdown";
            RightConditionDropdown.Size = new Size(121, 23);
            RightConditionDropdown.TabIndex = 6;
            RightConditionDropdown.Visible = false;
            // 
            // SubmitConditionSelection
            // 
            SubmitConditionSelection.Location = new Point(499, 145);
            SubmitConditionSelection.Name = "SubmitConditionSelection";
            SubmitConditionSelection.Size = new Size(75, 23);
            SubmitConditionSelection.TabIndex = 5;
            SubmitConditionSelection.Text = "Submit";
            SubmitConditionSelection.UseVisualStyleBackColor = true;
            SubmitConditionSelection.Visible = false;
            SubmitConditionSelection.Click += SubmitConditionSelection_Click;
            // 
            // SubmitFieldSelection
            // 
            SubmitFieldSelection.Location = new Point(499, 96);
            SubmitFieldSelection.Name = "SubmitFieldSelection";
            SubmitFieldSelection.Size = new Size(75, 23);
            SubmitFieldSelection.TabIndex = 4;
            SubmitFieldSelection.Text = "Submit";
            SubmitFieldSelection.UseVisualStyleBackColor = true;
            SubmitFieldSelection.Visible = false;
            SubmitFieldSelection.Click += SubmitFieldSelection_Click;
            // 
            // SqlTableDropdown
            // 
            SqlTableDropdown.FormattingEnabled = true;
            SqlTableDropdown.Location = new Point(95, 31);
            SqlTableDropdown.Name = "SqlTableDropdown";
            SqlTableDropdown.Size = new Size(121, 23);
            SqlTableDropdown.TabIndex = 3;
            SqlTableDropdown.SelectedValueChanged += SqlTableDropdown_SelectedValueChanged;
            // 
            // ChooseTableLabel
            // 
            ChooseTableLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChooseTableLabel.Location = new Point(31, 31);
            ChooseTableLabel.Name = "ChooseTableLabel";
            ChooseTableLabel.Size = new Size(67, 27);
            ChooseTableLabel.TabIndex = 2;
            ChooseTableLabel.Text = "Table: ";
            // 
            // SelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(selectTable);
            Name = "SelectForm";
            Text = "SelectForm";
            ((System.ComponentModel.ISupportInitialize)selectTable).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button SubmitAllButton;
        private DataGridView selectTable;
        private Panel panel1;
        private Label ChooseTableLabel;
        private ComboBox SqlTableDropdown;
        private Button SubmitConditionSelection;
        private Button SubmitFieldSelection;
        private ComboBox RightConditionDropdown;
        private Button AddMiddleCondition;
        private Button AddRightCondition;
        private ComboBox LeftConditionDropdown;
        private ComboBox MiddleConditionDropdown;
        private ComboBox FieldDropdown;
        private Button AddLeftCondition;
    }
}
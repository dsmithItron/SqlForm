namespace SqlForm
{
    partial class UpdateForm
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
            ChooseTableLabel = new Label();
            SqlTableDropdown = new ComboBox();
            FieldDropdown = new ComboBox();
            submitFieldSelection = new Button();
            submitConditionSelection = new Button();
            LeftConditionDropdown = new ComboBox();
            MiddleConditionDropdown = new ComboBox();
            RightConditionDropdown = new ComboBox();
            manualQueryButton = new Button();
            viewQueryButton = new Button();
            updateValueBox = new TextBox();
            SubmitAllButton = new Button();
            selectTable = new DataGridView();
            continueButton = new Button();
            ((System.ComponentModel.ISupportInitialize)selectTable).BeginInit();
            SuspendLayout();
            // 
            // ChooseTableLabel
            // 
            ChooseTableLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChooseTableLabel.Location = new Point(12, 9);
            ChooseTableLabel.Name = "ChooseTableLabel";
            ChooseTableLabel.Size = new Size(67, 27);
            ChooseTableLabel.TabIndex = 3;
            ChooseTableLabel.Text = "Table: ";
            // 
            // SqlTableDropdown
            // 
            SqlTableDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            SqlTableDropdown.FormattingEnabled = true;
            SqlTableDropdown.Location = new Point(72, 9);
            SqlTableDropdown.Name = "SqlTableDropdown";
            SqlTableDropdown.Size = new Size(202, 23);
            SqlTableDropdown.TabIndex = 4;
            SqlTableDropdown.SelectedValueChanged += SqlTableDropdown_SelectedValueChanged;
            // 
            // FieldDropdown
            // 
            FieldDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            FieldDropdown.FormattingEnabled = true;
            FieldDropdown.Location = new Point(87, 48);
            FieldDropdown.Name = "FieldDropdown";
            FieldDropdown.Size = new Size(121, 23);
            FieldDropdown.TabIndex = 12;
            FieldDropdown.Visible = false;
            // 
            // submitFieldSelection
            // 
            submitFieldSelection.Location = new Point(341, 48);
            submitFieldSelection.Name = "submitFieldSelection";
            submitFieldSelection.Size = new Size(75, 25);
            submitFieldSelection.TabIndex = 17;
            submitFieldSelection.Text = "Submit";
            submitFieldSelection.UseVisualStyleBackColor = true;
            submitFieldSelection.Visible = false;
            submitFieldSelection.Click += SubmitFieldSelection_Click;
            // 
            // submitConditionSelection
            // 
            submitConditionSelection.Location = new Point(341, 106);
            submitConditionSelection.Name = "submitConditionSelection";
            submitConditionSelection.Size = new Size(75, 23);
            submitConditionSelection.TabIndex = 18;
            submitConditionSelection.Text = "Submit";
            submitConditionSelection.UseVisualStyleBackColor = true;
            submitConditionSelection.Visible = false;
            submitConditionSelection.Click += SubmitConditionSelection_Click;
            // 
            // LeftConditionDropdown
            // 
            LeftConditionDropdown.FormattingEnabled = true;
            LeftConditionDropdown.Location = new Point(9, 106);
            LeftConditionDropdown.Name = "LeftConditionDropdown";
            LeftConditionDropdown.Size = new Size(121, 23);
            LeftConditionDropdown.TabIndex = 19;
            LeftConditionDropdown.Visible = false;
            // 
            // MiddleConditionDropdown
            // 
            MiddleConditionDropdown.FormattingEnabled = true;
            MiddleConditionDropdown.Location = new Point(139, 106);
            MiddleConditionDropdown.Name = "MiddleConditionDropdown";
            MiddleConditionDropdown.Size = new Size(69, 23);
            MiddleConditionDropdown.TabIndex = 20;
            MiddleConditionDropdown.Visible = false;
            // 
            // RightConditionDropdown
            // 
            RightConditionDropdown.FormattingEnabled = true;
            RightConditionDropdown.Location = new Point(214, 106);
            RightConditionDropdown.Name = "RightConditionDropdown";
            RightConditionDropdown.Size = new Size(121, 23);
            RightConditionDropdown.TabIndex = 21;
            RightConditionDropdown.Visible = false;
            // 
            // manualQueryButton
            // 
            manualQueryButton.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manualQueryButton.Location = new Point(160, 383);
            manualQueryButton.Margin = new Padding(0);
            manualQueryButton.Name = "manualQueryButton";
            manualQueryButton.Size = new Size(151, 29);
            manualQueryButton.TabIndex = 22;
            manualQueryButton.Text = "Manually Edit Query";
            manualQueryButton.UseVisualStyleBackColor = true;
            manualQueryButton.Visible = false;
            manualQueryButton.Click += ManualQueryButton_Click;
            // 
            // viewQueryButton
            // 
            viewQueryButton.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewQueryButton.Location = new Point(9, 383);
            viewQueryButton.Margin = new Padding(0);
            viewQueryButton.Name = "viewQueryButton";
            viewQueryButton.Size = new Size(151, 29);
            viewQueryButton.TabIndex = 16;
            viewQueryButton.Text = "View Query";
            viewQueryButton.UseVisualStyleBackColor = true;
            viewQueryButton.Visible = false;
            viewQueryButton.Click += ViewQueryButton_Click;
            // 
            // updateValueBox
            // 
            updateValueBox.Location = new Point(214, 48);
            updateValueBox.Multiline = true;
            updateValueBox.Name = "updateValueBox";
            updateValueBox.Size = new Size(121, 23);
            updateValueBox.TabIndex = 23;
            updateValueBox.Visible = false;
            updateValueBox.WordWrap = false;
            // 
            // SubmitAllButton
            // 
            SubmitAllButton.Location = new Point(329, 373);
            SubmitAllButton.Name = "SubmitAllButton";
            SubmitAllButton.Size = new Size(142, 39);
            SubmitAllButton.TabIndex = 25;
            SubmitAllButton.Text = "Finish Query Creation";
            SubmitAllButton.UseVisualStyleBackColor = true;
            SubmitAllButton.Visible = false;
            SubmitAllButton.Click += FinishQueryCreationButton_Click;
            // 
            // selectTable
            // 
            selectTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectTable.Location = new Point(548, 262);
            selectTable.Name = "selectTable";
            selectTable.RowHeadersVisible = false;
            selectTable.ShowEditingIcon = false;
            selectTable.Size = new Size(240, 150);
            selectTable.TabIndex = 26;
            selectTable.Visible = false;
            // 
            // continueButton
            // 
            continueButton.Location = new Point(364, 381);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(75, 23);
            continueButton.TabIndex = 27;
            continueButton.Text = "Continue?";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Visible = false;
            continueButton.Click += ContinueButton_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 421);
            Controls.Add(continueButton);
            Controls.Add(selectTable);
            Controls.Add(SubmitAllButton);
            Controls.Add(updateValueBox);
            Controls.Add(viewQueryButton);
            Controls.Add(manualQueryButton);
            Controls.Add(RightConditionDropdown);
            Controls.Add(MiddleConditionDropdown);
            Controls.Add(LeftConditionDropdown);
            Controls.Add(submitConditionSelection);
            Controls.Add(submitFieldSelection);
            Controls.Add(FieldDropdown);
            Controls.Add(SqlTableDropdown);
            Controls.Add(ChooseTableLabel);
            Name = "UpdateForm";
            Text = "UpdateForm";
            ((System.ComponentModel.ISupportInitialize)selectTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChooseTableLabel;
        private ComboBox SqlTableDropdown;
        private ComboBox FieldDropdown;
        private Button submitFieldSelection;
        private Button submitConditionSelection;
        private ComboBox LeftConditionDropdown;
        private ComboBox MiddleConditionDropdown;
        private ComboBox RightConditionDropdown;
        private Button manualQueryButton;
        private Button viewQueryButton;
        private TextBox updateValueBox;
        private Button SubmitAllButton;
        private DataGridView selectTable;
        private Button continueButton;
    }
}
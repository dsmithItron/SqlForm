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
            chooseTableLabel = new Label();
            sqlTableDropdown = new ComboBox();
            updateValueBox = new TextBox();
            submitAllButton = new Button();
            continueButton = new Button();
            queryBuilderPanel = new Panel();
            conditionFieldQueryBuilderPanel = new Panel();
            conditionSelectLabel = new Label();
            leftConditionDropdown = new ComboBox();
            submitConditionConjunction = new Button();
            middleConditionDropdown = new ComboBox();
            submitConditionSelection = new Button();
            conditionConjunctDropdown = new ComboBox();
            rightConditionDropdown = new ComboBox();
            selectFieldQueryBuilderPanel = new Panel();
            fieldSelectLabel = new Label();
            fieldDropdown = new ComboBox();
            submitFieldSelection = new Button();
            selectedFieldsGrid = new DataGridView();
            field = new DataGridViewTextBoxColumn();
            selectedValues = new DataGridViewTextBoxColumn();
            conditionFieldsGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            queryBox = new TextBox();
            manualQuerySubmitButton = new Button();
            queryBuilderPanel.SuspendLayout();
            conditionFieldQueryBuilderPanel.SuspendLayout();
            selectFieldQueryBuilderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectedFieldsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conditionFieldsGrid).BeginInit();
            SuspendLayout();
            // 
            // chooseTableLabel
            // 
            chooseTableLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseTableLabel.Location = new Point(12, 9);
            chooseTableLabel.Name = "chooseTableLabel";
            chooseTableLabel.Size = new Size(67, 27);
            chooseTableLabel.TabIndex = 3;
            chooseTableLabel.Text = "Table: ";
            // 
            // sqlTableDropdown
            // 
            sqlTableDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            sqlTableDropdown.FormattingEnabled = true;
            sqlTableDropdown.Location = new Point(72, 12);
            sqlTableDropdown.Name = "sqlTableDropdown";
            sqlTableDropdown.Size = new Size(200, 23);
            sqlTableDropdown.TabIndex = 4;
            sqlTableDropdown.SelectedValueChanged += SqlTableDropdown_SelectedValueChanged;
            // 
            // updateValueBox
            // 
            updateValueBox.Location = new Point(139, 32);
            updateValueBox.Multiline = true;
            updateValueBox.Name = "updateValueBox";
            updateValueBox.Size = new Size(187, 23);
            updateValueBox.TabIndex = 23;
            updateValueBox.WordWrap = false;
            // 
            // submitAllButton
            // 
            submitAllButton.Location = new Point(329, 373);
            submitAllButton.Name = "submitAllButton";
            submitAllButton.Size = new Size(142, 39);
            submitAllButton.TabIndex = 25;
            submitAllButton.Text = "Finish Query Creation";
            submitAllButton.UseVisualStyleBackColor = true;
            submitAllButton.Visible = false;
            submitAllButton.Click += FinishQueryCreationButton_Click;
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
            // queryBuilderPanel
            // 
            queryBuilderPanel.BackColor = Color.Gainsboro;
            queryBuilderPanel.Controls.Add(conditionFieldQueryBuilderPanel);
            queryBuilderPanel.Controls.Add(selectFieldQueryBuilderPanel);
            queryBuilderPanel.Location = new Point(3, 50);
            queryBuilderPanel.Name = "queryBuilderPanel";
            queryBuilderPanel.Size = new Size(410, 184);
            queryBuilderPanel.TabIndex = 28;
            queryBuilderPanel.Visible = false;
            // 
            // conditionFieldQueryBuilderPanel
            // 
            conditionFieldQueryBuilderPanel.BackColor = Color.Silver;
            conditionFieldQueryBuilderPanel.Controls.Add(conditionSelectLabel);
            conditionFieldQueryBuilderPanel.Controls.Add(leftConditionDropdown);
            conditionFieldQueryBuilderPanel.Controls.Add(submitConditionConjunction);
            conditionFieldQueryBuilderPanel.Controls.Add(middleConditionDropdown);
            conditionFieldQueryBuilderPanel.Controls.Add(submitConditionSelection);
            conditionFieldQueryBuilderPanel.Controls.Add(conditionConjunctDropdown);
            conditionFieldQueryBuilderPanel.Controls.Add(rightConditionDropdown);
            conditionFieldQueryBuilderPanel.Location = new Point(3, 68);
            conditionFieldQueryBuilderPanel.Name = "conditionFieldQueryBuilderPanel";
            conditionFieldQueryBuilderPanel.Size = new Size(404, 113);
            conditionFieldQueryBuilderPanel.TabIndex = 15;
            // 
            // conditionSelectLabel
            // 
            conditionSelectLabel.BackColor = Color.LightGray;
            conditionSelectLabel.FlatStyle = FlatStyle.Flat;
            conditionSelectLabel.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            conditionSelectLabel.ImageAlign = ContentAlignment.BottomLeft;
            conditionSelectLabel.Location = new Point(3, 3);
            conditionSelectLabel.Margin = new Padding(3, 3, 0, 0);
            conditionSelectLabel.Name = "conditionSelectLabel";
            conditionSelectLabel.Size = new Size(134, 23);
            conditionSelectLabel.TabIndex = 12;
            conditionSelectLabel.Text = "Select Conditions:";
            conditionSelectLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // leftConditionDropdown
            // 
            leftConditionDropdown.FormattingEnabled = true;
            leftConditionDropdown.Location = new Point(3, 34);
            leftConditionDropdown.Name = "leftConditionDropdown";
            leftConditionDropdown.Size = new Size(121, 23);
            leftConditionDropdown.TabIndex = 8;
            // 
            // submitConditionConjunction
            // 
            submitConditionConjunction.FlatAppearance.BorderSize = 0;
            submitConditionConjunction.Location = new Point(329, 63);
            submitConditionConjunction.Margin = new Padding(0);
            submitConditionConjunction.Name = "submitConditionConjunction";
            submitConditionConjunction.Size = new Size(75, 23);
            submitConditionConjunction.TabIndex = 13;
            submitConditionConjunction.Text = "Submit";
            submitConditionConjunction.UseVisualStyleBackColor = true;
            submitConditionConjunction.Click += SubmitConditionConjunction_Click;
            // 
            // middleConditionDropdown
            // 
            middleConditionDropdown.FormattingEnabled = true;
            middleConditionDropdown.Location = new Point(130, 34);
            middleConditionDropdown.Name = "middleConditionDropdown";
            middleConditionDropdown.Size = new Size(69, 23);
            middleConditionDropdown.TabIndex = 7;
            // 
            // submitConditionSelection
            // 
            submitConditionSelection.FlatAppearance.BorderSize = 0;
            submitConditionSelection.Location = new Point(329, 34);
            submitConditionSelection.Margin = new Padding(0);
            submitConditionSelection.Name = "submitConditionSelection";
            submitConditionSelection.Size = new Size(75, 24);
            submitConditionSelection.TabIndex = 5;
            submitConditionSelection.Text = "Submit";
            submitConditionSelection.UseVisualStyleBackColor = true;
            submitConditionSelection.Click += SubmitConditionSelection_Click;
            // 
            // conditionConjunctDropdown
            // 
            conditionConjunctDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            conditionConjunctDropdown.FormattingEnabled = true;
            conditionConjunctDropdown.Location = new Point(250, 63);
            conditionConjunctDropdown.Name = "conditionConjunctDropdown";
            conditionConjunctDropdown.Size = new Size(76, 23);
            conditionConjunctDropdown.TabIndex = 12;
            // 
            // rightConditionDropdown
            // 
            rightConditionDropdown.FormattingEnabled = true;
            rightConditionDropdown.Location = new Point(205, 34);
            rightConditionDropdown.Name = "rightConditionDropdown";
            rightConditionDropdown.Size = new Size(121, 23);
            rightConditionDropdown.TabIndex = 6;
            // 
            // selectFieldQueryBuilderPanel
            // 
            selectFieldQueryBuilderPanel.BackColor = Color.Silver;
            selectFieldQueryBuilderPanel.Controls.Add(fieldSelectLabel);
            selectFieldQueryBuilderPanel.Controls.Add(fieldDropdown);
            selectFieldQueryBuilderPanel.Controls.Add(submitFieldSelection);
            selectFieldQueryBuilderPanel.Controls.Add(updateValueBox);
            selectFieldQueryBuilderPanel.Location = new Point(3, 3);
            selectFieldQueryBuilderPanel.Name = "selectFieldQueryBuilderPanel";
            selectFieldQueryBuilderPanel.Size = new Size(404, 59);
            selectFieldQueryBuilderPanel.TabIndex = 14;
            // 
            // fieldSelectLabel
            // 
            fieldSelectLabel.BackColor = Color.LightGray;
            fieldSelectLabel.FlatStyle = FlatStyle.Flat;
            fieldSelectLabel.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldSelectLabel.ImageAlign = ContentAlignment.BottomLeft;
            fieldSelectLabel.Location = new Point(3, 3);
            fieldSelectLabel.Margin = new Padding(3, 3, 0, 0);
            fieldSelectLabel.Name = "fieldSelectLabel";
            fieldSelectLabel.Size = new Size(97, 23);
            fieldSelectLabel.TabIndex = 4;
            fieldSelectLabel.Text = "Select Field:";
            fieldSelectLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fieldDropdown
            // 
            fieldDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldDropdown.FormattingEnabled = true;
            fieldDropdown.Location = new Point(3, 33);
            fieldDropdown.Name = "fieldDropdown";
            fieldDropdown.Size = new Size(130, 23);
            fieldDropdown.TabIndex = 11;
            // 
            // submitFieldSelection
            // 
            submitFieldSelection.Location = new Point(329, 32);
            submitFieldSelection.Name = "submitFieldSelection";
            submitFieldSelection.Size = new Size(75, 24);
            submitFieldSelection.TabIndex = 4;
            submitFieldSelection.Text = "Submit";
            submitFieldSelection.UseVisualStyleBackColor = true;
            submitFieldSelection.Click += SubmitFieldSelection_Click;
            // 
            // selectedFieldsGrid
            // 
            selectedFieldsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedFieldsGrid.Columns.AddRange(new DataGridViewColumn[] { field, selectedValues });
            selectedFieldsGrid.Location = new Point(620, 12);
            selectedFieldsGrid.Name = "selectedFieldsGrid";
            selectedFieldsGrid.ReadOnly = true;
            selectedFieldsGrid.RowHeadersVisible = false;
            selectedFieldsGrid.Size = new Size(177, 362);
            selectedFieldsGrid.TabIndex = 29;
            selectedFieldsGrid.Visible = false;
            selectedFieldsGrid.CellClick += SelectedFieldsGrid_CellClick;
            // 
            // field
            // 
            field.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            field.FillWeight = 97.0051F;
            field.HeaderText = "Fields";
            field.Name = "field";
            field.ReadOnly = true;
            field.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // selectedValues
            // 
            selectedValues.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            selectedValues.FillWeight = 32.9949226F;
            selectedValues.HeaderText = "Values";
            selectedValues.MinimumWidth = 50;
            selectedValues.Name = "selectedValues";
            selectedValues.ReadOnly = true;
            // 
            // conditionFieldsGrid
            // 
            conditionFieldsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            conditionFieldsGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            conditionFieldsGrid.Location = new Point(419, 12);
            conditionFieldsGrid.Name = "conditionFieldsGrid";
            conditionFieldsGrid.ReadOnly = true;
            conditionFieldsGrid.RowHeadersVisible = false;
            conditionFieldsGrid.Size = new Size(195, 362);
            conditionFieldsGrid.TabIndex = 30;
            conditionFieldsGrid.Visible = false;
            conditionFieldsGrid.CellClick += ConditionFieldsGrid_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Condition Fields";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // queryBox
            // 
            queryBox.BackColor = SystemColors.GradientActiveCaption;
            queryBox.Location = new Point(3, 240);
            queryBox.Multiline = true;
            queryBox.Name = "queryBox";
            queryBox.Size = new Size(410, 133);
            queryBox.TabIndex = 31;
            queryBox.Visible = false;
            queryBox.WordWrap = false;
            // 
            // manualQuerySubmitButton
            // 
            manualQuerySubmitButton.FlatAppearance.BorderSize = 0;
            manualQuerySubmitButton.Location = new Point(136, 350);
            manualQuerySubmitButton.Margin = new Padding(0);
            manualQuerySubmitButton.Name = "manualQuerySubmitButton";
            manualQuerySubmitButton.Size = new Size(145, 23);
            manualQuerySubmitButton.TabIndex = 14;
            manualQuerySubmitButton.Text = "Manual Query Submit";
            manualQuerySubmitButton.UseVisualStyleBackColor = true;
            manualQuerySubmitButton.Visible = false;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 421);
            Controls.Add(manualQuerySubmitButton);
            Controls.Add(queryBox);
            Controls.Add(conditionFieldsGrid);
            Controls.Add(selectedFieldsGrid);
            Controls.Add(queryBuilderPanel);
            Controls.Add(continueButton);
            Controls.Add(submitAllButton);
            Controls.Add(sqlTableDropdown);
            Controls.Add(chooseTableLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateForm";
            Text = "UpdateForm";
            queryBuilderPanel.ResumeLayout(false);
            conditionFieldQueryBuilderPanel.ResumeLayout(false);
            selectFieldQueryBuilderPanel.ResumeLayout(false);
            selectFieldQueryBuilderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selectedFieldsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)conditionFieldsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label chooseTableLabel;
        private ComboBox sqlTableDropdown;
        private TextBox updateValueBox;
        private Button submitAllButton;
        private Button continueButton;
        private Panel queryBuilderPanel;
        private Panel conditionFieldQueryBuilderPanel;
        private Label conditionSelectLabel;
        private ComboBox leftConditionDropdown;
        private Button submitConditionConjunction;
        private ComboBox middleConditionDropdown;
        private Button submitConditionSelection;
        private ComboBox conditionConjunctDropdown;
        private ComboBox rightConditionDropdown;
        private Panel selectFieldQueryBuilderPanel;
        private Label fieldSelectLabel;
        private ComboBox fieldDropdown;
        private Button submitFieldSelection;
        private DataGridView selectedFieldsGrid;
        private DataGridView conditionFieldsGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox queryBox;
        private DataGridViewTextBoxColumn field;
        private DataGridViewTextBoxColumn selectedValues;
        private Button manualQuerySubmitButton;
    }
}
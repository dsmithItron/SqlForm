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
            tableLabel = new Label();
            SqlTableDropdown = new ComboBox();
            submitAllButton = new Button();
            queryBox = new TextBox();
            conditionFieldsGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
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
            manualSubmitQueryButton = new Button();
            ((System.ComponentModel.ISupportInitialize)conditionFieldsGrid).BeginInit();
            queryBuilderPanel.SuspendLayout();
            conditionFieldQueryBuilderPanel.SuspendLayout();
            selectFieldQueryBuilderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectedFieldsGrid).BeginInit();
            SuspendLayout();
            // 
            // tableLabel
            // 
            tableLabel.AutoSize = true;
            tableLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLabel.Location = new Point(12, 9);
            tableLabel.Name = "tableLabel";
            tableLabel.Size = new Size(61, 20);
            tableLabel.TabIndex = 26;
            tableLabel.Text = "Table:";
            // 
            // SqlTableDropdown
            // 
            SqlTableDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            SqlTableDropdown.FormattingEnabled = true;
            SqlTableDropdown.Location = new Point(72, 12);
            SqlTableDropdown.Name = "SqlTableDropdown";
            SqlTableDropdown.Size = new Size(200, 23);
            SqlTableDropdown.TabIndex = 25;
            SqlTableDropdown.SelectedValueChanged += SqlTableDropdown_SelectedValueChanged;
            // 
            // submitAllButton
            // 
            submitAllButton.BackColor = Color.Silver;
            submitAllButton.FlatStyle = FlatStyle.Flat;
            submitAllButton.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitAllButton.Location = new Point(335, 380);
            submitAllButton.Name = "submitAllButton";
            submitAllButton.Size = new Size(173, 35);
            submitAllButton.TabIndex = 24;
            submitAllButton.Text = "Finish Query Selection";
            submitAllButton.UseVisualStyleBackColor = false;
            submitAllButton.Visible = false;
            submitAllButton.Click += FinishQueryCreationButton_Click;
            // 
            // queryBox
            // 
            queryBox.BackColor = SystemColors.GradientActiveCaption;
            queryBox.Location = new Point(3, 240);
            queryBox.Multiline = true;
            queryBox.Name = "queryBox";
            queryBox.Size = new Size(410, 134);
            queryBox.TabIndex = 23;
            queryBox.Visible = false;
            queryBox.WordWrap = false;
            // 
            // conditionFieldsGrid
            // 
            conditionFieldsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            conditionFieldsGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            conditionFieldsGrid.Location = new Point(419, 12);
            conditionFieldsGrid.Name = "conditionFieldsGrid";
            conditionFieldsGrid.ReadOnly = true;
            conditionFieldsGrid.RowHeadersVisible = false;
            conditionFieldsGrid.Size = new Size(215, 362);
            conditionFieldsGrid.TabIndex = 22;
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
            // queryBuilderPanel
            // 
            queryBuilderPanel.BackColor = Color.Gainsboro;
            queryBuilderPanel.Controls.Add(conditionFieldQueryBuilderPanel);
            queryBuilderPanel.Controls.Add(selectFieldQueryBuilderPanel);
            queryBuilderPanel.Location = new Point(3, 50);
            queryBuilderPanel.Name = "queryBuilderPanel";
            queryBuilderPanel.Size = new Size(410, 184);
            queryBuilderPanel.TabIndex = 21;
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
            leftConditionDropdown.Location = new Point(3, 29);
            leftConditionDropdown.Name = "leftConditionDropdown";
            leftConditionDropdown.Size = new Size(121, 23);
            leftConditionDropdown.TabIndex = 8;
            // 
            // submitConditionConjunction
            // 
            submitConditionConjunction.FlatAppearance.BorderSize = 0;
            submitConditionConjunction.Location = new Point(329, 58);
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
            middleConditionDropdown.Location = new Point(130, 29);
            middleConditionDropdown.Name = "middleConditionDropdown";
            middleConditionDropdown.Size = new Size(69, 23);
            middleConditionDropdown.TabIndex = 7;
            // 
            // submitConditionSelection
            // 
            submitConditionSelection.FlatAppearance.BorderSize = 0;
            submitConditionSelection.Location = new Point(329, 29);
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
            conditionConjunctDropdown.Location = new Point(250, 58);
            conditionConjunctDropdown.Name = "conditionConjunctDropdown";
            conditionConjunctDropdown.Size = new Size(76, 23);
            conditionConjunctDropdown.TabIndex = 12;
            // 
            // rightConditionDropdown
            // 
            rightConditionDropdown.FormattingEnabled = true;
            rightConditionDropdown.Location = new Point(205, 29);
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
            fieldDropdown.Location = new Point(37, 32);
            fieldDropdown.Name = "fieldDropdown";
            fieldDropdown.Size = new Size(286, 23);
            fieldDropdown.TabIndex = 11;
            // 
            // submitFieldSelection
            // 
            submitFieldSelection.Location = new Point(329, 31);
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
            selectedFieldsGrid.Columns.AddRange(new DataGridViewColumn[] { field });
            selectedFieldsGrid.Location = new Point(640, 12);
            selectedFieldsGrid.Name = "selectedFieldsGrid";
            selectedFieldsGrid.ReadOnly = true;
            selectedFieldsGrid.RowHeadersVisible = false;
            selectedFieldsGrid.Size = new Size(157, 362);
            selectedFieldsGrid.TabIndex = 30;
            selectedFieldsGrid.Visible = false;
            selectedFieldsGrid.CellClick += SelectedFieldsGrid_CellClick;
            // 
            // field
            // 
            field.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            field.HeaderText = "Selected Fields";
            field.Name = "field";
            field.ReadOnly = true;
            field.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // manualSubmitQueryButton
            // 
            manualSubmitQueryButton.FlatAppearance.BorderSize = 0;
            manualSubmitQueryButton.Location = new Point(150, 347);
            manualSubmitQueryButton.Margin = new Padding(0);
            manualSubmitQueryButton.Name = "manualSubmitQueryButton";
            manualSubmitQueryButton.Size = new Size(133, 27);
            manualSubmitQueryButton.TabIndex = 14;
            manualSubmitQueryButton.Text = "Manual Query Submit";
            manualSubmitQueryButton.UseVisualStyleBackColor = true;
            manualSubmitQueryButton.Visible = false;
            manualSubmitQueryButton.Click += ManualSubmitQuery_Click;
            // 
            // SelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 421);
            Controls.Add(manualSubmitQueryButton);
            Controls.Add(selectedFieldsGrid);
            Controls.Add(SqlTableDropdown);
            Controls.Add(tableLabel);
            Controls.Add(submitAllButton);
            Controls.Add(queryBuilderPanel);
            Controls.Add(conditionFieldsGrid);
            Controls.Add(queryBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectForm";
            Text = "SelectForm";
            ((System.ComponentModel.ISupportInitialize)conditionFieldsGrid).EndInit();
            queryBuilderPanel.ResumeLayout(false);
            conditionFieldQueryBuilderPanel.ResumeLayout(false);
            selectFieldQueryBuilderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)selectedFieldsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label tableLabel;
        private ComboBox SqlTableDropdown;
        private Button submitAllButton;
        private TextBox queryBox;
        private DataGridView conditionFieldsGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
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
        private DataGridViewTextBoxColumn field;
        private Button manualSubmitQueryButton;
    }
}
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
            updateValueBox = new TextBox();
            SubmitAllButton = new Button();
            selectTable = new DataGridView();
            continueButton = new Button();
            queryBuilderPanel = new Panel();
            panel2 = new Panel();
            conditionSelectLabel = new Label();
            LeftConditionDropdown = new ComboBox();
            submitConditionConjunction = new Button();
            MiddleConditionDropdown = new ComboBox();
            submitConditionSelection = new Button();
            conditionConjunctDropdown = new ComboBox();
            RightConditionDropdown = new ComboBox();
            selectFieldQueryBuilderPanel = new Panel();
            fieldSelectLabel = new Label();
            FieldDropdown = new ComboBox();
            submitFieldSelection = new Button();
            selectedFieldsGrid = new DataGridView();
            field = new DataGridViewTextBoxColumn();
            conditionFieldsGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            queryBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)selectTable).BeginInit();
            queryBuilderPanel.SuspendLayout();
            panel2.SuspendLayout();
            selectFieldQueryBuilderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectedFieldsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conditionFieldsGrid).BeginInit();
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
            SqlTableDropdown.Location = new Point(72, 12);
            SqlTableDropdown.Name = "SqlTableDropdown";
            SqlTableDropdown.Size = new Size(200, 23);
            SqlTableDropdown.TabIndex = 4;
            SqlTableDropdown.SelectedValueChanged += SqlTableDropdown_SelectedValueChanged;
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
            selectTable.Location = new Point(759, 381);
            selectTable.Name = "selectTable";
            selectTable.RowHeadersVisible = false;
            selectTable.ShowEditingIcon = false;
            selectTable.Size = new Size(29, 31);
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
            // queryBuilderPanel
            // 
            queryBuilderPanel.BackColor = Color.Gainsboro;
            queryBuilderPanel.Controls.Add(panel2);
            queryBuilderPanel.Controls.Add(selectFieldQueryBuilderPanel);
            queryBuilderPanel.Location = new Point(3, 50);
            queryBuilderPanel.Name = "queryBuilderPanel";
            queryBuilderPanel.Size = new Size(410, 184);
            queryBuilderPanel.TabIndex = 28;
            queryBuilderPanel.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(conditionSelectLabel);
            panel2.Controls.Add(LeftConditionDropdown);
            panel2.Controls.Add(submitConditionConjunction);
            panel2.Controls.Add(MiddleConditionDropdown);
            panel2.Controls.Add(submitConditionSelection);
            panel2.Controls.Add(conditionConjunctDropdown);
            panel2.Controls.Add(RightConditionDropdown);
            panel2.Location = new Point(3, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 113);
            panel2.TabIndex = 15;
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
            // LeftConditionDropdown
            // 
            LeftConditionDropdown.FormattingEnabled = true;
            LeftConditionDropdown.Location = new Point(3, 34);
            LeftConditionDropdown.Name = "LeftConditionDropdown";
            LeftConditionDropdown.Size = new Size(121, 23);
            LeftConditionDropdown.TabIndex = 8;
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
            // 
            // MiddleConditionDropdown
            // 
            MiddleConditionDropdown.FormattingEnabled = true;
            MiddleConditionDropdown.Location = new Point(130, 34);
            MiddleConditionDropdown.Name = "MiddleConditionDropdown";
            MiddleConditionDropdown.Size = new Size(69, 23);
            MiddleConditionDropdown.TabIndex = 7;
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
            // RightConditionDropdown
            // 
            RightConditionDropdown.FormattingEnabled = true;
            RightConditionDropdown.Location = new Point(205, 34);
            RightConditionDropdown.Name = "RightConditionDropdown";
            RightConditionDropdown.Size = new Size(121, 23);
            RightConditionDropdown.TabIndex = 6;
            // 
            // selectFieldQueryBuilderPanel
            // 
            selectFieldQueryBuilderPanel.BackColor = Color.Silver;
            selectFieldQueryBuilderPanel.Controls.Add(fieldSelectLabel);
            selectFieldQueryBuilderPanel.Controls.Add(FieldDropdown);
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
            // FieldDropdown
            // 
            FieldDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            FieldDropdown.FormattingEnabled = true;
            FieldDropdown.Location = new Point(3, 33);
            FieldDropdown.Name = "FieldDropdown";
            FieldDropdown.Size = new Size(130, 23);
            FieldDropdown.TabIndex = 11;
            // 
            // submitFieldSelection
            // 
            submitFieldSelection.Location = new Point(329, 32);
            submitFieldSelection.Name = "submitFieldSelection";
            submitFieldSelection.Size = new Size(75, 24);
            submitFieldSelection.TabIndex = 4;
            submitFieldSelection.Text = "Submit";
            submitFieldSelection.UseVisualStyleBackColor = true;
            submitFieldSelection.UseWaitCursor = true;
            // 
            // selectedFieldsGrid
            // 
            selectedFieldsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedFieldsGrid.Columns.AddRange(new DataGridViewColumn[] { field });
            selectedFieldsGrid.Location = new Point(640, 12);
            selectedFieldsGrid.Name = "selectedFieldsGrid";
            selectedFieldsGrid.RowHeadersVisible = false;
            selectedFieldsGrid.Size = new Size(157, 362);
            selectedFieldsGrid.TabIndex = 29;
            selectedFieldsGrid.Visible = false;
            // 
            // field
            // 
            field.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            field.HeaderText = "Selected Fields";
            field.Name = "field";
            field.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // conditionFieldsGrid
            // 
            conditionFieldsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            conditionFieldsGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            conditionFieldsGrid.Location = new Point(419, 12);
            conditionFieldsGrid.Name = "conditionFieldsGrid";
            conditionFieldsGrid.RowHeadersVisible = false;
            conditionFieldsGrid.Size = new Size(215, 362);
            conditionFieldsGrid.TabIndex = 30;
            conditionFieldsGrid.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Condition Fields";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 421);
            Controls.Add(queryBox);
            Controls.Add(conditionFieldsGrid);
            Controls.Add(selectedFieldsGrid);
            Controls.Add(queryBuilderPanel);
            Controls.Add(continueButton);
            Controls.Add(selectTable);
            Controls.Add(SubmitAllButton);
            Controls.Add(SqlTableDropdown);
            Controls.Add(ChooseTableLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateForm";
            Text = "UpdateForm";
            ((System.ComponentModel.ISupportInitialize)selectTable).EndInit();
            queryBuilderPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            selectFieldQueryBuilderPanel.ResumeLayout(false);
            selectFieldQueryBuilderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selectedFieldsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)conditionFieldsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChooseTableLabel;
        private ComboBox SqlTableDropdown;
        private TextBox updateValueBox;
        private Button SubmitAllButton;
        private DataGridView selectTable;
        private Button continueButton;
        private Panel queryBuilderPanel;
        private Panel panel2;
        private Label conditionSelectLabel;
        private ComboBox LeftConditionDropdown;
        private Button submitConditionConjunction;
        private ComboBox MiddleConditionDropdown;
        private Button submitConditionSelection;
        private ComboBox conditionConjunctDropdown;
        private ComboBox RightConditionDropdown;
        private Panel selectFieldQueryBuilderPanel;
        private Label fieldSelectLabel;
        private ComboBox FieldDropdown;
        private Button submitFieldSelection;
        private DataGridView selectedFieldsGrid;
        private DataGridViewTextBoxColumn field;
        private DataGridView conditionFieldsGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox queryBox;
    }
}
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
            selectTable = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            SqlTableDropdown = new ComboBox();
            SubmitAllButton = new Button();
            queryBox = new TextBox();
            conditionFieldsGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            queryBuilderPanel = new Panel();
            submitConditionConjunction = new Button();
            conditionConjunctDropdown = new ComboBox();
            FieldDropdown = new ComboBox();
            SubmitFieldSelection = new Button();
            SubmitConditionSelection = new Button();
            RightConditionDropdown = new ComboBox();
            MiddleConditionDropdown = new ComboBox();
            LeftConditionDropdown = new ComboBox();
            selectedFieldsGrid = new DataGridView();
            field = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)selectTable).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)conditionFieldsGrid).BeginInit();
            queryBuilderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectedFieldsGrid).BeginInit();
            SuspendLayout();
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SqlTableDropdown);
            panel1.Controls.Add(SubmitAllButton);
            panel1.Controls.Add(queryBox);
            panel1.Controls.Add(conditionFieldsGrid);
            panel1.Controls.Add(queryBuilderPanel);
            panel1.Controls.Add(selectedFieldsGrid);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 421);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 26;
            label1.Text = "Table:";
            // 
            // SqlTableDropdown
            // 
            SqlTableDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            SqlTableDropdown.FormattingEnabled = true;
            SqlTableDropdown.Location = new Point(79, 12);
            SqlTableDropdown.Name = "SqlTableDropdown";
            SqlTableDropdown.Size = new Size(121, 23);
            SqlTableDropdown.TabIndex = 25;
            SqlTableDropdown.SelectedValueChanged += SqlTableDropdown_SelectedValueChanged;
            // 
            // SubmitAllButton
            // 
            SubmitAllButton.BackColor = Color.Silver;
            SubmitAllButton.FlatStyle = FlatStyle.Flat;
            SubmitAllButton.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubmitAllButton.Location = new Point(338, 380);
            SubmitAllButton.Name = "SubmitAllButton";
            SubmitAllButton.Size = new Size(173, 35);
            SubmitAllButton.TabIndex = 24;
            SubmitAllButton.Text = "Finish Query Selection";
            SubmitAllButton.UseVisualStyleBackColor = false;
            SubmitAllButton.Visible = false;
            SubmitAllButton.Click += FinishQueryCreationButton_Click;
            // 
            // queryBox
            // 
            queryBox.BackColor = SystemColors.GradientActiveCaption;
            queryBox.Location = new Point(3, 241);
            queryBox.Multiline = true;
            queryBox.Name = "queryBox";
            queryBox.Size = new Size(410, 133);
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
            conditionFieldsGrid.RowHeadersVisible = false;
            conditionFieldsGrid.Size = new Size(215, 362);
            conditionFieldsGrid.TabIndex = 22;
            conditionFieldsGrid.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Condition Fields";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // queryBuilderPanel
            // 
            queryBuilderPanel.BackColor = Color.Gainsboro;
            queryBuilderPanel.Controls.Add(submitConditionConjunction);
            queryBuilderPanel.Controls.Add(conditionConjunctDropdown);
            queryBuilderPanel.Controls.Add(FieldDropdown);
            queryBuilderPanel.Controls.Add(SubmitFieldSelection);
            queryBuilderPanel.Controls.Add(SubmitConditionSelection);
            queryBuilderPanel.Controls.Add(RightConditionDropdown);
            queryBuilderPanel.Controls.Add(MiddleConditionDropdown);
            queryBuilderPanel.Controls.Add(LeftConditionDropdown);
            queryBuilderPanel.Location = new Point(3, 51);
            queryBuilderPanel.Name = "queryBuilderPanel";
            queryBuilderPanel.Size = new Size(410, 184);
            queryBuilderPanel.TabIndex = 21;
            queryBuilderPanel.Visible = false;
            // 
            // submitConditionConjunction
            // 
            submitConditionConjunction.Location = new Point(335, 132);
            submitConditionConjunction.Name = "submitConditionConjunction";
            submitConditionConjunction.Size = new Size(75, 23);
            submitConditionConjunction.TabIndex = 13;
            submitConditionConjunction.Text = "Submit";
            submitConditionConjunction.UseVisualStyleBackColor = true;
            submitConditionConjunction.Click += submitConditionConjunction_Click;
            // 
            // conditionConjunctDropdown
            // 
            conditionConjunctDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            conditionConjunctDropdown.FormattingEnabled = true;
            conditionConjunctDropdown.Location = new Point(253, 132);
            conditionConjunctDropdown.Name = "conditionConjunctDropdown";
            conditionConjunctDropdown.Size = new Size(76, 23);
            conditionConjunctDropdown.TabIndex = 12;
            // 
            // FieldDropdown
            // 
            FieldDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            FieldDropdown.FormattingEnabled = true;
            FieldDropdown.Location = new Point(208, 41);
            FieldDropdown.Name = "FieldDropdown";
            FieldDropdown.Size = new Size(121, 23);
            FieldDropdown.TabIndex = 11;
            // 
            // SubmitFieldSelection
            // 
            SubmitFieldSelection.Location = new Point(335, 40);
            SubmitFieldSelection.Name = "SubmitFieldSelection";
            SubmitFieldSelection.Size = new Size(75, 23);
            SubmitFieldSelection.TabIndex = 4;
            SubmitFieldSelection.Text = "Submit";
            SubmitFieldSelection.UseVisualStyleBackColor = true;
            SubmitFieldSelection.UseWaitCursor = true;
            SubmitFieldSelection.Click += SubmitFieldSelection_Click;
            // 
            // SubmitConditionSelection
            // 
            SubmitConditionSelection.Location = new Point(335, 103);
            SubmitConditionSelection.Name = "SubmitConditionSelection";
            SubmitConditionSelection.Size = new Size(75, 23);
            SubmitConditionSelection.TabIndex = 5;
            SubmitConditionSelection.Text = "Submit";
            SubmitConditionSelection.UseVisualStyleBackColor = true;
            SubmitConditionSelection.Click += SubmitConditionSelection_Click;
            // 
            // RightConditionDropdown
            // 
            RightConditionDropdown.FormattingEnabled = true;
            RightConditionDropdown.Location = new Point(208, 103);
            RightConditionDropdown.Name = "RightConditionDropdown";
            RightConditionDropdown.Size = new Size(121, 23);
            RightConditionDropdown.TabIndex = 6;
            // 
            // MiddleConditionDropdown
            // 
            MiddleConditionDropdown.FormattingEnabled = true;
            MiddleConditionDropdown.Location = new Point(133, 103);
            MiddleConditionDropdown.Name = "MiddleConditionDropdown";
            MiddleConditionDropdown.Size = new Size(69, 23);
            MiddleConditionDropdown.TabIndex = 7;
            // 
            // LeftConditionDropdown
            // 
            LeftConditionDropdown.FormattingEnabled = true;
            LeftConditionDropdown.Location = new Point(6, 103);
            LeftConditionDropdown.Name = "LeftConditionDropdown";
            LeftConditionDropdown.Size = new Size(121, 23);
            LeftConditionDropdown.TabIndex = 8;
            // 
            // selectedFieldsGrid
            // 
            selectedFieldsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedFieldsGrid.Columns.AddRange(new DataGridViewColumn[] { field });
            selectedFieldsGrid.Location = new Point(640, 12);
            selectedFieldsGrid.Name = "selectedFieldsGrid";
            selectedFieldsGrid.RowHeadersVisible = false;
            selectedFieldsGrid.Size = new Size(157, 362);
            selectedFieldsGrid.TabIndex = 13;
            selectedFieldsGrid.Visible = false;
            // 
            // field
            // 
            field.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            field.HeaderText = "Selected Fields";
            field.Name = "field";
            field.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // SelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 421);
            Controls.Add(panel1);
            Controls.Add(selectTable);
            Name = "SelectForm";
            Text = "SelectForm";
            ((System.ComponentModel.ISupportInitialize)selectTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)conditionFieldsGrid).EndInit();
            queryBuilderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)selectedFieldsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView selectTable;
        private Panel panel1;
        private Label ChooseTableLabel;
        private Button SubmitConditionSelection;
        private Button SubmitFieldSelection;
        private ComboBox RightConditionDropdown;
        private ComboBox LeftConditionDropdown;
        private ComboBox MiddleConditionDropdown;
        private ComboBox FieldDropdown;
        private DataGridView selectedFieldsGrid;
        private DataGridViewTextBoxColumn field;
        private Panel queryBuilderPanel;
        private DataGridView conditionFieldsGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox queryBox;
        private ComboBox conditionConjunctDropdown;
        private Button submitConditionConjunction;
        private Button finishQueryCreationButton;
        private Label label1;
        private ComboBox SqlTableDropdown;
        private Button SubmitAllButton;
    }
}
using SqlForm.Classes;
using SqlForm.Forms;

namespace SqlForm
{
    public partial class UpdateForm : ChildSqlForm
    {
        List<String> updateValueFields = new();
        

        // references to be used for object creation
        DataGridView selectTable; // used in FillSelectTable and FinishQueryCreationButton_Click
        Label selectedTableLabel; // used in FinishQueryCreationButton_Click

        public UpdateForm()
        {
            InitializeComponent();
            FillTableDropdown();
        }

        private void ClearFields()
        {
            fields.Clear();
            updateValueFields.Clear();
            conditions.Clear();
            tableColumns.Clear();

            query = "";
        }

        private void FillSelectTable()
        {
            selectTable.DataSource = tableColumns;
            string selectQuery = TestSql.BuildSelectQuery(sqlTableDropdown.SelectedItem.ToString(), conditions);
            selectTable.DataSource = TestSql.ReaderQuery(selectQuery);
            FormatSelectTable();
        }

        private void FormatSelectTable()
        {
            this.Controls.Add(selectTable);
            selectTable.RowHeadersVisible = false;
            selectTable.AutoResizeColumns();
            selectTable.ReadOnly = true;
            selectTable.AllowUserToResizeColumns = false;
            selectTable.AllowUserToResizeRows = false;
            selectTable.Dock = DockStyle.Fill;
            selectTable.ClearSelection();
            selectTable.BringToFront();

            foreach (DataGridViewColumn column in selectTable.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (string columnName in fields)
            {
                if (selectTable.Columns.Contains(columnName))
                {
                    for (int i = 0; i < selectTable.RowCount - 1; i++)
                    {
                        int columnIndex = selectTable.Columns[columnName].Index;
                        selectTable.Rows[i].Cells[columnIndex].Style.BackColor = Color.FromArgb(255, 87, 34);
                    }
                }
            }
        }

        private void FillTableDropdown()
        {
            sqlTableDropdown.Items.Clear();
            foreach (string tableName in TestSql.tableNames)
            {
                sqlTableDropdown.Items.Add(tableName);
            }
        }

        private void FillFieldDropDown()
        {
            fieldDropdown.Items.Clear();
            foreach (string field in tableColumns)
            {
                fieldDropdown.Items.Add(field);
            }
        }

        private void FillConditionalDropdown()
        {
            leftConditionDropdown.Items.Clear();
            middleConditionDropdown.Items.Clear();
            rightConditionDropdown.Items.Clear();

            foreach (string field in tableColumns)
            {
                leftConditionDropdown.Items.Add(field);
                rightConditionDropdown.Items.Add(field);
            }

            middleConditionDropdown.Items.Add("=");
            middleConditionDropdown.Items.Add(">");
            middleConditionDropdown.Items.Add("<");
            middleConditionDropdown.Items.Add(">=");
            middleConditionDropdown.Items.Add("<=");
            middleConditionDropdown.Items.Add("<>");
            middleConditionDropdown.Items.Add("like");
            middleConditionDropdown.Items.Add("between");
            middleConditionDropdown.Items.Add("in");

            foreach (string condition in ApplicationHistory.tableConditions[sqlTableDropdown.Text]["SelectLeft"])
            {
                leftConditionDropdown.Items.Add(condition);
            }
            foreach (string condition in ApplicationHistory.tableConditions[sqlTableDropdown.Text]["SelectMiddle"])
            {
                middleConditionDropdown.Items.Add(condition);
            }
            foreach (string condition in ApplicationHistory.tableConditions[sqlTableDropdown.Text]["SelectRight"])
            {
                rightConditionDropdown.Items.Add(condition);
            }

            conditionConjunctDropdown.Items.Add("AND");
            conditionConjunctDropdown.Items.Add("OR");
        }

        private void SqlTableDropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearFields();
            tableColumns = TestSql.GetColumns(sqlTableDropdown.Text);
            FillFieldDropDown();
            FillConditionalDropdown();

            queryBuilderPanel.Visible = true;

            queryBox.Visible = true;
        }

        private void SubmitFieldSelection_Click(object sender, EventArgs e)
        {
            // If an item was selected from dropdown
            // Prevents pressing button 
            if (fieldDropdown.SelectedIndex >= 0 && !fields.Contains(fieldDropdown.SelectedItem.ToString()))
            {
                selectedFieldsGrid.Rows.Add(fieldDropdown.SelectedItem.ToString(), updateValueBox.Text);
                selectedFieldsGrid.Visible = true;

                fields.Add(fieldDropdown.SelectedItem.ToString());
                fieldDropdown.SelectedIndex = -1;

                updateValueFields.Add(updateValueBox.Text);
                updateValueBox.Text = "";

                query = TestSql.BuildUpdateQuery(sqlTableDropdown.SelectedItem.ToString(), fields, updateValueFields, conditions);
                queryBox.Text = query;
                submitAllButton.Visible = true;
            }
        }

        private void SubmitConditionSelection_Click(object sender, EventArgs e)
        {
            int conditionNum = conditionFieldsGrid.Rows.Count - 1;
            if (conditionNum == 0 || conditionNum % 2 == 0)
            {
                string val1 = leftConditionDropdown.Text, val2 = middleConditionDropdown.Text, val3 = rightConditionDropdown.Text;
                if (val1 != "" && val2 != "" && val3 != "")
                {
                    if (!leftConditionDropdown.Items.Contains(val1))
                    {
                        leftConditionDropdown.Items.Add(val1);
                    }
                    if (!middleConditionDropdown.Items.Contains(val2))
                    {
                        middleConditionDropdown.Items.Add(val2);
                    }
                    if (!rightConditionDropdown.Items.Contains(val3))
                    {
                        rightConditionDropdown.Items.Add(val3);
                    }
                    conditions.Add($"{val1} {val2} {val3} ");

                    leftConditionDropdown.SelectedIndex = -1;
                    leftConditionDropdown.Text = "";

                    middleConditionDropdown.SelectedIndex = -1;
                    middleConditionDropdown.Text = "";

                    rightConditionDropdown.SelectedIndex = -1;
                    rightConditionDropdown.Text = "";

                    conditionFieldsGrid.Rows.Add($"{val1} {val2} {val3} ");
                    conditionFieldsGrid.Visible = true;

                    query = TestSql.BuildUpdateQuery(sqlTableDropdown.SelectedItem.ToString(), fields, updateValueFields, conditions);
                    queryBox.Text = query;
                }
            }
        }

        private void SubmitConditionConjunction_Click(object sender, EventArgs e)
        {
            int conditionNum = conditionFieldsGrid.Rows.Count - 1;
            if (conditionNum % 2 != 0 && conditionConjunctDropdown.SelectedIndex >= 0)
            {
                conditions.Add(conditionConjunctDropdown.Text);
                conditionFieldsGrid.Rows.Add(conditionConjunctDropdown.Text);
                query = TestSql.BuildUpdateQuery(sqlTableDropdown.SelectedItem.ToString(), fields, updateValueFields, conditions);
                queryBox.Text = query;
            }
        }

        private void FinishQueryCreationButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(200);
            this.Cursor = Cursors.Default;
            DialogResult msgBoxResult = DialogResult.Yes;
            if (fields.Count > 0 && fields.Count == updateValueFields.Count)
            {
                if (TestSql.ReaderQuery(TestSql.BuildSelectQuery(sqlTableDropdown.SelectedItem.ToString(), conditions)).Rows.Count >= 1){
                    if (conditions.Count == 0)
                    {
                        msgBoxResult = MessageBox.Show
                        (
                            $"Are you sure you would like to execute the update without any conditions?" +
                            $"\nYou will receive another chance to confirm before execution.",
                            $"Confirm Condition Selection",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                        );
                    }

                    if (msgBoxResult == DialogResult.Yes)
                    {
                        ResultForm resultForm = new(sqlTableDropdown.SelectedItem.ToString(), "Update", this);
                        parentSqlForm.OpenChildForm(resultForm);
                    }
                }
                else
                {
                    MessageBox.Show
                            (
                                $"This is nothing that fits the update conditions",
                                $"Cannot Find",
                                MessageBoxButtons.OK, MessageBoxIcon.Error
                            );
                }
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            TestSql.NonReaderQuery(query);
            Thread.Sleep(200);
            FillSelectTable();
            selectedTableLabel.Text = "Table Selected: " + sqlTableDropdown.Text + "\n\nAfter Update";
            this.Cursor = Cursors.Default;
        }

        private void SelectedFieldsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fieldName = selectedFieldsGrid.Rows[e.RowIndex].Cells[0].Value;
            var fieldValue = selectedFieldsGrid.Rows[e.RowIndex].Cells[1].Value;
            var msgBoxResult = MessageBox.Show
                               (
                                $"Do you want to remove the field \"{fieldName} and its value {fieldValue}\"?",
                                $"Remove Selected Field",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information
                               );

            if (msgBoxResult == DialogResult.Yes)
            {
                fields.RemoveAt(fields.IndexOf(fieldName.ToString()));
                updateValueFields.RemoveAt(updateValueFields.IndexOf(fieldValue.ToString()));
                selectedFieldsGrid.Rows.RemoveAt(e.RowIndex);
                query = TestSql.BuildUpdateQuery(sqlTableDropdown.SelectedItem.ToString(), fields, updateValueFields, conditions);
                queryBox.Text = query;
            }
            if (selectedFieldsGrid.Rows.Count <= 1)
            {
                submitAllButton.Visible = false;
                selectedFieldsGrid.Rows.Clear();
                selectedFieldsGrid.Visible = false;
            }
        }
        private void ConditionFieldsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int conditionNum = conditionFieldsGrid.Rows.Count - 1;
            var test = e.ToString();
            var testCell = conditionFieldsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var msgBoxResult = MessageBox.Show
                               (
                                $"Do you want to remove the condition field \"{testCell.Value}\"",
                                $"Remove Condition",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information
                               );
            if (conditionNum > 1)
            {
                MessageBox.Show
                    (
                    $"Ensure that query string is still valid after removals",
                    $"Remove Condition Advice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            }
            if (msgBoxResult == DialogResult.Yes)
            {
                conditions.RemoveAt(conditions.IndexOf(testCell.Value.ToString()));
                conditionFieldsGrid.Rows.RemoveAt(e.RowIndex);
                query = TestSql.BuildUpdateQuery(sqlTableDropdown.SelectedItem.ToString(), fields, updateValueFields, conditions);
                queryBox.Text = query;
            }
            if (conditionFieldsGrid.Rows.Count <= 1)
            {
                conditionFieldsGrid.Rows.Clear();
                conditionFieldsGrid.Visible = false;
                query = TestSql.BuildUpdateQuery(sqlTableDropdown.SelectedItem.ToString(), fields, updateValueFields, conditions);
                queryBox.Text = query;
            }
        }
    }
}

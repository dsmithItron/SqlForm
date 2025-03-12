
using Microsoft.VisualBasic;
using SqlForm.Classes;
using SqlForm.Forms;

namespace SqlForm
{
    public partial class UpdateForm : ChildSqlForm
    {
        List<String> updateFields = new();
        List<String> updateValueFields = new();
        List<String> updateConditions = new();
        List<string> tableColumns = new();
        public UpdateForm()
        {
            InitializeComponent();
            FillTableDropdown();
        }

        private void ClearFields()
        {
            updateFields.Clear();
            updateValueFields.Clear();
            updateConditions.Clear();
            tableColumns.Clear();

            query = "";
        }

        private void FillSelectTable()
        {
            selectTable.DataSource = tableColumns;
            string selectQuery = TestSql.BuildSelectQuery(SqlTableDropdown.SelectedItem.ToString(), updateConditions);
            selectTable.DataSource = TestSql.ReaderQuery(selectQuery);
        }

        private void FillTableDropdown()
        {
            SqlTableDropdown.Items.Clear();
            foreach (string tableName in TestSql.tableNames)
            {
                SqlTableDropdown.Items.Add(tableName);
            }
        }

        private void FillFieldDropDown()
        {
            FieldDropdown.Items.Clear();
            foreach (string field in tableColumns)
            {
                FieldDropdown.Items.Add(field);
            }
        }

        private void FillConditionalDropdown()
        {
            LeftConditionDropdown.Items.Clear();
            MiddleConditionDropdown.Items.Clear();
            RightConditionDropdown.Items.Clear();

            foreach (string field in tableColumns)
            {
                LeftConditionDropdown.Items.Add(field);
                RightConditionDropdown.Items.Add(field);
            }
            MiddleConditionDropdown.Items.Add("=");
            MiddleConditionDropdown.Items.Add(">");
            MiddleConditionDropdown.Items.Add("<");
            MiddleConditionDropdown.Items.Add(">=");
            MiddleConditionDropdown.Items.Add("<=");
            MiddleConditionDropdown.Items.Add("<>");
            MiddleConditionDropdown.Items.Add("like");
            MiddleConditionDropdown.Items.Add("between");
            MiddleConditionDropdown.Items.Add("in");


            foreach (string condition in ApplicationHistory.tableConditions[SqlTableDropdown.Text]["SelectLeft"])
            {
                LeftConditionDropdown.Items.Add(condition);
            }
            foreach (string condition in ApplicationHistory.tableConditions[SqlTableDropdown.Text]["SelectMiddle"])
            {
                MiddleConditionDropdown.Items.Add(condition);
            }
            foreach (string condition in ApplicationHistory.tableConditions[SqlTableDropdown.Text]["SelectRight"])
            {
                RightConditionDropdown.Items.Add(condition);
            }

            conditionConjunctDropdown.Items.Add("AND");
            conditionConjunctDropdown.Items.Add("OR");
        }

        private void SqlTableDropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearFields();
            tableColumns = TestSql.GetColumns(SqlTableDropdown.Text);
            FillFieldDropDown();
            FillConditionalDropdown();

            queryBuilderPanel.Visible = true;

            queryBox.Visible = true;

            SubmitAllButton.Visible = true;
        }

        private void SubmitFieldSelection_Click(object sender, EventArgs e)
        {
            // If an item was selected from dropdown
            // Prevents pressing button 
            if (FieldDropdown.SelectedIndex >= 0 && !updateFields.Contains(FieldDropdown.SelectedItem.ToString()))
            {
                selectedFieldsGrid.Rows.Add(FieldDropdown.SelectedItem.ToString(), updateValueBox.Text);
                selectedFieldsGrid.Visible = true;

                updateFields.Add(FieldDropdown.SelectedItem.ToString());
                FieldDropdown.SelectedIndex = -1;

                updateValueFields.Add(updateValueBox.Text);
                updateValueBox.Text = "";

                query = TestSql.BuildUpdateQuery(SqlTableDropdown.SelectedItem.ToString(), updateFields, updateValueFields, updateConditions);
                queryBox.Text = query;
            }

        }

        private void SubmitConditionSelection_Click(object sender, EventArgs e)
        {
            int conditionNum = conditionFieldsGrid.Rows.Count - 1;
            if (conditionNum == 0 || conditionNum % 2 == 0)
            {
                string val1 = LeftConditionDropdown.Text, val2 = MiddleConditionDropdown.Text, val3 = RightConditionDropdown.Text;
                if (val1 != "" && val2 != "" && val3 != "")
                {
                    if (!LeftConditionDropdown.Items.Contains(val1))
                    {
                        LeftConditionDropdown.Items.Add(val1);
                    }
                    if (!MiddleConditionDropdown.Items.Contains(val2))
                    {
                        MiddleConditionDropdown.Items.Add(val2);
                    }
                    if (!RightConditionDropdown.Items.Contains(val3))
                    {
                        RightConditionDropdown.Items.Add(val3);
                    }
                    updateConditions.Add($"{val1} {val2} {val3} ");

                    LeftConditionDropdown.SelectedIndex = -1;
                    LeftConditionDropdown.Text = "";

                    MiddleConditionDropdown.SelectedIndex = -1;
                    MiddleConditionDropdown.Text = "";

                    RightConditionDropdown.SelectedIndex = -1;
                    RightConditionDropdown.Text = "";

                    conditionFieldsGrid.Rows.Add($"{val1} {val2} {val3} ");
                    conditionFieldsGrid.Visible = true;

                    query = TestSql.BuildUpdateQuery(SqlTableDropdown.SelectedItem.ToString(), updateFields, updateValueFields, updateConditions);
                    queryBox.Text = query;
                }
            }
        }

        private void SubmitConditionConjunction_Click(object sender, EventArgs e)
        {
            int conditionNum = conditionFieldsGrid.Rows.Count - 1;
            if (conditionNum % 2 != 0 && conditionConjunctDropdown.SelectedIndex >= 0)
            {
                updateConditions.Add(conditionConjunctDropdown.Text);
                conditionFieldsGrid.Rows.Add(conditionConjunctDropdown.Text);
                query = TestSql.BuildUpdateQuery(SqlTableDropdown.SelectedItem.ToString(), updateFields, updateValueFields, updateConditions);
                queryBox.Text = query;
            }
        }

        private void FinishQueryCreationButton_Click(object sender, EventArgs e)
        {
            DialogResult msgBoxResult = DialogResult.Yes;
            if (updateFields.Count > 0 && updateFields.Count == updateValueFields.Count)
            {
                if (updateConditions.Count == 0)
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
                    FillSelectTable();
                    selectTable.Visible = true;
                    selectTable.BringToFront();
                    selectTable.Dock = DockStyle.Fill;
                    continueButton.Visible = true;
                    continueButton.BringToFront();
                }
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            TestSql.NonReaderQuery(query);
            Thread.Sleep(500);
            FillSelectTable();
            this.Cursor = Cursors.Default;

        }

        private void SelectedFieldsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fieldName = selectedFieldsGrid.Rows[e.RowIndex].Cells[0];
            var fieldValue = selectedFieldsGrid.Rows[e.RowIndex].Cells[1];
            var msgBoxResult = MessageBox.Show
                               (
                                $"Do you want to remove the select field \"{fieldName} : {fieldValue}\"",
                                $"Remove Selected Field",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information
                               );

            if (msgBoxResult == DialogResult.Yes)
            {
                updateFields.RemoveAt(updateFields.IndexOf(fieldName.Value.ToString()));
                updateValueFields.RemoveAt(updateValueFields.IndexOf(fieldValue.Value.ToString()));
                selectedFieldsGrid.Rows.RemoveAt(e.RowIndex);
                query = TestSql.BuildUpdateQuery(SqlTableDropdown.SelectedItem.ToString(), updateFields, updateValueFields, updateConditions);
                queryBox.Text = query;
            }
            if (selectedFieldsGrid.Rows.Count <= 1)
            {
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
                updateConditions.RemoveAt(updateConditions.IndexOf(testCell.Value.ToString()));
                conditionFieldsGrid.Rows.RemoveAt(e.RowIndex);
                query = TestSql.BuildUpdateQuery(SqlTableDropdown.SelectedItem.ToString(), updateFields, updateValueFields, updateConditions);
                queryBox.Text = query;
            }
            if (conditionFieldsGrid.Rows.Count <= 1)
            {
                conditionFieldsGrid.Rows.Clear();
                conditionFieldsGrid.Visible = false;
                query = TestSql.BuildUpdateQuery(SqlTableDropdown.SelectedItem.ToString(), updateFields, updateValueFields, updateConditions);
                queryBox.Text = query;
            }
        }
    }
}

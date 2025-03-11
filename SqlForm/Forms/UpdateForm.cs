
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
                updateFields.Add(FieldDropdown.SelectedItem.ToString());
                FieldDropdown.SelectedIndex = -1;
                updateValueFields.Add(updateValueBox.Text);
                updateValueBox.Text = "";
                query = TestSql.BuildUpdateQuery(SqlTableDropdown.SelectedItem.ToString(), updateFields, updateValueFields, updateConditions);
            }

        }

        private void SubmitConditionSelection_Click(object sender, EventArgs e)
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

                query = TestSql.BuildUpdateQuery(SqlTableDropdown.SelectedItem.ToString(), updateFields, updateValueFields, updateConditions);
            }
        }

        private void FinishQueryCreationButton_Click(object sender, EventArgs e)
        {
            FillSelectTable();
            selectTable.Visible = true;
            selectTable.BringToFront();
            selectTable.Dock = DockStyle.Fill;
            continueButton.Visible = true;
            continueButton.BringToFront();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            TestSql.NonReaderQuery(query);
            Thread.Sleep(500);
            FillSelectTable();
            this.Cursor = Cursors.Default;

        }
    }
}

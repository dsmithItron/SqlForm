using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SqlForm.Classes;

namespace SqlForm.Forms
{
    public partial class SelectForm : ChildSqlForm
    {
        List<String> selectFields = new();
        List<String> selectConditions = new();
        List<string> tableColumns = new();
        // references to be used for object creation
        DataGridView selectedTable; // used in FillSelectTable and FinishQueryCreationButton_Click
        Label selectedTableLabel; // used in FinishQueryCreationButton_Click
        public SelectForm()
        {
            InitializeComponent();
            FillTableDropdown();
        }

        public void ClearFields()
        {
            selectedFieldsGrid.Visible = false;
            selectFields = new();
            selectConditions = new();
            tableColumns = new();
            selectedFieldsGrid.Rows.Clear();
            query = "";
        }

        private void FillSelectTable()
        {
            selectedTable.DataSource = TestSql.ReaderQuery(query);
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


            foreach (string condition in ApplicationHistory.tableConditions[SqlTableDropdown.Text]["SelectLeft"])
            {
                leftConditionDropdown.Items.Add(condition);
            }
            foreach (string condition in ApplicationHistory.tableConditions[SqlTableDropdown.Text]["SelectMiddle"])
            {
                middleConditionDropdown.Items.Add(condition);
            }
            foreach (string condition in ApplicationHistory.tableConditions[SqlTableDropdown.Text]["SelectRight"])
            {
                rightConditionDropdown.Items.Add(condition);
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
            manualSubmitQueryButton.Visible = true;

            submitAllButton.Visible = true;

            query = TestSql.BuildSelectQuery(SqlTableDropdown.SelectedItem.ToString(), selectFields, selectConditions);
            queryBox.Text = query;

        }

        private void SubmitFieldSelection_Click(object sender, EventArgs e)
        {
            // If an item was selected from dropdown
            // Prevents pressing button 
            if (fieldDropdown.SelectedIndex >= 0 && !selectFields.Contains(fieldDropdown.SelectedItem.ToString()))
            {
                selectFields.Add(fieldDropdown.SelectedItem.ToString());
                selectedFieldsGrid.Rows.Add(fieldDropdown.SelectedItem.ToString());
                fieldDropdown.SelectedIndex = -1;
                selectedFieldsGrid.Visible = true;

                query = TestSql.BuildSelectQuery(SqlTableDropdown.SelectedItem.ToString(), selectFields, selectConditions);
                queryBox.Text = query;
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
                    selectConditions.Add($"{val1} {val2} {val3} ");

                    leftConditionDropdown.SelectedIndex = -1;
                    leftConditionDropdown.Text = "";

                    middleConditionDropdown.SelectedIndex = -1;
                    middleConditionDropdown.Text = "";

                    rightConditionDropdown.SelectedIndex = -1;
                    rightConditionDropdown.Text = "";


                    conditionFieldsGrid.Rows.Add($"{val1} {val2} {val3} ");
                    conditionFieldsGrid.Visible = true;

                    query = TestSql.BuildSelectQuery(SqlTableDropdown.SelectedItem.ToString(), selectFields, selectConditions);
                    queryBox.Text = query;
                }
            }
        }

        private void SubmitConditionConjunction_Click(object sender, EventArgs e)
        {
            int conditionNum = conditionFieldsGrid.Rows.Count - 1;
            if (conditionNum % 2 != 0 && conditionConjunctDropdown.SelectedIndex >= 0)
            {
                selectConditions.Add(conditionConjunctDropdown.Text);
                conditionFieldsGrid.Rows.Add(conditionConjunctDropdown.Text);
                query = TestSql.BuildSelectQuery(SqlTableDropdown.SelectedItem.ToString(), selectFields, selectConditions);
                queryBox.Text = query;
            }
        }

        private void FinishQueryCreationButton_Click(object sender, EventArgs e)
        {
            selectedTable = new();
            selectedTableLabel = new();
            FillSelectTable();

            this.Controls.Add(selectedTableLabel);
            selectedTableLabel.Text = "Table Selected: " + SqlTableDropdown.Text;
            selectedTableLabel.TextAlign = ContentAlignment.MiddleCenter;
            selectedTableLabel.Dock = DockStyle.Top;
            selectedTableLabel.BringToFront();

            this.Controls.Add(selectedTable);
            selectedTable.RowHeadersVisible = false;
            selectedTable.AutoResizeColumns();
            selectedTable.BringToFront();
            selectedTable.Dock = DockStyle.Fill;
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
                selectConditions.RemoveAt(selectConditions.IndexOf(testCell.Value.ToString()));
                conditionFieldsGrid.Rows.RemoveAt(e.RowIndex);
            }
            if (conditionFieldsGrid.Rows.Count <= 1)
            {
                conditionFieldsGrid.Rows.Clear();
                conditionFieldsGrid.Visible = false;
                query = TestSql.BuildSelectQuery(SqlTableDropdown.SelectedItem.ToString(), selectFields, selectConditions);
                queryBox.Text = query;
            }
        }
        private void SelectedFieldsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var testCell = selectedFieldsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var msgBoxResult = MessageBox.Show
                               (
                                $"Do you want to remove the select field \"{testCell.Value}\"",
                                $"Remove Selected Field",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information
                               );

            if (msgBoxResult == DialogResult.Yes)
            {
                selectFields.RemoveAt(selectFields.IndexOf(testCell.Value.ToString()));
                selectedFieldsGrid.Rows.RemoveAt(e.RowIndex);
                query = TestSql.BuildSelectQuery(SqlTableDropdown.SelectedItem.ToString(), selectFields, selectConditions);
                queryBox.Text = query;
            }
            if (selectedFieldsGrid.Rows.Count <= 1)
            {
                selectedFieldsGrid.Rows.Clear();
                selectedFieldsGrid.Visible = false;
            }
        }

        private void ManualSubmitQuery_Click(object sender, EventArgs e)
        {
            query = queryBox.Text;
        }
    }
}

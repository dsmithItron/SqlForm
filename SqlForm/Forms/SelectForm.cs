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
            selectTable.DataSource = TestSql.ReaderQuery(query);
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

            query = TestSql.BuildSelectQuery(SqlTableDropdown.SelectedItem.ToString(), selectFields, selectConditions);
            queryBox.Text = query;

        }

        private void SubmitFieldSelection_Click(object sender, EventArgs e)
        {
            // If an item was selected from dropdown
            // Prevents pressing button 
            if (FieldDropdown.SelectedIndex >= 0 && !selectFields.Contains(FieldDropdown.SelectedItem.ToString()))
            {
                selectFields.Add(FieldDropdown.SelectedItem.ToString());
                selectedFieldsGrid.Rows.Add(FieldDropdown.SelectedItem.ToString());
                FieldDropdown.SelectedIndex = -1;
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
                    selectConditions.Add($"{val1} {val2} {val3} ");

                    LeftConditionDropdown.SelectedIndex = -1;
                    LeftConditionDropdown.Text = "";

                    MiddleConditionDropdown.SelectedIndex = -1;
                    MiddleConditionDropdown.Text = "";

                    RightConditionDropdown.SelectedIndex = -1;
                    RightConditionDropdown.Text = "";


                    conditionFieldsGrid.Rows.Add($"{val1} {val2} {val3} ");
                    conditionFieldsGrid.Visible = true;

                    query = TestSql.BuildSelectQuery(SqlTableDropdown.SelectedItem.ToString(), selectFields, selectConditions);
                    queryBox.Text = query;
                }
            }
        }

        private void ViewQueryButton_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();

            queryForm.parentForm = this;
            queryForm.canEdit = false;
            queryForm.queryString = query;

            queryForm.ChangeData();
            queryForm.Show();
        }

        private void ManualQueryButton_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();

            queryForm.parentForm = this;
            queryForm.canEdit = true;
            queryForm.queryString = query;

            queryForm.ChangeData();
            queryForm.Show();
        }

        private void FinishQueryCreationButton_Click(object sender, EventArgs e)
        {
            FillSelectTable();
            selectTable.BringToFront();
            selectTable.Dock = DockStyle.Fill;
        }

        private void submitConditionConjunction_Click(object sender, EventArgs e)
        {
            int conditionNum = conditionFieldsGrid.Rows.Count - 1;
            if(conditionNum%2 != 0 && conditionConjunctDropdown.SelectedIndex>=0)
            {
                selectConditions.Add(conditionConjunctDropdown.Text);
                conditionFieldsGrid.Rows.Add(conditionConjunctDropdown.Text);
                query = TestSql.BuildSelectQuery(SqlTableDropdown.SelectedItem.ToString(), selectFields, selectConditions);
                queryBox.Text = query;
            }
        }
    }
}

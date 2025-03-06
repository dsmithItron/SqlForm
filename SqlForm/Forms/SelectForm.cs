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
using SqlForm.Classes;

namespace SqlForm.Forms
{
    public partial class SelectForm : ChildSqlForm
    {
        List<String> selectFields = new();
        List<String> selectConditions = new();
        public SelectForm()
        {
            InitializeComponent();
            FillTableDropdown();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            FillSelectTable();
            selectTable.BringToFront();
            selectTable.Dock = DockStyle.Fill;
        }

        private void FillSelectTable()
        {
            selectTable.DataSource = TestSql.Select(SqlTableDropdown.SelectedItem.ToString(), selectFields, selectConditions);
        }

        private void FillTableDropdown()
        {
            SqlTableDropdown.Items.Clear();
            SqlTableDropdown.Items.Add("Specform_all_options");
            SqlTableDropdown.Items.Add("Xml_sql_mapping");
        }

        private void FillFieldDropDown()
        {
            FieldDropdown.Items.Clear();
            List<string> tableColumns = TestSql.GetColumns(SqlTableDropdown.Text);
            foreach(string field in tableColumns)
            {
                FieldDropdown.Items.Add(field);
            }
        }

        private void FillConditionalDropdown()
        {
            LeftConditionDropdown.Items.Clear();
            MiddleConditionDropdown.Items.Clear();
            RightConditionDropdown.Items.Clear();

            foreach(string condition in ApplicationHistory.tableConditions[SqlTableDropdown.Text]["SelectLeft"])
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
            FillFieldDropDown();
            FillConditionalDropdown();

            FieldDropdown.Visible = true;
            SubmitFieldSelection.Visible = true;

            LeftConditionDropdown.Visible = true;
            MiddleConditionDropdown.Visible = true;
            RightConditionDropdown.Visible = true;
            SubmitConditionSelection.Visible = true;
        }

        private void SubmitFieldSelection_Click(object sender, EventArgs e)
        {
            selectFields.Add(FieldDropdown.SelectedItem.ToString());
        }

        private void SubmitConditionSelection_Click(object sender, EventArgs e)
        {

            string val1 = LeftConditionDropdown.Text, val2 = MiddleConditionDropdown.Text, val3 = RightConditionDropdown.Text;
            if (!LeftConditionDropdown.Items.Contains(val1))
            {
                LeftConditionDropdown.Items.Add(val1);
                LeftConditionDropdown.SelectedItem = val1;
            }
            if (!MiddleConditionDropdown.Items.Contains(val2))
            {
                MiddleConditionDropdown.Items.Add(val2);
                MiddleConditionDropdown.SelectedItem = val2;
            }
            if (!RightConditionDropdown.Items.Contains(val3))
            {
                RightConditionDropdown.Items.Add(val3);
                RightConditionDropdown.SelectedItem = val3;
            }
        }
    }
}

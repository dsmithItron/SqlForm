using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlForm.Classes;

namespace SqlForm.Forms
{
    public partial class ResultForm : ChildSqlForm
    {
        ChildSqlForm parentForm;
        string resultType;
        string chosenTable;
        Color themeColor;
        public ResultForm(string table, string type, ChildSqlForm parent)
        {
            InitializeComponent();
            continueButton.Visible = false;
            chosenTable = table;
            resultType = type;
            parentForm = parent;

            if (resultType.Equals("SELECT", StringComparison.CurrentCultureIgnoreCase))
            {
                themeColor = Color.FromArgb(33, 150, 243);
                SelectPath();
            }
            if (resultType.Equals("Update", StringComparison.CurrentCultureIgnoreCase))
            {
                themeColor = Color.FromArgb(255, 87, 34);
                UpdatePath();
            }
        }

        private void ChangeElementsColor()
        {
            goBackButton.BackColor = themeColor;
            continueButton.BackColor = themeColor;
            footerPanel.BackColor = themeColor;
            headerPanel.BackColor = Color.Black;
            resultFormLabel.ForeColor = themeColor;
        }

        private void SelectPath()
        {
            ChangeElementsColor();
        }

        private void UpdatePath()
        {
            continueButton.Visible = false;
            ChangeElementsColor();
            resultFormLabel.Text = "Table Selected: " + chosenTable + "\n\nBefore Update";
            string selectQuery = TestSql.BuildSelectQuery(chosenTable, parentForm.conditions);
            resultDataGrid.DataSource = TestSql.ReaderQuery(selectQuery);
            FormatSelectTable();
            continueButton.Visible = true;
        }

        private void FormatSelectTable()
        {
            resultDataGrid.RowHeadersVisible = false;
            resultDataGrid.AutoResizeColumns();
            resultDataGrid.ReadOnly = true;
            resultDataGrid.Dock = DockStyle.Fill;
            resultDataGrid.ClearSelection();

            foreach (DataGridViewColumn column in resultDataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (string columnName in parentForm.fields)
            {
                if (resultDataGrid.Columns.Contains(columnName))
                {
                    for (int i = 0; i < resultDataGrid.RowCount; i++)
                    {
                        int columnIndex = resultDataGrid.Columns[columnName].Index;
                        resultDataGrid.Rows[i].Cells[columnIndex].Style.BackColor = Color.Black;
                    }
                }
            }
            resultDataGrid.Refresh();
        }


        private void ContinueButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            TestSql.NonReaderQuery(parentForm.query);
            Thread.Sleep(200);

            string selectQuery = TestSql.BuildSelectQuery(chosenTable, conditions);
            resultDataGrid.DataSource = TestSql.ReaderQuery(selectQuery);

            resultFormLabel.Text = "Table Selected: " + chosenTable + "\n\nAfter Update";
            this.Cursor = Cursors.Default;
        }
    }
}

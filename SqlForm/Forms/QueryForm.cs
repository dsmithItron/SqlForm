using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlForm.Forms
{
    public partial class QueryForm : Form
    {
        public bool canEdit = false;
        public string queryString = "";
        public ChildSqlForm parentForm;
        public QueryForm()
        {
            InitializeComponent();
        }

        public void ChangeData()
        {
            queryBox.Text = queryString;
            queryBox.Cursor = Cursors.No;
            queryBox.ReadOnly = true;
            if (canEdit == true)
            {
                queryBox.ReadOnly = false;
                queryBox.Cursor = Cursors.Default;
            }
        }

        private void UpdateQueryButton_Click(object sender, EventArgs e)
        {
            parentForm.query = queryBox.Text;
            this.Close();
        }
    }
}

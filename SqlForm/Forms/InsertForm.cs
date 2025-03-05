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
    public partial class InsertForm : ChildSqlForm
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            parentSqlForm.ResetForm();
        }
    }
}

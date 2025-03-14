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
    public partial class ChildSqlForm : Form
    {
        public SqlForm parentSqlForm;
        public string query = "";
        public List<string> tableColumns = new();
        public List<string> conditions = new();
        public List<string> fields = new();

        public ChildSqlForm()
        {
            InitializeComponent();
        }

    }
}

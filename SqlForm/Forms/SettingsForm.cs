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
    public partial class SettingsForm : ChildSqlForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void profileBox_TextChanged(object sender, EventArgs e)
        {
            if (profileBox.Text.Length > 0)
            {
                profileOptionsPanel.Visible = true;
            }
        }
    }
}

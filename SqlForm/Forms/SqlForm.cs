using System.Drawing;
using Azure;
using SqlForm.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SqlForm
{
    public partial class SqlForm : Form
    {
        private Form activeForm;

        public SqlForm()
        {
            InitializeComponent();
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            Thread.Sleep(100);
            if (activeForm != null) 
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.PanelDesktop.Controls.Add(childForm);
            UpdateLabelColors(childForm.Text.ToString());
            childForm.BringToFront();
            childForm.Show();

        }


        public void UpdateLabelColors(string FormName) 
        {
            switch (FormName)
            {
                case ("SelectForm"):
                    PanelTop.BackColor = Color.FromArgb(33, 150, 243);
                    HeaderLabel.Text = "Select";
                    break;

                case ("InsertForm"):
                    PanelTop.BackColor = Color.FromArgb(67, 183, 110);
                    HeaderLabel.Text = "Insert";
                    break;

                case ("DeleteForm"):
                    PanelTop.BackColor = Color.FromArgb(228, 26, 74);
                    HeaderLabel.Text = "Delete";
                    break;

                case ("UpdateForm"):
                    PanelTop.BackColor = Color.FromArgb(255, 87, 34);
                    HeaderLabel.Text = "Update";
                    break;

                default:
                    MessageBox.Show("Critical Error in UpdateLabelColor", $"Missing instance for {FormName}");
                    break;
            }
        }

        // Tool Methods
        private void SelectSidebarButton_Click(object sender, EventArgs e)
        {
            SelectForm newSelectForm = new();
            OpenChildForm(newSelectForm, sender);
        }

        private void InsertSidebarButton_Click(object sender, EventArgs e)
        {
            InsertForm newSelectForm = new();
            OpenChildForm(newSelectForm, sender);
        }

        private void DeleteSidebarButton_Click(object sender, EventArgs e)
        {
            DeleteForm newSelectForm = new();
            OpenChildForm(newSelectForm, sender);
        }

        private void UpdateSidebarButton_Click(object sender, EventArgs e)
        {
            UpdateForm newSelectForm = new();
            OpenChildForm(newSelectForm, sender);
        }

    }
}

using SqlForm.Forms;

namespace SqlForm
{
    public partial class SqlForm : Form
    {
        private Form activeForm;
        private Button currentButton;

        public SqlForm()
        {
            InitializeComponent();
            OpenChildForm(new HomeForm());
        }

        public void OpenChildForm(ChildSqlForm childForm)
        {
            Thread.Sleep(100);
            if (childForm.Text != "ResultForm")
            {
                activeForm?.Close();
                activeForm = childForm;
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            childForm.parentSqlForm = this;

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
                case ("HomeForm"):
                    PanelTop.BackColor = Color.FromArgb(3, 74, 124);
                    HeaderLabel.Text = "Home";
                    break;
                case ("SettingsForm"):
                    PanelTop.BackColor = Color.Gray;
                    HeaderLabel.Text = "Settings";
                    break;
                case ("ResultForm"):
                    break;
                default:
                    MessageBox.Show("Critical Error in UpdateLabelColor", $"Missing instance for {FormName}");
                    break;
            }
        }

        public void UpdateButtonColor(Button btnSender)
        {
            if (currentButton != btnSender)
            {
                if (currentButton != null)
                {
                    if (currentButton.Text != "Home")
                    {
                        currentButton.BackColor = Color.FromArgb(3, 64, 107);
                    }
                }
                currentButton = btnSender;
                switch (currentButton.Text.ToString())
                {
                    case ("Select"):
                        currentButton.BackColor = Color.FromArgb(33, 150, 243);
                        break;

                    case ("Insert"):
                        currentButton.BackColor = Color.FromArgb(67, 183, 110);
                        break;

                    case ("Delete"):
                        currentButton.BackColor = Color.FromArgb(228, 26, 74);
                        break;

                    case ("Update"):
                        currentButton.BackColor = Color.FromArgb(255, 87, 34);
                        break;
                    case ("Settings"):
                        currentButton.BackColor = Color.Gray;
                        break;
                    case ("Home"):
                        break;
                    default:
                        MessageBox.Show("Critical Error in UpdateButtonColor", $"Missing instance for {currentButton.Text.ToString()}");
                        break;
                }
            }
        }

        public void ResetForm()
        {
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(500);
            this.Cursor = Cursors.Default;
            UpdateButtonColor(this.HomeButton);
            OpenChildForm(new HomeForm());
        }


        // Tool Methods
        private void SelectSidebarButton_Click(object sender, EventArgs e)
        {
            UpdateButtonColor((Button)sender);
            OpenChildForm(new SelectForm());
        }

        private void InsertSidebarButton_Click(object sender, EventArgs e)
        {
            UpdateButtonColor((Button)sender);
            OpenChildForm(new InsertForm());
        }

        private void DeleteSidebarButton_Click(object sender, EventArgs e)
        {
            UpdateButtonColor((Button)sender);
        }

        private void UpdateSidebarButton_Click(object sender, EventArgs e)
        {
            UpdateButtonColor((Button)sender);
            OpenChildForm(new UpdateForm());
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            UpdateButtonColor((Button)sender);
            OpenChildForm(new HomeForm());
        }

        private void SettingsSidebarButton_Click(object sender, EventArgs e)
        {
            UpdateButtonColor((Button)sender);
            OpenChildForm(new SettingsForm());
        }
    }
}

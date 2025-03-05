
using SqlForm.Forms;

namespace SqlForm
{
    public partial class UpdateForm : ChildSqlForm
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            parentSqlForm.ResetForm();
        }
    }
}

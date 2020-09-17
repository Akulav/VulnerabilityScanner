using System;
using System.Windows.Forms;

namespace AuditScaner
{
    public partial class SuccessDialog : Form
    {
        private Form currentChildForm; 
        public SuccessDialog()
        {
            InitializeComponent();
        }

        private void Dialog_Click(object sender, EventArgs e)
        {
            try
            {
                if (ScannedReport.identifier == 1)
                {
                    Application.OpenForms["ScannedReport"].Close();
                }
            }


            catch
            {
                Application.OpenForms["RemoveOptions"].Close();
                Application.OpenForms["EditPolicy"].Close();
                OpenChildForm(new EditPolicy());
            }
            
        }

        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Controls.Add(childForm);
            childForm.Tag = childForm;
            childForm.SendToBack();
            Close();
        }
    }
}

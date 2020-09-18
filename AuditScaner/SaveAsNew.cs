using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuditScaner
{
    public partial class SaveAsNew : Form
    {
        private string selectedFile = RemoveOptions.selectedFile;
        public SaveAsNew()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void backToEditPolicies_Click(object sender, EventArgs e)
        {
            RemoveOptions.newName = "";
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            RemoveOptions.newName = NewName.Text;
            Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftSensConf
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }
        public static string password;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text=="")
            {
                MessageBox.Show("Enter a password");
            }
            else
            {
                FormPassword.password = textBoxPassword.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

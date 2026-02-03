using System;
using System.Windows.Forms;

namespace RouletteOfRepression
{
    public partial class disclaimerForm : Form
    {
        private void disclaimerForm_Load(object sender, EventArgs e)
        {

        }
        public disclaimerForm()
        {
            InitializeComponent();

            btnAccept.Enabled = false;
        }

        private Form2 Menu;

        private void accept_CheckedChanged(object sender, EventArgs e)
        {
            btnAccept.Enabled = accept.Checked;
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            if (accept.Checked)
            {
                Menu = new Form2();
                this.Hide();
                Menu.ShowDialog();
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void accept_CheckedChanged_1(object sender, EventArgs e)
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
            }
        }
    }    
    
    public static class money 
    {
        private static string Money;
        public static string moneyr
        {
            get { return Money; }
            set { Money = value; }
        }
    }
}

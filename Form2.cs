using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouletteOfRepression
{
    public partial class Form2 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            MenuFon.SendToBack(); 
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private RKNRoll RollRKN;

        private void rknbtn_Click(object sender, EventArgs e)
        {
            RollRKN = new RKNRoll();
            this.Hide();
            RollRKN.ShowDialog();
        }

        private ArrestRoll RollArrest;

        private void arrestBtn_Click(object sender, EventArgs e)
        {
            RollArrest = new ArrestRoll();
            this.Hide(); 
            RollArrest.ShowDialog();
        }

        private void NKOBtn_Click(object sender, EventArgs e)
        {

        }

        private void DopBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
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
            this.Hide();
            if (RollRKN == null)
                RollRKN = new RKNRoll();
            RollRKN.ShowDialog();
        }

        private ArrestRoll RollArrest;

        private void arrestBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (RollArrest == null)
                RollArrest = new ArrestRoll();
            RollArrest.ShowDialog();
        }

        private NKORoll RollNKO;
        private void NKOBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (RollNKO == null)
                RollNKO = new NKORoll();
            RollNKO.ShowDialog();
        }

        private Dop dop;
        private void DopBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (dop == null)
                dop = new Dop();
            dop.ShowDialog();
        }
    }
}

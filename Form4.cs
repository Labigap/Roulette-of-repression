using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RouletteOfRepression
{
    public partial class ArrestRoll : Form
    {
        private Form2 Menu;
        public ArrestRoll()
        {
            InitializeComponent();
        }

        private string[] ArrestListPeople = { "Алексеем Навальным", "Юлией Навальной",  "Евгением Пригожиным",
            /* Ютуберы */ "MyGap", "Майклом Наки", /* Ютуберы */ /* Депутаты */ "Львом Пономаревым", "Львом Марковичем", 
            "Максимом Кругловым", "Ильей Яшиным", "Евгением Боровиком" /* Депутаты */ };

        public bool spinmenu = true;
        public bool spin = false;
        public bool pay = false;
        public int ZP = 0;

        private string ForArr;

        public Random arrest = new Random();
        public Random zp = new Random();

        private void Form4_Load(object sender, EventArgs e)
        {
            fonarrest.SendToBack();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu = new Form2();
            Menu.ShowDialog();
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            int arrestind = arrest.Next(0, ArrestListPeople.Length); 
            ForArr = $"Что будем делать с {ArrestListPeople[arrestind]}?";
            RollPeople.Text = ForArr;
            spinmenu = false;
            spin = true;
            pay = false;
        }

        private bool btnInoag = false;
        private bool btnArrest = false;
        private bool btnKill = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btnInoag)
            {
                ZP = zp.Next(20000, 50000);
                pay = true;
                spin = false;
                spinmenu = false;
                btnInoag = false;
            }
            if (btnArrest)
            {
                ZP = zp.Next(50000, 120000);
                pay = true;
                spin = false;
                spinmenu = false;
                btnArrest = false;
            }
            if (btnKill)
            {
                ZP = zp.Next(120000, 200000);
                pay = true;
                spin = false;
                spinmenu = false;
                btnKill = false;
            }

            if (spinmenu)
            {
                qeL.Visible = true;
                Spin.Visible = true;
                MenuExit.Visible = true;
                RollPeople.Visible = false;
                Pay.Visible = false;
                inagentbtn.Visible = false;
                arrestbtn.Visible = false;
                killbtn.Visible = false;
                Contbtn.Visible = false;
                spin = false;
                pay = false;
            }
            if (spin)
            {
                qeL.Visible = true;
                MenuExit.Visible = true;
                Spin.Visible = false;
                RollPeople.Visible = true;
                Pay.Visible = false;
                inagentbtn.Visible = true;
                arrestbtn.Visible = true;
                killbtn.Visible = true;
                Contbtn.Visible = false;
                spinmenu = false;
                pay = false;
            }
            if (pay) 
            {
                Pay.Text = $"Вы заработали: {ZP.ToString()} рублей";
                qeL.Visible = true;
                MenuExit.Visible = true;
                Spin.Visible = false;
                RollPeople.Visible = false;
                Pay.Visible = true;
                inagentbtn.Visible = false;
                arrestbtn.Visible = false;
                killbtn.Visible = false;
                Contbtn.Visible = true;
                spinmenu = false;
                pay = false;
            }
        }

        private void inagentbtn_Click(object sender, EventArgs e)
        {
            btnInoag = true;
        }

        private void arrestbtn_Click(object sender, EventArgs e)
        {
            btnArrest = true;
        }

        private void killbtn_Click(object sender, EventArgs e)
        {
            btnKill = true;
        }

        private void Contbtn_Click(object sender, EventArgs e)
        {
            spinmenu = true;
            spin = false;
            pay = false;
        }
    }
}

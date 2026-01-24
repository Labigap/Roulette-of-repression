using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouletteOfRepression
{
    public partial class RKNRoll : Form
    {
        private Form2 Menu;

        public RKNRoll()
        {
            InitializeComponent(); 
        }

        private void RKNRoll_Load(object sender, EventArgs e)
        {
            fonrkn.SendToBack();   
        }

        public bool spinmenu = true;
        public bool spin = false;
        public bool Payzp = false;

        public Random Ban = new Random();
        public Random zp = new Random();

        private string BanToRoll;
        public int ZP = 0;

        private string[] BanListApps = {"Youtube", "Instagramm", "Twitter", "Facebook", "Tiktok", "Telegram",
                "Discord", "WatsApp", "Viber", "Twitch", "Snapchat", "Patreon", "Roblox", "FaceTime",
                "Steam", "VPN", "ChatGPT" };

        private void Start_Click(object sender, EventArgs e)
        {
            int BanIndex = Ban.Next(0, BanListApps.Length);
            BanToRoll = BanListApps[BanIndex];
            RollApp.Text = BanToRoll;
            ZPV = false;
            spinmenu = false;
            spin = true;
        }

        public static string moneycount
        {
            get { return money.moneyr; }
            set { money.moneyr = value; }
        }

        

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu = new Form2();
            Menu.ShowDialog();
        }

        private void spinmenutim_Tick(object sender, EventArgs e)
        {
            if (ForZPBan)
            {
                ZP = zp.Next(40000, 100000);
            }
            else if (ForZPSlow)
            {
                ZP = zp.Next(20000, 50000);
            }
            if (spinmenu)
            {
                RollApp.Visible = false;
                slowdownbtn.Visible = false;
                banbtn.Visible = false;
                whatban.Visible = true;
                Start.Visible = true;
                Pay.Visible = false;
                Contbtn.Visible = false;
                MenuExit.Visible = true;
                spin = false;
                ZPV = false;
            }
            if (spin)
            {
                RollApp.Visible = true;
                slowdownbtn.Visible = true;
                banbtn.Visible = true;
                whatban.Visible = true;
                Start.Visible = false;
                Pay.Visible = false;
                Contbtn.Visible = false;
                MenuExit.Visible = true;
                spinmenu = false;
                ZPV = false;
            }
            if (ZPV)
            {
                ForZPBan = false;
                ForZPSlow = false;
                RollApp.Visible = false;
                slowdownbtn.Visible = false;
                banbtn.Visible = false;
                whatban.Visible = false;
                Start.Visible = false;
                Pay.Text = $"Сегодня вы заработали: {ZP.ToString()} рублей";
                Pay.Visible = true;
                Contbtn.Visible = true;
                MenuExit.Visible = true;
                spinmenu = false;
                spin = false;
            }
            if (checkhslowdownbtn || checkbanbtn)
            {
                ZPV = true;
                spinmenu = false;
                spin = false;
                checkhslowdownbtn = false;
                checkbanbtn = false;
            }
        }

        public bool checkhslowdownbtn = false;
        public bool checkbanbtn = false;
        public bool ZPV = false;
        public bool ForZPSlow = false;
        public bool ForZPBan = false;

        private void slowdownbtn_Click(object sender, EventArgs e)
        {
            checkhslowdownbtn = true;
            ForZPSlow = true;
        }

        private void banbtn_Click(object sender, EventArgs e)
        {
            checkbanbtn = true;
            ForZPBan = true;
        }

        private void Contbtn_Click(object sender, EventArgs e)
        {
            ZPV = false;
            spinmenu = true;
        }
    }
}

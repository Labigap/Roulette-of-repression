using System;
using System.Windows.Forms;

namespace RouletteOfRepression
{
    public partial class NKORoll : Form
    {
        private Form2 Menu;

        public NKORoll()
        {
            InitializeComponent();

            SetState(GameState.Spinmenu);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            NKOfon.SendToBack();
        }

        private static readonly string[] BanOrganization = { "ОВД Инфо", "Радио Свобода", "НКО Голос", "НКО Мемориал",
            "Коммитетом против пыток", "Правозащитниками Урала", "Антивоенным коммитетом России", "Депутатами мирной России"};

        private void MenuExit_Click(object sender, EventArgs e)
        {
            ReturnToMenu();
        }

        private int Zapret_Min = 50000;
        private int Zapret_Max = 150000;
        private int Deport_Min = 120000;
        private int Deport_Max = 250000;
        private int KillA_Min = 250000;
        private int KillA_Max = 350000;

        private enum GameState
        {
            Spinmenu,
            Spin,
            PayZP
        }

        private GameState CurrentS;
        private readonly Random ForZp = new Random();
        private readonly Random ForOrg = new Random();
        private int CurrentZP;
        private string CurrentOrg;

        private void ReturnToMenu()
        {
            this.Hide();
            if (Menu == null)
            Menu = new Form2();
            Menu.ShowDialog();
        }

        private void SetState(GameState state)
        {
            CurrentS = state;
            UpdateUI();
        }

        private void Spinbtn_Click(object sender, EventArgs e)
        {
            SelectOrg();
            SetState(GameState.Spin);
        }

        private void SelectOrg()
        {
            int arrIndex = ForOrg.Next(0, BanOrganization.Length);
            CurrentOrg = BanOrganization[arrIndex];
            organizationL.Text = $"Что будем делать с {CurrentOrg}?";
        }

        private void ChoiseBan()
        {
            CurrentZP = ForZp.Next(Zapret_Min, Zapret_Max);
            SetState(GameState.PayZP);
        }

        private void ChoiseDeport()
        {
            CurrentZP = ForZp.Next(Deport_Min, Deport_Max);
            SetState(GameState.PayZP);
        }

        private void ChoiseKillAll()
        {
            CurrentZP = ForZp.Next(KillA_Min, KillA_Max);
            SetState(GameState.PayZP);
        }

        private void UpdateUI()
        {
            SetAllVisible(false);

            questionL.Visible = true;
            MenuExit.Visible = true;    

            switch(CurrentS)
            {
                case GameState.Spinmenu:
                    Spinbtn.Visible = true;
                    break;

                case GameState.Spin:
                    organizationL.Visible = true;
                    zapretbtn.Visible = true;
                    Deportbtn.Visible = true;
                    KillAllbtn.Visible = true;
                    break;

                case GameState.PayZP:
                    PayL.Text = $"Вы заработали: {CurrentZP} рублей";
                    congratulations.Visible = true;
                    PayL.Visible = true;
                    Contbtn.Visible = true;
                    break;
            }
        }

        private void SetAllVisible(bool IsVisible)
        {
            congratulations.Visible = IsVisible;
            Spinbtn.Visible = IsVisible;
            organizationL.Visible = IsVisible;
            zapretbtn.Visible = IsVisible;
            Deportbtn.Visible = IsVisible;
            KillAllbtn.Visible = IsVisible;
            PayL.Visible = IsVisible;
            Contbtn.Visible = IsVisible;
        }

        private void zapretbtn_Click(object sender, EventArgs e)
        {
            ChoiseBan();
        }

        private void Deportbtn_Click(object sender, EventArgs e)
        {
            ChoiseDeport();
        }

        private void KillAllbtn_Click(object sender, EventArgs e)
        {
            ChoiseKillAll();
        }

        private void Contbtn_Click(object sender, EventArgs e)
        {
            SetState(GameState.Spinmenu);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // хз че делает этот метод, но он важен, для себя на будущее изучить 
            // P.S.: да, этот конкретно метод написал не я

            if (Menu != null)
                Menu.Dispose();

        }
    }
}

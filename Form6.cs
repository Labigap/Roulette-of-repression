using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace RouletteOfRepression
{
    public partial class Dop : Form
    {
        private Form2 Menu;

        public Dop()
        {
            InitializeComponent();
        }

        private void Dop_Load(object sender, EventArgs e)
        {
            DopFon.SendToBack();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            ReturnToMenu();
        }
        private void ReturnToMenu()
        {
            this.Hide();
            if (Menu == null)
                Menu = new Form2();
            Menu.ShowDialog();
        }

        private void telegram_Click(object sender, EventArgs e)
        {
            string urlTg = "https://t.me/+HD9zkTzxZa05MzYy"; 
            try
            {
                Process.Start(new ProcessStartInfo(urlTg) { UseShellExecute = true });
            }
            catch (Exception ex) 
            {
                Debug.WriteLine($"Error Tg Ex{ex}");           
            }
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            string urlGitHub = "https://github.com/Labigap";
            try
            {
                Process.Start(new ProcessStartInfo(urlGitHub) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error Tg Ex{ex}");
            }
        }
    }
}
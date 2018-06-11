using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_GameProject
{
    public partial class RollADice : Form
    {
        public int Bet { get; set; }
        public static Random random = new Random();
        public int obida { get; set; }
        public RollADice()
        {
            InitializeComponent();
            lblYourName.Text = Form1.CurrPlayer.Name;
            changeMoney();
            obida = 0;
        }
        public void changeMoney() {
            lblMoney.Text = Form1.CurrPlayer.Money + "$";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int money = 0;
            int.TryParse(tbBet.Text, out money);
            Bet = money;
            ((Button)sender).Enabled = false;
            Form1.CurrPlayer.Money -= money;
            changeMoney();
            rollIt.Start();
        }

        private void tbBet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void rollIt_Tick(object sender, EventArgs e)
        {
            obida++;
            for (int i = 1; i <= 4; i++) {
                PictureBox pb = (PictureBox)Controls.Find("pictureBox"+i, false)[0];
                int brojce = random.Next(1,7);
                pb.Image = (Image)VP_GameProject.Properties.Resources.ResourceManager.GetObject("Alea_"+brojce);
            }
            if (obida == 11) {
                obida = 0;
                rollIt.Stop();
                btnGo.Enabled = true;
            }
        }
    }
}

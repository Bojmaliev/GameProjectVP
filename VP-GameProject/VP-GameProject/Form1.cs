using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_GameProject
{
    public partial class Form1 : Form
    {
        public static Player CurrPlayer = null;
        public Form1()
        {
            InitializeComponent();

            panel_LoggedIn.Visible = false;
            panel_Main.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - panel_Main.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel_Main.Height) / 2);
            btn_Close.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - btn_Close.Width) / 2, Screen.PrimaryScreen.WorkingArea.Height- btn_Close.Height -10);
            foreach (Control control in Controls) // reflection to sort flickering.
            {
                typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, control, new object[] { true });
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Attention!!!", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                if (CurrPlayer != null) CurrPlayer.Save();
                this.Close();
            }
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login regForm = new Login();
            if (regForm.ShowDialog() == DialogResult.OK)
            {
                CurrPlayer = regForm.ResultPlayer;
                LoggedIn();
            }
        }

        private void btn_NewUser_Click(object sender, EventArgs e)
        {
            Register regForm = new Register();
            if (regForm.ShowDialog() == DialogResult.OK) {
                CurrPlayer = regForm.ResultPlayer;
                LoggedIn();
            }
            
        }
        public void LoggedIn() {
            panel_Main.Visible = false;
            panel_LoggedIn.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.8);
            panel_LoggedIn.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.8);
            panel_LoggedIn.Visible = true;
            panel_LoggedIn.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - panel_LoggedIn.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel_LoggedIn.Height) / 2);
            lbl_Welcome.Text = CurrPlayer.Name + ", Welcome back";
            lbl_Welcome.Location = new Point((panel_LoggedIn.Width - lbl_Welcome.Width) / 2, 5);
            lbl_Money.Text = "Money: "+CurrPlayer.Money.ToString()+"$";
            lbl_Money.Location = new Point(panel_LoggedIn.Width - lbl_Money.Width - 20, panel_LoggedIn.Height - lbl_Money.Height - 20);
            btn_addMoney.Location = new Point(panel_LoggedIn.Width - lbl_Money.Width - 40-btn_Logout.Width, panel_LoggedIn.Height - btn_addMoney.Height - 20);
            panel_Games.Location = new Point((panel_LoggedIn.Width - panel_Games.Width) / 2, (panel_LoggedIn.Height - panel_Games.Height) / 2);

            btn_Logout.Location = new Point(10, panel_LoggedIn.Height-btn_Logout.Height-20);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            panel_LoggedIn.Visible = false;
            panel_Main.Visible = true;
            CurrPlayer.Save();
            CurrPlayer = null;
        }

        private void btn_addMoney_Click(object sender, EventArgs e)
        {
            DepositMoney dm = new DepositMoney();

            if (dm.ShowDialog() == DialogResult.OK)
            {
                CurrPlayer.Money += dm.MoneyToAdd;
                MessageBox.Show("You successfully added " + dm.MoneyToAdd);
                LoggedIn();
            }
        }

        private void btn_game1_Click(object sender, EventArgs e)
        {
            Roulette RouletteForm = new Roulette();
            RouletteForm.FormClosed += GameClosed;
            RouletteForm.Show();

        }
        public void GameClosed(object sender, FormClosedEventArgs e) {
            LoggedIn();
        }

        private void btn_game2_Click(object sender, EventArgs e)
        {
            //Change this variables
            //Filip Making 
            Slot Slot = new Slot();
            
            Slot.FormClosed += GameClosed;
            Slot.Show();
        }

        private void btn_game3_Click(object sender, EventArgs e)
        {
            //Change this variables
            RollADice RollADiceGame = new RollADice();
            RollADiceGame.FormClosed += GameClosed;
            RollADiceGame.Show();
        }
    }
}

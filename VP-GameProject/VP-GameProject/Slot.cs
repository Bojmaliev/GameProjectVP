using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_GameProject.Properties;

namespace VP_GameProject
{
    public partial class Slot : Form
    {
        
        // Declaring credits, total, bet, number, flag, random
        public int credits = Form1.CurrPlayer.Money;
        public int total = 0;
        public int bet = 5;
        public static Random r = new Random();
        public int number = 0;
        public bool flag = false;
        public SoundPlayer SoundPlayer { get; set; }


        // Declaring of each picture
        private int p1;
        private int p2;
        private int p3;

        public Slot()
        {
            spinTimer = new Timer();
            InitializeComponent();
        }

        private void Slot_Load(object sender, EventArgs e)
        {
            SoundPlayer = new SoundPlayer();
            label4.Text = "Your current balance is: "+ Form1.CurrPlayer.Money.ToString() + "$";
            label1.Text = string.Format("Credits: " + credits);
            label3.Text = "Win: 0";

            // Init the random
            p1 = r.Next(1, 4);
            p2 = r.Next(1, 4);
            p3 = r.Next(1, 4);

            pictureBox1.Image = (Image)VP_GameProject.Properties.Resources.ResourceManager.GetObject("Fruit_" + p1.ToString());
            pictureBox2.Image = (Image)VP_GameProject.Properties.Resources.ResourceManager.GetObject("Fruit_" + p2.ToString());
            pictureBox3.Image = (Image)VP_GameProject.Properties.Resources.ResourceManager.GetObject("Fruit_" + p3.ToString());
            
        }

           
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            bet = Convert.ToInt32(numericUpDown1.Value);
            if (credits >= bet)
            {
                number = 6;
                flag = true;
                label2.Text = "Bet:                 ";
                credits = credits - bet;
                Form1.CurrPlayer.Money = credits;
                label4.Text = "Your current balance is: " + Form1.CurrPlayer.Money.ToString() + "$";
                label1.Text = string.Format("Credits: " + credits);
                spinTimer.Start();
            }
       
        }

        private void spinTimer_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (number == 0)
                {
                    spinTimer.Stop();
                    calculate();
                    button1.Enabled = true;
                }
                else
                {
                    number--;
                    // Init the random
                    p1 = r.Next(1, 4);
                    p2 = r.Next(1, 4);
                    p3 = r.Next(1, 4);


                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = (Image)VP_GameProject.Properties.Resources.ResourceManager.GetObject("Fruit_" + p1.ToString());
                    }
                    if (pictureBox2.Image != null)
                    {

                        pictureBox2.Image.Dispose();
                        pictureBox2.Image = (Image)VP_GameProject.Properties.Resources.ResourceManager.GetObject("Fruit_" + p2.ToString());
                    }
                    if (pictureBox3.Image != null)
                    {
                        pictureBox3.Image.Dispose();
                        pictureBox3.Image = (Image)VP_GameProject.Properties.Resources.ResourceManager.GetObject("Fruit_" + p3.ToString());

                    }
                }
                
            }
            
            
        }
        void calculate()
        {
            //Orange = (bet == 5) == 65
            //Cherry = (bet == 5) == 40
            //Banana = (bet == 5) == 20
            //Calculating the win 
            total = 0;

                if (p1 == 3) total = total + 5;

                if (p1 == 2 & p2 == 2) total = total + 10;
                if (p1 == 3 & p2 == 3) total = total + 10;

                if (p1 == 1 & p2 == 1 & p3 == 1) total = total + 20;
                if (p1 == 2 & p2 == 2 & p3 == 2) total = total + 30;
                if (p1 == 3 & p2 == 3 & p3 == 3) total = total + 50;

            total *= Convert.ToInt32(numericUpDown1.Value);
            
                credits = credits + total;
            if (total > 0)
            {
                SoundPlayer.Stream = Resources.money;
                SoundPlayer.Play();
            }
            label3.Text = "Win: " + total.ToString();
                label1.Text = "Credits: " + credits.ToString();
            }
            
        
    }
}

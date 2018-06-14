using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_GameProject.Properties;

namespace VP_GameProject
{
    public partial class Roulette : Form
    {
        public RoulleteGame TheGame = null;
        public Roulette()
        {
            InitializeComponent();
            TheGame = new RoulleteGame();
            lbl_Bet.Text = "Your bet " + TheGame.Bets.Count() + "$";
            lbl_Earned.Text = "Make a round to get your earnings";
            changeMoney();
            timerSeconds.Start();
            timerRoll.Start();
            int left = 620;
            int top = 0;
            for (int i = 1; i <= 17; i++) {
                BetOnPicture pb = new BetOnPicture();

                Controls.Add(pb);
                pb.Name = "bet_" + i;
                pb.Location = new Point(left, top);
                left += 105;
                pb.Size = new Size(100, 130);
                pb.Position = i;
                
                if (i <= 13)
                {
                    pb.Chance = 12;
                    pb.BackgroundImage = (Image)Resources.ResourceManager.GetObject("bet_" + i);
                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (i == 14)
                {
                    pb.Chance = 2;
                    pb.BackColor = Color.Black;

                }
                else if (i == 15)
                {
                    pb.Chance = 2;
                    pb.BackColor = Color.Red;
                }
                else if (i == 16) {
                    pb.Chance = 2;
                    pb.BackgroundImage = (Image)Resources.ResourceManager.GetObject("male");
                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (i == 17)
                {
                    pb.Chance = 2;
                    pb.BackgroundImage = (Image)Resources.ResourceManager.GetObject("female");
                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                }

                pb.Click += new System.EventHandler(CashPlusOnButton);

                if (i % 7 == 0)
                {
                    left = 620;
                    top += 140;
                }
            }

        }
        public void changeMoney() {
            lblMoney.Text = Form1.CurrPlayer.Money.ToString() + "$";
        }


        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            if (!TheGame.GameFinished)
            {
                if (TheGame.Timer > 0) TheGame.Timer--;
                lblTimeStart.Text = TheGame.Timer.ToString();
            }
            else {
                double res = TheGame.Ball.Angle % 6.3;
                int position = (int)Math.Abs(Math.Floor(res / (6.3 / 13.00)));

                int suma = TheGame.CalculateFor(position);
                Form1.CurrPlayer.Money += suma;
                lbl_Earned.Text = "You earned "+suma+"$";
                changeMoney();
                TheGame = new RoulleteGame();
                loadTheBets();
                lbl_Bet.Text = "Your bet " + TheGame.Bets.Count() + "$"; 
            }
        }

        private void CashPlusOnButton(object sender, EventArgs e) {
            if (TheGame.Timer < 3) {
                return;
            }
            TheGame.BetOn((BetOnPicture)sender);
            if (Form1.CurrPlayer.Money > 0) Form1.CurrPlayer.Money--;
            else MessageBox.Show("You dont have money!");
            loadTheBets();
            lbl_Bet.Text = "Your bet " + TheGame.Bets.Count() + "$";
            changeMoney();

        }
        public void loadTheBets() {
            listBox1.Items.Clear();
            for (int i = 1; i <= 17; i++) {
                int HowMuch = 0;
                string Message = "";
                foreach (BetOnPicture bop in TheGame.Bets)
                {
                    if (bop.Position == i) HowMuch++;
                }
                if (i <= 13)
                {
                    Message = HowMuch + "$ on position " + i;
                } else if (i==14){
                    Message = HowMuch+ "$ on Black";
                }
                else if (i == 15)
                {
                    Message = HowMuch + "$ on Red";
                }
                else if (i == 16)
                {
                    Message = HowMuch + "$ on Male";
                }
                else if (i == 17)
                {
                    Message = HowMuch + "$ on Female";
                }
                if (HowMuch > 0) listBox1.Items.Add(Message);
            }
            
        }


        private void timerRoll_Tick(object sender, EventArgs e)
        {
            TheGame.Rotated += 5;
            TheGame.moveTheBall();
            pictureBox1.Image = RotateImage(pbIMAGE.Image, TheGame.Rotated, TheGame);
            


        }

        public static Image RotateImage(Image img, float rotationAngle, RoulleteGame rg)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);


            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));
            if(rg.Ball != null) rg.DrawBall(gfx);

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }
        
    }
}

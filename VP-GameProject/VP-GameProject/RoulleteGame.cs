using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_GameProject
{
    public class RoulleteGame
    {
        public int Timer { get; set; }
        public bool GameFinished { get; set; }
        public int Rotated { get; set; }
        public RouletteBall Ball { get; set; }
        public static Random random = new Random();
        public int TimeToRun {get;set;}
        public static double StartingAngle;
        public double MinusedAngle { get; set; }
        public List<BetOnPicture> Bets { get; set; }

        public RoulleteGame() {
            Timer = 15;
            GameFinished = false;
            Rotated = 0;
            TimeToRun = random.Next(5,32);
            MinusedAngle = 0;
            StartingAngle = random.Next(40, 51)/100.00;
            Bets = new List<BetOnPicture>();

        }

        public void moveTheBall() {
            if (Timer < 10 && Ball == null)
            {
                Ball = new RouletteBall();
            }
            else if (Ball != null) {
                if (MinusedAngle < StartingAngle)
                {
                    MinusedAngle += StartingAngle / (TimeToRun * 10);
                    Ball.Angle -= StartingAngle - MinusedAngle;
                }
                else {
                    GameFinished = true;
                }
                
            }
        }
        public void BetOn(BetOnPicture bet) {
            Bets.Add(bet);
        }
        public int CalculateFor(int position) {
            double suma = 0;

            foreach (BetOnPicture bop in Bets) {
                if (bop.Position == position)
                {
                    suma += bop.Chance;
                }
                else if (bop.Position == 14)
                {
                    if (position == 13) continue;
                    if (position % 2 != 0)
                    {
                        suma += bop.Chance;
                    }

                }
                else if (bop.Position == 15)
                {
                    if (position == 13) continue;
                    if (position % 2 == 0)
                    {
                        suma += bop.Chance;
                    }
                }
                else if (bop.Position == 16)
                {
                    if (position == 3 || position == 5 || position == 6 || position == 10 || position == 11 || position == 12 || position == 13) {
                        suma += bop.Chance;
                    }       
                }
                else if (bop.Position == 17)
                {
                    if (position == 1 || position == 2 || position == 4 || position == 7 || position == 8 || position == 9) 
                    {
                        suma += bop.Chance;
                    }
                }
            }

            return (int)(suma);
        }

        public void DrawBall(Graphics g) {
            Ball.Draw(g);
        }
    }
}

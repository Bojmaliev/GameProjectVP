using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_GameProject
{
    public class RollGame
    {
        public int Bet { get; set; }
        public int[] Results{ get; set; }
        public int NumRolls { get; set; }
        public static Random Random = new Random();
        public RollGame(int bet, int NumRolls = 11) {
            this.Bet = bet;
            Results = new int[5];
            this.NumRolls = NumRolls;
        }

        public bool Rolling() {
            for (int i = 0; i < 5; i++)
            {
                Results[i] = Random.Next(1, 7);
            }
            NumRolls--;
            if(NumRolls == 0)return false;
            return true;
        }
        public int GetMoney() {
            double my = (double)Results[0];
            double avarage = 0;
            for (int i = 1; i < 5; i++) {
                avarage += (double)Results[i];
            }
            avarage /= 4;

            int koef = 0;
            double diff = my - avarage;
            if (diff >= 0 && diff < 0.5) koef = 1;
            else if (diff >= 0.5 && diff < 1.5) koef = 2;
            else if (diff >= 1.5) koef = 3;

            return koef * Bet;

        }
    }
}

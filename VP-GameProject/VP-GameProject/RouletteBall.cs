using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_GameProject
{
    public class RouletteBall
    {
        public double Angle { get; set; }


        public void Draw(Graphics g) {
            int X = (int)(300 + Math.Cos(Angle) * 260);
            int Y = (int)(300 + Math.Sin(Angle) * 260);
            Brush brush = new SolidBrush(Color.Yellow);
            g.FillEllipse(brush, X-25, Y-25, 50, 50);
        }
    }
}

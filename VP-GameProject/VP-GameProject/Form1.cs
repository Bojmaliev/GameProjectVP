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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Centaring the panel
            panel_Main.Location = new Point((this.Width - panel_Main.Width) / 2, (this.Height - panel_Main.Height) / 2);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            
        }
    }
}

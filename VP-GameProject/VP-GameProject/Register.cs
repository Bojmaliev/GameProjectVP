using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_GameProject
{
    public partial class Register : Form
    {
        public Player ResultPlayer;
        public Register()
        {
            ResultPlayer = null;
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbPin.Text != "" && tbUsername.Text != "")
            {
                //Save to file
                try
                {
                    ResultPlayer = new Player(tbName.Text, tbUsername.Text, Convert.ToInt32(tbPin.Text));
                    //Return result
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                MessageBox.Show("All fields are required");
            }
        }

        private void tbPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}

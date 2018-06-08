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
    public partial class Login : Form
    {
        public Player ResultPlayer;
        public Login()
        {
            ResultPlayer = null;
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tbPin.Text != "" && tbUsername.Text != "")
            {
                try
                {
                    ResultPlayer = Player.Login(tbUsername.Text, Convert.ToInt32(tbPin.Text));

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex){
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

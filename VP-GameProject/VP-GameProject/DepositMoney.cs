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
    public partial class DepositMoney : Form
    {
        public int MoneyToAdd { get; set; }
        public DepositMoney()
        {
            InitializeComponent();
            MoneyToAdd = 0;
        }

        private void tbMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
            
        }

        private void btn_addFunds_Click(object sender, EventArgs e)
        {
            int money = 0;
            int.TryParse(tbMoney.Text, out money);
            MoneyToAdd = money;
            if (money <= 0) {
                MessageBox.Show("Enter valid amount of money !");
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class CurrencyAccount : Form
    {
        public CurrencyAccount()
        {
            InitializeComponent();
            BalanceRub.Text = Objects.user.rub.Balance.ToString() + " ₽";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            Close();
        }

        private void OpenUSD_Click(object sender, EventArgs e)
        {

        }
    }
}

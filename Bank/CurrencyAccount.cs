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
        private void openTngButton_Click(object sender, EventArgs e)
        {
            transferTngButton.Visible = true;
            historyTngButton.Visible = true;
            openTngButton.Visible = false;
            openTngButton.Enabled = true;
            label10.Visible = true;

        }

        private void openUsdButton_Click(object sender, EventArgs e)
        {
            transferUsdButton.Visible = true;
            historyUsdButton.Visible = true;
            openUsdButton.Visible = false;
            openUsdButton.Enabled = true;
            label8.Visible = true;

        }
    }
}

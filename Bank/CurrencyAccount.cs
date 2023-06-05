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
        public static bool _isCurAccUsd;
        public static bool _isCurAccTng;
        public CurrencyAccount()
        {
            InitializeComponent();
            BalanceRub.Text = Objects.user.rub.Balance.ToString() + " ₽";

            if (CurencyAccounts.currencyAccountTng == true)
            {
                transferTngButton.Visible = true;
                historyTngButton.Visible = true;
                openTngButton.Visible = false;
                openTngButton.Enabled = true;
                label10.Visible = true;
                balanseTngLabel.Text = Objects.user.tenge.Balance.ToString() + " ₸";
            }
            if (CurencyAccounts.currencyAccountUsd == true)
            {
                transferUsdButton.Visible = true;
                historyUsdButton.Visible = true;
                openUsdButton.Visible = false;
                openUsdButton.Enabled = true;
                label8.Visible = true;
                balanseUsdLabel.Text = Objects.user.usd.Balance.ToString() + " $";
            }
        }

        private void button1_Click(object sender, EventArgs e)//Кнопка назад
        {
            this.Hide();
            new WelcomeForm().ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)//Кнопка назад HSE
        {
            this.Hide();
            new WelcomeForm().ShowDialog();
            this.Close();
        }
        private void openTngButton_Click(object sender, EventArgs e)
        {

            if(CurencyAccounts.currencyAccountTng == false)
            {
            transferTngButton.Visible = true;
            historyTngButton.Visible = true;
            openTngButton.Visible = false;
            openTngButton.Enabled = true;
            label10.Visible = true;
            balanseTngLabel.Text = Objects.user.tenge.Balance.ToString() + " ₸";
            CurencyAccounts.currencyAccountTng = true;
            _isCurAccTng = true;
            Database.RewriteLine("tg");
            }
        }

        private void openUsdButton_Click(object sender, EventArgs e)
        {
            if (CurencyAccounts.currencyAccountUsd == false)
            {
                transferUsdButton.Visible = true;
                historyUsdButton.Visible = true;
                openUsdButton.Visible = false;
                openUsdButton.Enabled = true;
                label8.Visible = true;
                balanseUsdLabel.Text = Objects.user.usd.Balance.ToString() + " $";
                CurencyAccounts.currencyAccountUsd = true;
                _isCurAccUsd = true;
                Database.RewriteLine("USD");
            }
        }

        private void historyUsdButton_Click(object sender, EventArgs e)
        {

        }

        private void transferRubButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Transfers().ShowDialog();
            this.Close();
        }

        private void transferUsdButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Transfers().ShowDialog();
            this.Close();
        }

        private void transferTngButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Transfers().ShowDialog();
            this.Close();
        }
    }
}

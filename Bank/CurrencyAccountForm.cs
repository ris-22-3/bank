using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Classes;

namespace Bank
{
    public partial class CurrencyAccountForm : Form
    {
        public static bool _isCurAccUsd;
        public static bool _isCurAccTng;
        public static string boxValue;
        public static byte historyRubUsdOrTng;
        public CurrencyAccountForm()
        {
            InitializeComponent();
            BalanceRub.Text = Objects.user.rub.Balance.ToString() + " ₽";

            if (CurrencyAccount.currencyAccountTng == true)
            {
                transferTngButton.Visible = true;
                historyTngButton.Visible = true;
                openTngButton.Visible = false;
                openTngButton.Enabled = true;
                label10.Visible = true;
                balanseTngLabel.Text = Objects.user.tenge.Balance.ToString() + " ₸";
            }
            if (CurrencyAccount.currencyAccountUsd == true)
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

            if(CurrencyAccount.currencyAccountTng == false)
            {
            transferTngButton.Visible = true;
            historyTngButton.Visible = true;
            openTngButton.Visible = false;
            openTngButton.Enabled = true;
            label10.Visible = true;
            balanseTngLabel.Text = Objects.user.tenge.Balance.ToString() + " ₸";
            CurrencyAccount.currencyAccountTng = true;
            _isCurAccTng = true;
            Database.RewriteLine("tg");
            }
        }

        private void openUsdButton_Click(object sender, EventArgs e)
        {
            if (CurrencyAccount.currencyAccountUsd == false)
            {
                transferUsdButton.Visible = true;
                historyUsdButton.Visible = true;
                openUsdButton.Visible = false;
                openUsdButton.Enabled = true;
                label8.Visible = true;
                balanseUsdLabel.Text = Objects.user.usd.Balance.ToString() + " $";
                CurrencyAccount.currencyAccountUsd = true;
                _isCurAccUsd = true;
                Database.RewriteLine("USD");
            }
        }

        private void historyUsdButton_Click(object sender, EventArgs e)
        {
            historyRubUsdOrTng = 2;
            this.Hide();
            new HistoryTransfers().ShowDialog();
            this.Close();
        }

        private void transferRubButton_Click(object sender, EventArgs e)
        {
            boxValue = "RUB";
            this.Hide();
            new Transfers().ShowDialog();
            this.Close();   
        }

        private void transferUsdButton_Click(object sender, EventArgs e)
        {
            boxValue = "USD";
            this.Hide();
            new Transfers().ShowDialog();
            this.Close();
        }

        private void transferTngButton_Click(object sender, EventArgs e)
        {
            boxValue = "TNG";
            this.Hide();
            new Transfers().ShowDialog();
            this.Close();
        }

        private void closeTngButton_Click(object sender, EventArgs e)
        {

        }

        private void closeUsdButton_Click(object sender, EventArgs e)
        {

        }

        private void historyRubButton_Click(object sender, EventArgs e)
        {
            historyRubUsdOrTng = 1;
            this.Hide();
            new HistoryTransfers().ShowDialog();
            this.Close();
        }

        private void historyTngButton_Click(object sender, EventArgs e)
        {
            historyRubUsdOrTng = 3;
            this.Hide();
            new HistoryTransfers().ShowDialog();
            this.Close();
        }
    }
}

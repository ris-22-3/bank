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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
            if (Objects.user.isDeposit == true)
            {
                balanseRubLabel.Text = Objects.user.deposit.Balance.ToString() + " ₽";
                openDepositButton.Visible = false;
                openDepositButton.Enabled = false;
                label2.Visible = true;
                topUpButton.Visible = true;
                withdrawButton.Visible = true;
                month1Button.Visible = true;
                month3Button.Visible = true;
                month6Button.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                forMonthLabel.Visible = true;
                balanseRubLabel.Visible = true;
            }
            if (Objects.user.isDeposit == false)
            {
                balanseRubLabel.Text = Objects.user.deposit.Balance.ToString() + " ₽";
                openDepositButton.Visible = true;
                openDepositButton.Enabled = true;
                label2.Visible = false;
                topUpButton.Visible = false;
                withdrawButton.Visible = false;
                month1Button.Visible = false;
                month3Button.Visible = false;
                month6Button.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                forMonthLabel.Visible = false;
                balanseRubLabel.Visible = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WelcomeForm().ShowDialog();
            this.Close();
        }

        private void HSEBankLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WelcomeForm().ShowDialog();
            this.Close();
        }

        private void openDepositButton_Click(object sender, EventArgs e)
        {
            if (Objects.user.isDeposit == false)
            {
                openDepositButton.Visible = false;
                openDepositButton.Enabled = false;
                label2.Visible = true;
                topUpButton.Visible = true;
                withdrawButton.Visible = true;
                month1Button.Visible = true;
                month3Button.Visible = true;
                month6Button.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                forMonthLabel.Visible = true;
                balanseRubLabel.Visible = true;
                Objects.user.isDeposit = true;
                Database.RewriteLine("rub");
            }

        }
    }
}

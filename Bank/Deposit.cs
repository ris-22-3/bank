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
            forMonthSumLabel.Text = "";
            ownerSumLabel.Text = "";
            prosentSumLabel.Text = "";
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
                Database.RewriteLine("deposit");
            }

        }

        private void topUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositTransfersForm depositTransfers = new DepositTransfersForm();
            depositTransfers.ShowDialog();
            this.Close();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositTransfersForm depositTransfers = new DepositTransfersForm();
            depositTransfers.ShowDialog();
            this.Close();
        }

        private void accountTermsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Условия депозитного счета\r\n• Срок – не ограничен\r\n• Эффективная ставка – 1,25% от минимального баланса депозита, который был на нем в текущем месяце\r\n• Валюта - ₽\r\n• Номер договора – А94603847694\r\nСчет застрахован Фондом обязательного страхования вкладов на 10000000 ₽. В случае невыплаты банком нужной суммы клиенту, на банк заводится уголовное дело по статье 155 Уголовного Кодекса Российской Федерации. В случае неполной выплаты банком нужной суммы клиенту, на банк заводится уголовное дело по статье 155.1 Настоящего Кодекса. Но это не точно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        bool isDecimal = false;
        decimal value;
        private void month1Button_Click(object sender, EventArgs e)
        {
            isDecimal = decimal.TryParse(textBox1.Text, out value);
            if (isDecimal)
            {
                if (value > 0)
                {
                    forMonthLabel.Text = "За месяц я накоплю";
                    decimal prosent = 0;
                    decimal monthSum = 0;
                    decimal percent = 1.25m; // 1.25%
                    monthSum = value + (value * percent / 100);
                    prosent = monthSum - value;
                    forMonthSumLabel.Text = (Convert.ToString(monthSum) + " рублей");
                    ownerSumLabel.Text = (Convert.ToString(value) + " рублей" );
                    prosentSumLabel.Text = (Convert.ToString(prosent) + " рублей");
                }
                else
                {
                    MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void month3Button_Click(object sender, EventArgs e)
        {
            isDecimal = decimal.TryParse(textBox1.Text, out value);
            if (isDecimal)
            {
                if (value > 0)
                {
                    forMonthLabel.Text = "За 3 месяца я накоплю";
                    decimal prosent = 0;
                    decimal monthSum = 0;
                    decimal percent = 1.25m; // 1.25%
                    monthSum = value + (value * percent / 100);
                    monthSum = monthSum + (monthSum * percent / 100);
                    monthSum = monthSum + (monthSum * percent / 100);
                    monthSum = decimal.Round(monthSum, 2);
                    prosent = monthSum - value;
                    forMonthSumLabel.Text = (Convert.ToString(monthSum) + " рублей");
                    ownerSumLabel.Text = (Convert.ToString(value) + " рублей");
                    prosentSumLabel.Text = (Convert.ToString(prosent) + " рублей");
                }
                else
                {
                    MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void month6Button_Click(object sender, EventArgs e)
        {
            isDecimal = decimal.TryParse(textBox1.Text, out value);
            if (isDecimal)
            {
                if (value > 0)
                {
                    forMonthLabel.Text = "За 6 месяцев я накоплю";
                    decimal prosent = 0;
                    decimal monthSum = 0;
                    decimal percent = 1.25m; // 1.25%
                    monthSum = value + (value * percent / 100);
                    monthSum = monthSum + (monthSum * percent / 100);
                    monthSum = monthSum + (monthSum * percent / 100);
                    monthSum = monthSum + (monthSum * percent / 100);
                    monthSum = monthSum + (monthSum * percent / 100);
                    monthSum = monthSum + (monthSum * percent / 100);
                    monthSum = decimal.Round(monthSum, 2);
                    prosent = monthSum - value;
                    forMonthSumLabel.Text = (Convert.ToString(monthSum) + " рублей");
                    ownerSumLabel.Text = (Convert.ToString(value) + " рублей");
                    prosentSumLabel.Text = (Convert.ToString(prosent) + " рублей");
                }
                else
                {
                    MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

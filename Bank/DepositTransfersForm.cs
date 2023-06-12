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
    public partial class DepositTransfersForm : Form
    {
        public DepositTransfersForm()
        {
            InitializeComponent();
            label3.Text = Objects.user.rub.Balance.ToString() + " ₽";
        }

        private void HSEBankLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WelcomeForm().ShowDialog();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit deposit = new Deposit();
            deposit.ShowDialog();
            this.Close();
        }
        bool isDecimal = false;
        decimal value = 0;
        private void topUpButton_Click(object sender, EventArgs e)
        {
            isDecimal = decimal.TryParse(textBox1.Text, out value);
            if(isDecimal)
            {
                if(value > 0)
                {
                    Operation add = new Operation(value, false, "rub", "Другое", "Переводы", DateTime.Now);
                    Objects.user.rub.Balance -= Convert.ToDecimal(textBox1.Text);
                    Objects.user.rub.Add(add, true);



                    Objects.user.deposit.Balance += value;
                    Database.RewriteLine("deposit");
                    label3.Text = Objects.user.rub.Balance.ToString() + " ₽";
                    MessageBox.Show("Перевод выполнен успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            isDecimal = decimal.TryParse(textBox1.Text, out value);
            if (isDecimal)
            {
                if (value > 0)
                {
                    
                    Objects.user.deposit.Balance -= value;
                    Database.RewriteLine("deposit");


                    Operation add = new Operation(value, true, "rub", "Другое", "Пополнение", DateTime.Now);
                    Objects.user.rub.Balance += value;
                    Objects.user.rub.Add(add, true);
                    label3.Text = Objects.user.rub.Balance.ToString() + " ₽";
                    MessageBox.Show("Перевод выполнен успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

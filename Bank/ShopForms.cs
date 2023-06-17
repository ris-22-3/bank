using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank
{
    public partial class ShopForms : Form
    {
        public ShopForms()
        {
            InitializeComponent();
        }
        decimal value = 0;
        private void buyButton1_Click(object sender, EventArgs e)
        {
            value = 50;
            if (value < Objects.user.rub.Balance)
            {
                Operation add = new Operation(value, false, "rub", "Супермаркеты", "Покупка", DateTime.Now);
                Objects.user.rub.Balance -= value;
                Objects.user.rub.Add(add, true);
                MessageBox.Show("Покупка прошла успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyButton2_Click(object sender, EventArgs e)
        {
            value = 149;
            if (value < Objects.user.rub.Balance)
            {
                Operation add = new Operation(value, false, "rub", "Супермаркеты", "Покупка", DateTime.Now);
                Objects.user.rub.Balance -= value;
                Objects.user.rub.Add(add, true);
                MessageBox.Show("Покупка прошла успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyButton3_Click(object sender, EventArgs e)
        {
            value = 500;
            if (value < Objects.user.rub.Balance)
            {
                Operation add = new Operation(value, false, "rub", "Рестораны", "Покупка", DateTime.Now);
                Objects.user.rub.Balance -= value;
                Objects.user.rub.Add(add, true);
                MessageBox.Show("Покупка прошла успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyButton4_Click(object sender, EventArgs e)
        {
            value = 249;
            if (value < Objects.user.rub.Balance)
            {
                Operation add = new Operation(value, false, "rub", "Рестораны", "Покупка", DateTime.Now);
                Objects.user.rub.Balance -= value;
                Objects.user.rub.Add(add, true);
                MessageBox.Show("Покупка прошла успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyButton5_Click(object sender, EventArgs e)
        {
            value = 389;
            if (value < Objects.user.rub.Balance)
            {
                Operation add = new Operation(value, false, "rub", "Здоровье", "Покупка", DateTime.Now);
                Objects.user.rub.Balance -= value;
                Objects.user.rub.Add(add, true);
                MessageBox.Show("Покупка прошла успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyButton6_Click(object sender, EventArgs e)
        {
            value = 60;
            if (value < Objects.user.rub.Balance)
            {
                Operation add = new Operation(value, false, "rub", "Здоровье", "Покупка", DateTime.Now);
                Objects.user.rub.Balance -= value;
                Objects.user.rub.Add(add, true);
                MessageBox.Show("Покупка прошла успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyButton7_Click(object sender, EventArgs e)
        {
            value = 4700;
            if (value < Objects.user.rub.Balance)
            {
                Operation add = new Operation(value, false, "rub", "Развлечения", "Покупка", DateTime.Now);
                Objects.user.rub.Balance -= value;
                Objects.user.rub.Add(add, true);
                MessageBox.Show("Покупка прошла успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyButton8_Click(object sender, EventArgs e)
        {
            value = 900;
            if (value < Objects.user.rub.Balance)
            {
                Operation add = new Operation(value, false, "rub", "Развлечения", "Покупка", DateTime.Now);
                Objects.user.rub.Balance -= value;
                Objects.user.rub.Add(add, true);
                MessageBox.Show("Покупка прошла успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyButton9_Click(object sender, EventArgs e)
        {
            value = 1199;
            if (value < Objects.user.rub.Balance)
            {
                Operation add = new Operation(value, false, "rub", "Одежда", "Покупка", DateTime.Now);
                Objects.user.rub.Balance -= value;
                Objects.user.rub.Add(add, true);
                MessageBox.Show("Покупка прошла успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyButton10_Click(object sender, EventArgs e)
        {
            value = 3499;
            if (value < Objects.user.rub.Balance)
            {
                Operation add = new Operation(value, false, "rub", "Одежда", "Покупка", DateTime.Now);
                Objects.user.rub.Balance -= value;
                Objects.user.rub.Add(add, true);
                MessageBox.Show("Покупка прошла успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyButton11_Click(object sender, EventArgs e)
        {
            value = 438;
            if (value < Objects.user.rub.Balance)
            {
                Operation add = new Operation(value, false, "rub", "Транспорт", "Покупка", DateTime.Now);
                Objects.user.rub.Balance -= value;
                Objects.user.rub.Add(add, true);
                MessageBox.Show("Покупка прошла успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyButton12_Click(object sender, EventArgs e)
        {
            value = 35;
            if (value < Objects.user.rub.Balance)
            {
                Operation add = new Operation(value, false, "rub", "Транспорт", "Покупка", DateTime.Now);
                Objects.user.rub.Balance -= value;
                Objects.user.rub.Add(add, true);
                MessageBox.Show("Покупка прошла успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            new WelcomeForm().ShowDialog();
            this.Close();
        }
    }
}

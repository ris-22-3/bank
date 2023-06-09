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
    public partial class ATMForm : Form
    {
        public ATMForm()
        {
            InitializeComponent();
            Reboot();
        }
        public void Reboot()
        {
            Balance.Text = Objects.current.Balance.ToString() + " " + Objects.current.Account.ToString();
            FillTable();
            dataGridView.Refresh();
        }
        public void FillTable()
        {
            dataGridView.Rows.Clear();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            for (int i = 0; i < Objects.current.history.Count; i++)
            {
                DataGridViewRow row = AddRow(Objects.current.history[i]);
                rows.Add(row);
            }
            rows.Reverse();
            dataGridView.Rows.AddRange(rows.ToArray());
        }
        public DataGridViewRow AddRow(Operation op)
        {
            DataGridViewRow row = new DataGridViewRow();
            string day = "";
            if (op.date.Day < 10)
                day = "0";
            day += op.date.Day.ToString();
            string month = "";
            if (op.date.Month < 10)
                month = "0";
            month += op.date.Month.ToString();
            string dateStr = day + "." + month + "." + op.date.Year.ToString();
            DataGridViewCell date = new DataGridViewTextBoxCell();
            date.Value = dateStr;
            DataGridViewCell sum = new DataGridViewTextBoxCell();
            sum.Value = op.sum.ToString();
            DataGridViewCell type = new DataGridViewTextBoxCell();
            type.Value = op.type;
            row.Cells.AddRange(date, sum, type);
            return row;
        }
        private void button_500rub_Click(object sender, EventArgs e)
        {
            sumBox.Text = 500.ToString();
        }

        private void button_1000rub_Click(object sender, EventArgs e)
        {
            sumBox.Text = 1000.ToString();
        }

        private void button_2000rub_Click(object sender, EventArgs e)
        {
            sumBox.Text = 2000.ToString();
        }

        private void button_5000rub_Click(object sender, EventArgs e)
        {
            sumBox.Text = 5000.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WelcomeForm().ShowDialog();
            this.Close();
        }

        private void takeCash_Button_Click(object sender, EventArgs e)
        {
            TakeCash();
            FillTable();
        }
        public static int ToInt(string toint, int defaultValue = 0)
        {
            int n = defaultValue;
            bool isInt = int.TryParse(toint, out n);
            if (n >= int.MaxValue)
                n = int.MaxValue - 1;
            return n;
        }

        private void addCash_Button_Click(object sender, EventArgs e)
        {
            AddCash();
            FillTable();
        }

        private void sumBox_Click(object sender, EventArgs e)
        {
            sumBox.Text = "";
        }
        private void AddCash()
        {
            int sum = ToInt(sumBox.Text);
            if (sum <= 0)
                MessageBox.Show("Вводите значения только больше нуля");
            //if (sumBox.Text == "" || sumBox.Text == " ")
            //    
            else
            {
                //Operation add = new Operation(sum, true, ExpendType.Other.ToString(), "Внесение наличных", DateTime.Now);
                Operation add = new Operation(sum, true, "rub", "Другое", "Внесение наличных", DateTime.Now);
                Objects.current.Balance += sum;
                Objects.current.Add(add, true);
                Balance.Text = Objects.current.Balance.ToString() + " ₽";
            }
            sumBox.Text = default;
        }
        private void TakeCash()
        {
            int sum = ToInt(sumBox.Text);
            if (sum <= 0 || Objects.current.Balance - sum < 0 || sumBox.Text == "" || sumBox.Text == " ")
            {
                if (sum <= 0)
                    MessageBox.Show("Вводите значения только больше нуля");
                if (sum == int.MaxValue)
                    MessageBox.Show($"Вводите значения меньше {int.MaxValue - 1}");
                if (Objects.current.Balance - sum < 0)
                    MessageBox.Show("Недостаточно средств для выполнения операции");
                if (sumBox.Text == "" || sumBox.Text == " ")
                    MessageBox.Show("Введите сумму или выберите одну из предложенных");
            }
            else
            {
                Operation add = new Operation(sum, false, "rub", "Другое", "Выдача наличных", DateTime.Now);
                Objects.current.Balance -= sum;
                Objects.current.Add(add, true);
                Balance.Text = Objects.current.Balance.ToString() + " ₽";
            }
            sumBox.Text = default;
        }
    }
}

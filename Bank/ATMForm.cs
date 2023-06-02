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
            Balance.Text = Objects.user.rub.Balance.ToString() + " ₽";
            //FillTable();
        }
        public void FillTable()
        {
            for (int i = 0; i < Objects.user.rub.history.Count; i++)
            {
                string dateStr = Objects.user.rub.history[i].date.Day.ToString() + "." + Objects.user.rub.history[i].date.Month + "." + Objects.user.rub.history[i].date.Year.ToString();
                DataGridViewCell date = new DataGridViewHeaderCell();
                date.Value = dateStr;
                DataGridViewCell sum = new DataGridViewHeaderCell();
                DataGridViewCell type = new DataGridViewHeaderCell();
                sum.Value = Objects.user.rub.history[i].sum.ToString();
                type.Value = Objects.user.rub.history[i].type;
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(date, sum, type);
                dataGridView2.Rows.Add(row);
            }
            dataGridView2.Refresh();
            //string dateStr = Objects.user.rub.history[0].date.Day.ToString() + "." + Objects.user.rub.history[0].date.Month + "." + Objects.user.rub.history[0].date.Year.ToString();
            //DataGridViewCell date = new DataGridViewHeaderCell();
            //date.Value = dateStr;
            //DataGridViewCell sum = new DataGridViewHeaderCell();
            //DataGridViewCell type = new DataGridViewHeaderCell();
            //sum.Value = Objects.user.rub.history[0].sum.ToString();
            //type.Value = Objects.user.rub.history[0].type;
            //DataGridViewRow row = new DataGridViewRow();
            //row.Cells.AddRange(date, sum, type);
            //dataGridView2.Rows.Add(row);
            //dataGridView2.Rows.Add(list.GetString("id").ToString(), list.GetString("number").ToString(), list.GetString("NAME").ToString());

        }
        private void button_500rub_Click(object sender, EventArgs e)
        {
            sumBox.Text = 500.ToString();
            //Operation add = new Operation(500, false, "rub", "Другое", "Выдача наличных", DateTime.Now);
            //Objects.user.rub.Balance -= 500;
            //Objects.user.rub.Add(add, true);
            //Balance.Text = Objects.user.rub.Balance.ToString() + " ₽";
        }

        private void button_1000rub_Click(object sender, EventArgs e)
        {
            sumBox.Text = 1000.ToString();
            //Operation add = new Operation(1000, false, "rub", "Другое", "Выдача наличных", DateTime.Now);
            //Objects.user.rub.Balance -= 1000;
            //Objects.user.rub.Add(add, true);
            //Balance.Text = Objects.user.rub.Balance.ToString() + " ₽";
        }

        private void button_2000rub_Click(object sender, EventArgs e)
        {
            sumBox.Text = 2000.ToString();
            //Operation add = new Operation(2000, false, "rub", "Другое", "Выдача наличных", DateTime.Now);
            //Objects.user.rub.Balance -= 2000;
            //Objects.user.rub.Add(add, true);
            //Balance.Text = Objects.user.rub.Balance.ToString() + " ₽";
        }

        private void button_5000rub_Click(object sender, EventArgs e)
        {
            sumBox.Text = 5000.ToString();
            //Operation add = new Operation(5000, false, "rub", "Другое", "Выдача наличных", DateTime.Now);
            //Objects.user.rub.Balance -= 5000;
            //Objects.user.rub.Add(add, true);
            //Balance.Text = Objects.user.rub.Balance.ToString() + " ₽";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
            new WelcomeForm().ShowDialog();
        }

        private void takeCash_Button_Click(object sender, EventArgs e)
        {
            int sum = ToInt(sumBox.Text);
            if (sum <= 0)
                MessageBox.Show("Вводите значения только больше нуля");
            //if (sumBox.Text == "" || sumBox.Text == " ")
            //    
            else
            {
                Operation add = new Operation(sum, false, "rub", "Другое", "Выдача наличных", DateTime.Now);
                Objects.user.rub.Balance -= sum;
                Objects.user.rub.Add(add, true);
                Balance.Text = Objects.user.rub.Balance.ToString() + " ₽";
            }
            sumBox.Text = default;
        }
        public static int ToInt(string toint, int defaultValue = 0)
        {
            int n = defaultValue;
            bool isInt = int.TryParse(toint, out n);
            return n;
        }

        private void addCash_Button_Click(object sender, EventArgs e)
        {
            int sum = ToInt(sumBox.Text);
            if (sum <= 0)
                MessageBox.Show("Вводите значения только больше нуля");
            //if (sumBox.Text == "" || sumBox.Text == " ")
            //    
            else
            {
                Operation add = new Operation(sum, true, "rub", "Другое", "Внесение наличных", DateTime.Now);
                Objects.user.rub.Balance += sum;
                Objects.user.rub.Add(add, true);
                Balance.Text = Objects.user.rub.Balance.ToString() + " ₽";
            }
            sumBox.Text = default;
        }

        private void sumBox_Click(object sender, EventArgs e)
        {
            sumBox.Text = "";
        }
    }
}

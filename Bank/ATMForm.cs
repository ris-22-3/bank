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
            FillTable();
        }
        public void FillTable()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            for (int i = 0; i < Objects.user.rub.history.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                string dateStr = Objects.user.rub.history[i].date.Day.ToString() + "." + Objects.user.rub.history[i].date.Month + "." + Objects.user.rub.history[i].date.Year.ToString();

                DataGridViewCell date = new DataGridViewTextBoxCell();
                date.Value = dateStr;
                DataGridViewCell sum = new DataGridViewTextBoxCell();
                sum.Value = Objects.user.rub.history[i].sum.ToString();
                DataGridViewCell type = new DataGridViewTextBoxCell();
                type.Value = Objects.user.rub.history[i].type;
                row.Cells.AddRange(date, sum, type);
                rows.Add(row);
            }
            dataGridView.Rows.AddRange(rows.ToArray());
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
            Close();
            new WelcomeForm().ShowDialog();
        }

        private void takeCash_Button_Click(object sender, EventArgs e)
        {
            TakeCash();
        }
        public static int ToInt(string toint, int defaultValue = 0)
        {
            int n = defaultValue;
            bool isInt = int.TryParse(toint, out n);
            return n;
        }

        private void addCash_Button_Click(object sender, EventArgs e)
        {
            AddCash();
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
                Operation add = new Operation(sum, true, "rub", "Другое", "Внесение наличных", DateTime.Now);
                Objects.user.rub.Balance += sum;
                Objects.user.rub.Add(add, true);
                Balance.Text = Objects.user.rub.Balance.ToString() + " ₽";
            }
            sumBox.Text = default;
        }
        private void TakeCash()
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
    }
}

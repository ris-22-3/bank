using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using WinFormsTest;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bank
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            comboBox1_SelectedIndexFirst();
            label3.Text = Objects.user.name + " " + Objects.user.surname;
            Reboot();
            if (Objects.user.clientNumber == 1)
            {
                UserPictureBox.Image = Image.FromFile(@"./Images/Нагиев.jpg");
                UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (Objects.user.clientNumber == 2)
            {
                UserPictureBox.Image = Image.FromFile(@"./Images/Пугачёва.jpg");
                UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (Objects.user.clientNumber == 3)
            {
                UserPictureBox.Image = Image.FromFile(@"./Images/Петя.jpg");
                UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (Objects.user.clientNumber == 4)
            {
                UserPictureBox.Image = Image.FromFile(@"./Images/-V1Q7WU1G70.jpg");
                UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public void Reboot()
        {
            label5.Text = Objects.current.Balance.ToString() + " " + Objects.current.Account.ToString();
            FillTable();
            dataGridView_all.Refresh();
        }
        public void FillTable()
        {
            dataGridView_all.Rows.Clear();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            for (int i = 0; i < Objects.current.history.Count; i++)
            {
                DataGridViewRow row = AddRow(Objects.current.history[i]);
                rows.Add(row);
            }
            rows.Reverse();
            dataGridView_all.Rows.AddRange(rows.ToArray());
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
            DataGridViewCell billeType = new DataGridViewTextBoxCell();
            billeType.Value = Objects.current.Account.ToString();
            DataGridViewCell sum = new DataGridViewTextBoxCell();
            sum.Value = op.sum.ToString();
            DataGridViewCell type = new DataGridViewTextBoxCell();
            type.Value = op.type;
            row.Cells.AddRange(date, billeType, sum, type);
            return row;
        }

        private void MyAccountsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CurrencyAccountForm curencyAccounts = new CurrencyAccountForm();
            curencyAccounts.ShowDialog();
            this.Close();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit deposit = new Deposit();
            deposit.ShowDialog();
            this.Close();
        }

        private void MortgageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mortgage mortgageForm = new Mortgage();
            mortgageForm.ShowDialog();
            this.Close();
        }

        private void ATMButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ATMForm aTM = new ATMForm();
            aTM.ShowDialog();
            this.Close();
        }

        private void StatisticButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.ShowDialog();
            this.Close();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForms shop = new ShopForms();
            shop.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Objects.current = Objects.user.rub;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Objects.current = Objects.user.usd;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Objects.current = Objects.user.tenge;
            }
            else
            {
                Objects.current = Objects.user.rub; // По умолчанию рубли
            }
            Reboot();
        }
        private void comboBox1_SelectedIndexFirst()
        {
            if (Objects.current == Objects.user.rub)
            {
                comboBox1.SelectedIndex = 0;
            }
            else if (Objects.current == Objects.user.usd)
            {
                comboBox1.SelectedIndex = 1;
            }
            else if (Objects.current == Objects.user.tenge)
            {
                comboBox1.SelectedIndex = 2;
            }
            Reboot();
        }

    }
}
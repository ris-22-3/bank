using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using WinFormsTest;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bank
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            label3.Text = Objects.user.name + " " + Objects.user.surname;
            label5.Text = Objects.current.Balance.ToString();
            FillTable();
            dataGridView_all.Refresh();
            if (Objects.user.clientNumber == 4)
            {
                UserPictureBox.Image = Image.FromFile(@"../../../Images/-V1Q7WU1G70.jpg");
                UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
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
        private void StatisticButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.ShowDialog();
            this.Close();
        }

        private void ATMButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ATMForm aTMForm = new ATMForm();
            aTMForm.ShowDialog();
            this.Close();
        }

        private void MortgageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mortgage mortgageForm = new Mortgage();
            mortgageForm.ShowDialog();
            this.Close();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            //
        }

        private void MyAccountsButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CurrencyAccountForm curencyAccounts = new CurrencyAccountForm();
            curencyAccounts.ShowDialog();
            this.Close();
        }
    }
}
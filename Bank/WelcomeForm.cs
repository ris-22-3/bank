using System.Windows.Forms;
using WinFormsTest;

namespace Bank
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            label3.Text = Objects.user.name + " " + Objects.user.surname;
            label5.Text = Objects.user.rub.Balance.ToString();
            FillTable();
        }
        public void FillTable()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            for (int i = 0; i < Objects.user.history.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                string dateStr = Objects.user.history[i].date.Day.ToString() + "." + Objects.user.history[i].date.Month + "." + Objects.user.history[i].date.Year.ToString();
                DataGridViewCell date = new DataGridViewTextBoxCell();
                date.Value = dateStr;
                DataGridViewCell sum = new DataGridViewTextBoxCell();
                sum.Value = Objects.user.history[i].sum.ToString();
                DataGridViewCell type = new DataGridViewTextBoxCell();
                type.Value = Objects.user.history[i].type;
                row.Cells.AddRange(date, sum, type);
                rows.Add(row);
            }
            dataGridView_all.Rows.AddRange(rows.ToArray());
            dataGridView_all.Sort(new SortByData());
        }
        private void ATMButton_Click(object sender, EventArgs e)
        {
            ATMForm aTMForm = new ATMForm();
            aTMForm.Show();
        }
        private void MyAccountsButton_Click(object sender, EventArgs e)
        {
            CurrencyAccount curencyAccounts = new CurrencyAccount();
            curencyAccounts.Show();
        }

        private void MortgageButton_Click_1(object sender, EventArgs e)
        {
            Mortgage mortgageForm = new Mortgage();
            mortgageForm.Show();
        }

        private void StatisticButton_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }

        private void ATMButton_Click_1(object sender, EventArgs e)
        {
            ATMForm aTMForm = new ATMForm();
            aTMForm.Show();
        }


    }
}
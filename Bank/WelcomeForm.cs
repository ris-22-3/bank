using WinFormsTest;

namespace Bank
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
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
    }
}
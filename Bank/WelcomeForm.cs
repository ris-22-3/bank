using WinFormsTest;

namespace Bank
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void MortgageButton_Click(object sender, EventArgs e)
        {
            Mortgage mortgageForm = new Mortgage();
            mortgageForm.Show();
        }

        private void StatisticButton_Click_1(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }

        private void ATMButton_Click(object sender, EventArgs e)
        {
            ATMForm aTMForm = new ATMForm();
            aTMForm.Show();
        }
    }
}
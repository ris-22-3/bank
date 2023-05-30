using WinFormsTest;

namespace Bank
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void StatisticButton_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }

        private void MortgageButton_Click(object sender, EventArgs e)
        {
            Mortgage mortgageForm = new Mortgage();
            mortgageForm.Show();
        }
    }
}
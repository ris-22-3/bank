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
            new Mortgage().ShowDialog();
        }

        private void StatisticButton_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }
    }
}
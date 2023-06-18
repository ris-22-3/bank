using Bank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTest
{
    public partial class Mortgage : Form
    {
        private MortgageCalculation customer;

        public Mortgage()
        {
            this.Height = 1200;
            this.Width = 700;
            InitializeComponent();
            bApply.Enabled = false;
            bPaymentShedule.Enabled = false;
            cbApartmentType.Text = "Квартира";
            lPrice.Text = "500 тыс. ₽";
            lInitialFee.Text = "50 тыс. ₽";
            panel3.Height = 120;
            panel4.Height = panel3.Height;
            panel5.Height = panel4.Height;
            panel6.Height = panel5.Height;
            // Создание таблицы DataGridView
            foreach (DataGridViewColumn column in PaymentSheduleDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        public void PrintDataGrid(DataGridView dgv, MortgageCalculation customer)
        {
            DateTime currentDate = DateTime.Now; // Получение текущей даты
            int numberOfMonths = customer.Term * 12;
            decimal totalPayment = customer.RealEstatePrice + customer.RealEstatePrice * (customer.FindPercent() / 100) - customer.InitialFee;
            for (int i = 0; i < numberOfMonths; i++)
            {
                string year = currentDate.AddYears((i+5)/12).ToString("yyyy");
                decimal monthlyPayment = customer.FindMonthlyPayment();
                decimal remainingPayment = Math.Round(totalPayment - (monthlyPayment * (i + 1)));
                string monthName = currentDate.AddMonths(i).ToString("MMMM");
                // добавление строки в таблицу
                dgv.Rows.Add(year, monthName, Math.Round(monthlyPayment), Math.Round(remainingPayment));
            }

        }


        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new WelcomeForm().ShowDialog();
            this.Close();
        }

        private void tbTerm_Scroll_1(object sender, EventArgs e)
        {
            if (tbTerm.Value == 1) { lTerm.Text = $"1 год"; };
            if (tbTerm.Value <= 4 && tbTerm.Value != 1) { lTerm.Text = $"{tbTerm.Value} года"; }
            if (tbTerm.Value > 4 && tbTerm.Value != 1) lTerm.Text = $"{tbTerm.Value} лет";
        }

        private void tbInitialFee_Scroll_1(object sender, EventArgs e)
        {
            decimal price = (decimal)tbPrice.Value * 100000;
            decimal initialFee = price * tbInitialFee.Value / 100;
            if (initialFee / 1000 < 1000)
            {
                lInitialFee.Text = (initialFee / 1000) + " тыс. ₽";
            }
            else
            {
                lInitialFee.Text = (initialFee / 1000000) + " млн. ₽";
            }
        }

        private void tbPrice_Scroll_1(object sender, EventArgs e)
        {
            decimal price = (decimal)tbPrice.Value * 100000;
            decimal initialFee = price * tbInitialFee.Value / 100;

            if (price / 1000 < 1000) lPrice.Text = (price / 1000) + " тыс. ₽";
            else lPrice.Text = (price / 1000000) + " млн. ₽";
            if (initialFee / 1000 < 1000) lInitialFee.Text = (initialFee / 1000) + " тыс. ₽";
            else lInitialFee.Text = (initialFee / 1000000) + " млн. ₽";
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            bApply.Enabled = true;
            bPaymentShedule.Enabled = true;
            customer = new MortgageCalculation();
            customer.RealEstateType = cbApartmentType.Text;
            customer.RealEstatePrice = tbPrice.Value * 100000;
            customer.InitialFee = customer.RealEstatePrice * tbInitialFee.Value / 100;
            customer.Term = tbTerm.Value;
            InterestRateLable.Text = customer.FindPercent().ToString() + "%";
            MonthlyPaymentLabel.Text = Math.Round(customer.FindMonthlyPayment()) + " ₽";
            NecessaryIncomeLabel.Text = customer.FindNecessaryIncome() + " ₽";
        }

        private void bPaymentShedule_Click_1(object sender, EventArgs e)
        {
            PrintDataGrid(PaymentSheduleDGV, customer);
        }

        private void tbPrice_ValueChanged_1(object sender, EventArgs e)
        {
            PaymentSheduleDGV.Rows.Clear();
        }

        private void tbInitialFee_ValueChanged_1(object sender, EventArgs e)
        {
            PaymentSheduleDGV.Rows.Clear();
        }

        private void tbTerm_ValueChanged(object sender, EventArgs e)
        {
            PaymentSheduleDGV.Rows.Clear();
        }
    }
}

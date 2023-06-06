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


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close(); // Изменить (Переход на пред. страницу)
        }

        private void bAccept_Click_1(object sender, EventArgs e)
        {
            bApply.Enabled = true;
            bPaymentShedule.Enabled = true;
            MortgageCalculation customer = new MortgageCalculation();
            customer.RealEstateType = cbApartmentType.Text;
            customer.RealEstatePrice = tbPrice.Value * 100000;
            customer.InitialFee = customer.RealEstatePrice * tbInitialFee.Value / 100;
            customer.Term = tbTerm.Value;
            InterestRateLable.Text = customer.FindPercent().ToString() + "%";
            MonthlyPaymentLabel.Text = customer.FindMonthlyPayment() + " ₽";
            NecessaryIncomeLabel.Text = customer.FindNecessaryIncome() + " ₽";

        }

        private void tbPrice_Scroll(object sender, EventArgs e)
        {
            double price = (double)tbPrice.Value * 100000;
            double initialFee = price * tbInitialFee.Value / 100;

            if (price / 1000 < 1000)
            {
                lPrice.Text = (price / 1000) + " тыс. ₽";
            }
            else
            {
                lPrice.Text = (price / 1000000) + " млн. ₽";
            }

            if (initialFee / 1000 < 1000)
            {
                lInitialFee.Text = (initialFee / 1000) + " тыс. ₽";
            }
            else
            {
                lInitialFee.Text = (initialFee / 1000000) + " млн. ₽";
            }




        }

        private void tbInitialFee_Scroll(object sender, EventArgs e)
        {
            double price = (double)tbPrice.Value * 100000;
            double initialFee = price * tbInitialFee.Value / 100;
            if (initialFee / 1000 < 1000)
            {
                lInitialFee.Text = (initialFee / 1000) + " тыс. ₽";
            }
            else
            {
                lInitialFee.Text = (initialFee / 1000000) + " млн. ₽";
            }

        }

        private void tbTerm_Scroll(object sender, EventArgs e)
        {
            if (tbTerm.Value == 1) { lTerm.Text = $"1 год"; };
            if (tbTerm.Value <= 4 && tbTerm.Value != 1) { lTerm.Text = $"{tbTerm.Value} года"; }
            if (tbTerm.Value > 4 && tbTerm.Value != 1) lTerm.Text = $"{tbTerm.Value} лет";

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lInitialFee_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void PrintDataGrid(List<PaymentShedule> paymentShedules, DataGridView dgv) 
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            List<DataGridViewRow> dataGridViewRows = new List<DataGridViewRow>();
            foreach (var x in paymentShedules) 
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell _month = new DataGridViewTextBoxCell();
                DataGridViewCell _payment = new DataGridViewTextBoxCell();
                DataGridViewCell _remainder = new DataGridViewTextBoxCell();
                _month.Value = x.Month;
                _payment.Value = x.Payment;
                _remainder.Value = x.Remainder;
                row.Cells.Add( _month );
                row.Cells.Add( _payment );
                row.Cells.Add( _remainder );
                dataGridViewRows.Add( row );
            }
            dgv.Rows.AddRange( dataGridViewRows.ToArray() );
        }
    }
}

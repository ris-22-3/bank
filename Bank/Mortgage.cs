using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
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
            customer.RealEstatePrice = tbPrice.Value;
            customer.InitialFee = tbInitialFee.Value;
            customer.Term = tbTerm.Value;
            label8.Text = customer.ToString();

        }

        private void tbPrice_Scroll(object sender, EventArgs e)
        {
            double price = (double)tbPrice.Value * 100000;

            if (price / 1000 < 1000)
            {
                lPrice.Text = (price / 1000) + " тыс. ₽";
            }
            else
            {
                lPrice.Text = (price / 1000000) + " млн. ₽";
            }



        }

        private void tbInitialFee_Scroll(object sender, EventArgs e)
        {
            double price = (double)tbInitialFee.Value * 10000;
            if (price / 1000 < 1000) lInitialFee.Text = (price / 1000) + " тыс. ₽";

        }

        private void tbTerm_Scroll(object sender, EventArgs e)
        {
            if (tbTerm.Value == 1) { lTerm.Text = $"1 год"; };
            if (tbTerm.Value <= 4 && tbTerm.Value != 1) { lTerm.Text = $"{tbTerm.Value} года"; }
            if (tbTerm.Value > 4 && tbTerm.Value != 1) lTerm.Text = $"{tbTerm.Value} лет";

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class PaymentShedule
    {
        public string Month { get; set; }
        public decimal Payment { get; set; }
        public decimal RemainingPayment{ get; set; }

        public PaymentShedule() 
        {
            Month = string.Empty;
            Payment = 0;
            RemainingPayment = 0;



        }





    }
}

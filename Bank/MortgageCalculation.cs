using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest
{
    public class MortgageCalculation
    {
        double realEstatePrice;
        double initialFee;
        int term;
        public string RealEstateType { get; set; }
        public double RealEstatePrice 
        {
            get { return realEstatePrice; }
            set { if (value >= 0) realEstatePrice = value; }
        }
        public double InitialFee
        {
            get { return initialFee; }
            set { if (value > 0 && value * 10000 < realEstatePrice * 100000) initialFee  = value; }
        }
        public int Term
        {
            get { return term; }
            set { if (value > 0 && value <= 30) term = value; }
        }
        public MortgageCalculation() 
        {
            RealEstateType = "No type";
            RealEstatePrice = 0;
            InitialFee = 0;
            Term = 0;
        }

        public override string ToString() 
        {
            return $"\t{RealEstateType}:\nЦена недвижимости: {RealEstatePrice * 100000} ₽\nПервоначальный взнос: {InitialFee * 10000} ₽\nСрок кредита: {Term}";
        }
    }
}
 
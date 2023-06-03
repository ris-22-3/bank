using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest
{
    public class MortgageCalculation
    {
        
        public string RealEstateType { get; set; }
        public double RealEstatePrice { get; set; }
        public double InitialFee { get; set; }
        public int Term { get; set; }
        public MortgageCalculation() 
        {
            RealEstateType = "No type";
            RealEstatePrice = 0;
            InitialFee = 0;
            Term = 0;
        }

        public override string ToString() 
        {
            return $"\t{RealEstateType}:\nЦена недвижимости: {RealEstatePrice} ₽\nПервоначальный взнос: {InitialFee} ₽\nСрок кредита: {Term}";
        }
    }
}
 
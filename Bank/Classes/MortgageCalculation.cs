using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public  double FindPercent() 
        {
            double percent;

            // Минимальная процентная ставка в зависимости от типа недвижимости
            if (RealEstateType == "Коммерческая недвижимость") percent = 12.4;
            if (RealEstateType == "Гараж") percent = 11.4;
            else percent = 5.7;

            // Расчёт добавочных процентов
            return percent;
        }

        public double FindMonthlyPayment() 
        {
            double monthlyPayment = Math.Round(((RealEstatePrice += RealEstatePrice * (this.FindPercent() / 100)) - InitialFee) / (Term * 12));
            return monthlyPayment;

        }

        public double FindNecessaryIncome()
        {
            return Math.Round(this.FindMonthlyPayment() * 1.3);
        }
    }
}
 
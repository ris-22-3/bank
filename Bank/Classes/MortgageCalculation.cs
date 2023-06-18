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
        public decimal RealEstatePrice { get; set; }
        public decimal InitialFee { get; set; }
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
        public  decimal FindPercent() 
        {
            decimal percent;

            // Минимальная процентная ставка в зависимости от типа недвижимости
            switch (RealEstateType)
            {
                case "Гараж":
                    percent = 11.4m;
                    break;
                case "Коммерческая недвижимость":
                    percent = 12.2m;
                    break;
                default:
                    percent = 5.7m;
                    break;
            }
            // Расчёт добавочных процентов
            if (InitialFee < RealEstatePrice * 0.4m) percent += 0.5m;
            if (Term > 15) percent += 0.3m;
            return percent;
        }

        public decimal FindMonthlyPayment() 
        {
            decimal monthlyPayment = ((RealEstatePrice + RealEstatePrice * (this.FindPercent() / 100)) - InitialFee) / (Term * 12);
            return monthlyPayment;

        }

        public decimal FindNecessaryIncome()
        {
            return Math.Round(this.FindMonthlyPayment() * 1.3m); // Ежемесячный платёж должен составлять не больше 70% от дохода
        }

        public decimal FindTotalPayment() 
        {
            return RealEstatePrice + RealEstatePrice * (FindPercent() / 100) - InitialFee;
        }
    }
}
 
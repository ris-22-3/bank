using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Operation
    {
        public static Random rnd = new Random();
        public static string[] categories = { "Переводы", "Рестораны", "Супермаркеты", "Транспорт", "Одежда", "Развлечения и хобби", "Другое" };
        public static string[] types = { "Переводы", "Покупка", "Выдача наличных", "Другое" };
        public decimal sum;
        public bool isIncome;
        public string billeType;
        public string category;
        public string type;
        public DateTime date;
        public Operation()
        {
            sum = 0;
            isIncome = false;
            billeType = "rub";
            category = categories[rnd.Next(categories.Length)];
            type = "Покупка";
            date = DateTime.Now;
        }
        public Operation(decimal _sum, bool _isIncome, string _billeType, string _category, string _type, DateTime _date)
        {
            sum = _sum;
            isIncome = _isIncome;
            billeType = _billeType;
            category = _category;
            type = _type;
            date = _date;
        }
        
    }
}

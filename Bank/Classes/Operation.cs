using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public enum OperationType
    {
        Income, Expenditure
    }
    public enum ExpendType
    {
        Transfer, Purchase, WithDraw, Other
    }
    public class Operation
    {
        public static Random rnd = new Random();
        public static string[] categories = { "Переводы", "Рестораны", "Супермаркеты", "Транспорт", "Одежда", "Развлечения и хобби", "Другое" };
        public static string[] types = { "Переводы", "Покупка", "Выдача наличных", "Другое" };
        public decimal sum;
        public OperationType operationType = OperationType.Expenditure;
        public ExpendType expendType = ExpendType.Purchase;
        public string category;
        public string type;
        public DateTime date;
        public string billetype;
        public Operation(decimal _sum, bool _isIncome, string _billetype, string _category, string _type, DateTime _date)
        {
            sum = _sum;
            if (_isIncome)
                operationType = OperationType.Income;
            category = _category;
            //type = _type;
            date = _date;
            billetype = _billetype;
            expendType = ToExpendType(type);
        }
        public override string ToString()
        {
            switch(expendType)
            {
                case ExpendType.Purchase:
                    return "Покупка";
                case ExpendType.WithDraw:
                    return "Выдача наличных";
                case ExpendType.Transfer:
                    return "Переводы";
                case ExpendType.Other:
                    return "Другое";
            }
            return "Другое";
        }
        public ExpendType ToExpendType(string type)
        {
            switch (type)
            {
                case "Покупка":
                    return ExpendType.Purchase;
                case "Переводы":
                    return ExpendType.Transfer;
                case "Выдача наличных":
                    return ExpendType.WithDraw;
                default:
                    return ExpendType.Other;
            }
        }
    }
}

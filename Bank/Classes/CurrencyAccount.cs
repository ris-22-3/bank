using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    public enum Currency
    {
        RUB, USD, TNG, DEPOSIT
    }
    public class CurrencyAccount
    {
        public Currency Account;
        public decimal Balance;
        public bool isActive = false;
        public List<Operation> history = new List<Operation>();

        public CurrencyAccount()
        {
            Balance = 0;
            isActive = false;
            Account = Currency.RUB;
        }
        public CurrencyAccount(decimal balance, Currency currency)
        {
            Balance = balance;
            Account = currency;
        }
        public CurrencyAccount(decimal _balance, List<Operation> _history, Currency cur)
        {
            Balance = _balance;
            history = _history;
            isActive = true;
            Account = cur;
        }
        public void Add(Operation op, bool isNew = false)
        {
            if (isNew)
                Database.AddOperation(op); //добавление в файл
            history.Add(op);
        }
        public override string ToString()
        {
            switch (Account)
            {
                case Currency.RUB:
                    return "rub";
                case Currency.USD:
                    return "USD";
                case Currency.TNG:
                    return "tg";
            }
            return "rub";
        }
    }
}

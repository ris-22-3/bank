using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    public enum Currency
    {
        RUB, USD, TNG
    }
    public class CurrencyAccount
    {
        public Currency Account;
        public decimal Balance;
        public bool isActive;
        public List<Operation> history = new List<Operation>();
        //IEnumerable<Operation> incomes = history.Where(x => x.operationType == OperationType.Income);
        //IEnumerable<Operation> costs = history.Where(x => x.operationType == OperationType.Expenditure);

        public CurrencyAccount()
        {
            Balance = 0;
            isActive = false;
            Account = Currency.RUB;
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
    }
}

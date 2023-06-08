﻿using System;
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
        public decimal Balance;
        public Currency currency;
        public List<Operation> income;
        public List<Operation> costs;
        public List<Operation> history = new List<Operation>();

        public CurrencyAccount()
        {
            Balance = 0;
            income = new List<Operation>();
            costs = new List<Operation>();
        }
        public CurrencyAccount(decimal _balance, List<Operation> _incomes, List<Operation> _costs)
        {
            Balance = _balance;
            income = _incomes;
            costs = _costs;
        }
        public void Add(Operation op, bool isNew = false)
        {
            if (op.isIncome == true)
                income.Add(op);
            else
                costs.Add(op);
            if (isNew)
                Database.AddOperation(op); //добавление в файл
            history.Add(op);
            Objects.user.history.Add(op);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class ChartData
    {
        public double BalanceUSD { get; set; }
        public double BalanceRUB { get; set; }
        public double BalanceKZT { get; set; }
        public double Amount { get; set; }
        public bool Income { get; set; }
        public string Currency { get; set; }
        public string AccountType { get; set; }
        public string Category { get; set; }
        public string OperationType { get; set; }
        public DateTime Date { get; set; }
    }
}
